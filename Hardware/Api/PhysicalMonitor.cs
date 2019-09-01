using System;
using System.Runtime.InteropServices;

namespace Hardware.MonitorSystemApi
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    internal struct PhysicalMonitor
    {
        public IntPtr hPhysicalMonitor;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)]
        public string PhysicalMonitorDescription;
    }
}
