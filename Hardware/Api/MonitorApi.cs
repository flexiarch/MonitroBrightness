using Hardware.MonitorSystemApi;
using System;
using System.Runtime.InteropServices;

namespace Hardware.Api
{
    internal static class Monitor
    {
        /*
        BOOL EnumDisplayMonitors(
          HDC             hdc,
          LPCRECT         lprcClip,
          MONITORENUMPROC lpfnEnum,
          LPARAM          dwData
        );
        */
        [DllImport(User32Dll)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool EnumDisplayMonitors(IntPtr hdc, IntPtr lprcClip, MONITORENUMPROC lpEnumFunc, IntPtr dwData);


        /*
            _BOOL GetNumberOfPhysicalMonitorsFromHMONITOR(
              HMONITOR hMonitor,
              LPDWORD  pdwNumberOfPhysicalMonitors
            );         
         */

        [DllImport(Dxva2Dll)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetNumberOfPhysicalMonitorsFromHMONITOR(IntPtr hmonitor, ref uint pdwNumberOfPhysicalMonitors);


        [DllImport(Dxva2Dll/*, EntryPoint = "GetPhysicalMonitorsFromHMONITOR"*/)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetPhysicalMonitorsFromHMONITOR(IntPtr hMonitor, uint dwPhysicalMonitorArraySize, [Out] PhysicalMonitor[] pPhysicalMonitorArray);


        /*
         _BOOL GetMonitorCapabilities(
          HANDLE  hMonitor,
          LPDWORD pdwMonitorCapabilities,
          LPDWORD pdwSupportedColorTemperatures
        );
        */
        [DllImport(Dxva2Dll, EntryPoint = "GetMonitorCapabilities", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorCapabilities(IntPtr hMonitor, ref uint pdwMonitorCapabilities, ref uint pdwSupportedColorTemperatures);

        public const uint
            MC_CAPS_NONE = 0x00000000,
            MC_CAPS_MONITOR_TECHNOLOGY_TYPE = 0x00000001,
            MC_CAPS_BRIGHTNESS = 0x00000002,
            MC_CAPS_CONTRAST = 0x00000004,
            MC_CAPS_COLOR_TEMPERATURE = 0x00000008,
            MC_CAPS_RED_GREEN_BLUE_GAIN = 0x00000010,
            MC_CAPS_RED_GREEN_BLUE_DRIVE = 0x00000020,
            MC_CAPS_DEGAUSS = 0x00000040,
            MC_CAPS_DISPLAY_AREA_POSITION = 0x00000080,
            MC_CAPS_DISPLAY_AREA_SIZE = 0x00000100,
            MC_CAPS_RESTORE_FACTORY_DEFAULTS = 0x00000400,
            MC_CAPS_RESTORE_FACTORY_COLOR_DEFAULTS = 0x00000800,
            MC_RESTORE_FACTORY_DEFAULTS_ENABLES_MONITOR_SETTINGS = 0x00001000,
            
            MC_SUPPORTED_COLOR_TEMPERATURE_NONE = 0x00000000,
            MC_SUPPORTED_COLOR_TEMPERATURE_4000K = 0x00000001,
            MC_SUPPORTED_COLOR_TEMPERATURE_5000K = 0x00000002,
            MC_SUPPORTED_COLOR_TEMPERATURE_6500K = 0x00000004,
            MC_SUPPORTED_COLOR_TEMPERATURE_7500K = 0x00000008,
            MC_SUPPORTED_COLOR_TEMPERATURE_8200K = 0x00000010,
            MC_SUPPORTED_COLOR_TEMPERATURE_9300K = 0x00000020,
            MC_SUPPORTED_COLOR_TEMPERATURE_10000K = 0x00000040,
            MC_SUPPORTED_COLOR_TEMPERATURE_11500K = 0x00000080
        ;

        /*
          _BOOL GetMonitorBrightness(
          HANDLE hMonitor,
          LPDWORD pdwMinimumBrightness,
          LPDWORD pdwCurrentBrightness,
          LPDWORD pdwMaximumBrightness
          );
         */
        [DllImport(Dxva2Dll, EntryPoint = "GetMonitorBrightness", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool GetMonitorBrightness(IntPtr hMonitor, ref int pdwMinimumBrightness, ref int pdwCurrentBrightness, ref int pdwMaximumBrightness);


        /*
        _BOOL SetMonitorBrightness (
        HANDLE hMonitor,
        DWORD dwNewBrightness
        ); 
        */
        [DllImport(Dxva2Dll, EntryPoint = "SetMonitorBrightness", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetMonitorBrightness(IntPtr hMonitor, int dwNewBrightness);


        private const string
            Dxva2Dll = "dxva2.dll",
            User32Dll = "user32.dll"
        ;
    }
}
