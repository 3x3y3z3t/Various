// ;
using System.Windows.Forms;

namespace TimeTraveller
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        //[STAThread]
        static void Main()
        {
            //public const string SE_SYSTEMTIME_NAME = "SeSystemtimePrivilege";
            //public const uint SE_PRIVILEGE_ENABLED = 0x00000002;

            ////IntPtr handle = Process.GetCurrentProcess().Handle;
            //IntPtr handle = Kerner32.GetCurrentProcess();

            //IntPtr token;
            //if (!AdvAPI32.OpenProcessToken(handle, (ushort)AccessToken.Query | (ushort)AccessToken.AdjustPrivileges, out token))
            //{
            //    Console.Write("OpenProcessToken() failed (errCode =  " + Marshal.GetLastWin32Error() + ")");
            //    return; // TODO: don't actually return;
            //}

            //if (!AdvAPI32.LookupPrivilegeValue(null, SE_SYSTEMTIME_NAME, out LUID privilegeLuid))
            //{
            //    Console.Write("LookupPrivilegeValue() failed (errCode =  " + Marshal.GetLastWin32Error() + ")");
            //    Kerner32.CloseHandle(token);
            //    return; // TODO: don't actually return;
            //}

            //TOKEN_PRIVILEGES privilege;
            //privilege.PrivilegeCount = 1;
            //privilege.Luid = privilegeLuid;
            //privilege.Attributes = SE_PRIVILEGE_ENABLED;

            //if (!AdvAPI32.AdjustTokenPrivileges(token, false, ref privilege, 0U, IntPtr.Zero, IntPtr.Zero))
            //{
            //    Console.Write("AdjustTokenPrivileges() failed (errCode =  " + Marshal.GetLastWin32Error() + ")");
            //    return; // TODO: don't actually return;
            //}

            //Kerner32.CloseHandle(token);

            //Console.WriteLine("Privilege set.");

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
