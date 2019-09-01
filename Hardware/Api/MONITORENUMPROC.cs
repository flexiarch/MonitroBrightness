using System;

namespace Hardware.MonitorSystemApi
{
    /*
     BOOL Monitorenumproc(
      HMONITOR Arg1,
      HDC Arg2,
      LPRECT Arg3,
      LPARAM Arg4
    )
    */
    internal delegate bool MONITORENUMPROC(IntPtr hMonitor, IntPtr hdcMonitor, IntPtr lpRectMonitor, IntPtr dwData);
}
