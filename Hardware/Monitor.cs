using Hardware.MonitorSystemApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Hardware.Api.Monitor;

namespace Hardware
{
    public sealed class Monitor
    {
        private readonly PhysicalMonitor _monitorHandle;

        public string MonitorName => _monitorHandle.PhysicalMonitorDescription;

        public bool IsMonitorSupportDDC { get; private set; }

        public bool IsBrightnessSupported { get; private set; }

        public bool IsContrastSupported { get; private set; }

        public bool IsColorTemperatureSupported { get; private set; }

        public int MinimumBrightness { get; private set; }

        public int MaximumBrightness { get; private set; }

        public int Brightness { get; private set; }

        private bool _informationsLoaded;

        public override string ToString() => MonitorName;

        internal Monitor(PhysicalMonitor physicalMonitor)
        {
            _monitorHandle = physicalMonitor;
        }

        public Task LoadAsync() => Task.Run(() =>
        {
            uint
                monitorCapabilities = MC_CAPS_NONE,
                colors = MC_SUPPORTED_COLOR_TEMPERATURE_NONE;

            IsMonitorSupportDDC = GetMonitorCapabilities(_monitorHandle.hPhysicalMonitor, ref monitorCapabilities, ref colors);

            if (!IsMonitorSupportDDC) return;

            int error = Marshal.GetLastWin32Error();
            if (error != 0)
            {
                throw new Exception();
            }

            IsBrightnessSupported = (monitorCapabilities & MC_CAPS_BRIGHTNESS) == MC_CAPS_BRIGHTNESS;
            IsContrastSupported = (monitorCapabilities & MC_CAPS_CONTRAST) == MC_CAPS_CONTRAST;
            IsContrastSupported = (monitorCapabilities & MC_CAPS_CONTRAST) == MC_CAPS_CONTRAST;
            IsColorTemperatureSupported = (monitorCapabilities & MC_CAPS_COLOR_TEMPERATURE) == MC_CAPS_COLOR_TEMPERATURE;

            if (IsMonitorSupportDDC && IsBrightnessSupported)
            {
                int minimumBrightness = 0,
                    currentBrightness = 0,
                    maximumBrightness = 0;

                if (GetMonitorBrightness(_monitorHandle.hPhysicalMonitor, ref minimumBrightness, ref currentBrightness, ref maximumBrightness))
                {
                    MinimumBrightness = minimumBrightness;
                    Brightness = currentBrightness;
                    MaximumBrightness = maximumBrightness;
                }
            }

            _informationsLoaded = true;
        });

        public Task SetBrightness(int newValue)
        {
            if (!_informationsLoaded)
            {
                throw new InvalidOperationException($"Call {nameof(LoadAsync)} first.");
            }

            if (!IsBrightnessSupported)
            {
                throw new InvalidOperationException("Brightness is not supported");
            }

            if (newValue < MinimumBrightness && newValue > MaximumBrightness)
            {
                throw new ArgumentOutOfRangeException(nameof(newValue), newValue, $"Check {nameof(MinimumBrightness)} and {nameof(MaximumBrightness)} to get valid range of brightness values.");
            }

            return Task.Run(() =>
            {
                if (SetMonitorBrightness(_monitorHandle.hPhysicalMonitor, newValue))
                {
                    Brightness = newValue;
                }
                else
                {
                    throw new Exception("Brightness not setted up");
                }
            });
        }

        public static IEnumerable<Monitor> GetMonitors()
        {
            var lst = new List<Monitor>();

            GCHandle data = GCHandle.Alloc(lst);
            try
            {
                EnumDisplayMonitors(IntPtr.Zero, IntPtr.Zero, MonitorCallback, GCHandle.ToIntPtr(data));
            }
            finally
            {
                data.Free();
            }

            return lst;
        }

        private static bool MonitorCallback(IntPtr hMonitor, IntPtr hdcMonitor, IntPtr lpRectMonitor, IntPtr dwData)
        {
            var monitors = (List<Monitor>)GCHandle.FromIntPtr(dwData).Target;

            uint numberOfMonitors = 0;
            if (GetNumberOfPhysicalMonitorsFromHMONITOR(hMonitor, ref numberOfMonitors))
            {
                var phisicalMonitors = new PhysicalMonitor[numberOfMonitors];
                if (GetPhysicalMonitorsFromHMONITOR(hMonitor, numberOfMonitors, phisicalMonitors))
                {
                    for (int i = 0; i < numberOfMonitors; i++)
                    {
                        monitors.Add(new Monitor(phisicalMonitors[i]));
                    }
                }
            }

            return true;
        }
    }
}
