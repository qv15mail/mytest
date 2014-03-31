using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ReBoot
{
    class Program
    {
        const int POWER_STATE_RESET = 0x800000;
        [System.Runtime.InteropServices.DllImport("coredll.dll")]
        private static extern Int32 SetSystemPowerState(System.Char[] psState, System.Int32 StateFlags, System.Int32 Options);
        public static void WarmReset()
        {
            SetSystemPowerState(null, POWER_STATE_RESET, 0);
        }

        static void Main(string[] args)
        {
            WarmReset();
        }
    }
}
