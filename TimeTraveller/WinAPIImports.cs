// ;
using System;
using System.Runtime.InteropServices;

namespace exw
{
    //public enum AccessToken : ushort
    //{
    //    Query = 0x0008,
    //    AdjustPrivileges = 0x0020,
    //}

    [StructLayout(LayoutKind.Sequential)]
    internal struct SYSTEMTIME
    {
        public ushort m_Year;
        public ushort m_Month;
        public ushort m_DayOfWeek;
        public ushort m_Day;
        public ushort m_Hour;
        public ushort m_Minute;
        public ushort m_Second;
        public ushort m_Millisecond;

        public void ReplaceWithDateTime(DateTime _dt)
        {
            m_Year = (ushort)_dt.Year;
            m_Month = (ushort)_dt.Month;
            m_DayOfWeek = (ushort)_dt.DayOfWeek;
            m_Day = (ushort)_dt.Day;
            m_Hour = (ushort)_dt.Hour;
            m_Minute = (ushort)_dt.Minute;
            m_Second = (ushort)_dt.Second;
            m_Millisecond = (ushort)_dt.Millisecond;
        }

        public readonly DateTime ToDateTime()
        {
            return new (m_Year, m_Month, m_Day, m_Hour, m_Minute, m_Second, m_Millisecond);
        }
    }

    //[StructLayout(LayoutKind.Sequential)]
    //public struct LUID
    //{
    //    public UInt32 LowPart;
    //    public Int32 HighPart;
    //}

    //[StructLayout(LayoutKind.Sequential)]
    //public struct TOKEN_PRIVILEGES
    //{
    //    public UInt32 PrivilegeCount;
    //    public LUID Luid;
    //    public UInt32 Attributes;
    //}


    internal class Kerner32
    {
        //[DllImport("kernel32.dll", SetLastError = true)]
        //public static extern IntPtr GetCurrentProcess();

        //[DllImport("kernel32.dll", SetLastError = true)]
        //public static extern bool CloseHandle(IntPtr hHandle);


        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GetSystemTime(ref SYSTEMTIME _lpSystemTime);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME _lpSystemTime);

        //[DllImport("kernel32.dll", EntryPoint = "GetLastError")]
        //public static extern int GetLastError();

    }

    //internal class AdvAPI32
    //{
    //    [DllImport("advapi32.dll", SetLastError = true)]
    //    [return: MarshalAs(UnmanagedType.Bool)]
    //    public static extern bool OpenProcessToken(IntPtr _processHandle, uint _desiredAccess, out IntPtr _tokenHandle);

    //    [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    //    [return: MarshalAs(UnmanagedType.Bool)]
    //    public static extern bool LookupPrivilegeValue(string _systemName, string _privilegeName, out LUID _privilegeLuid);

    //    // Use this signature if you do not want the previous state
    //    [DllImport("advapi32.dll", SetLastError = true)]
    //    [return: MarshalAs(UnmanagedType.Bool)]
    //    public static extern bool AdjustTokenPrivileges(IntPtr _tokenHandle,
    //                                                    [MarshalAs(UnmanagedType.Bool)] bool _disableAllPrivileges,
    //                                                    ref TOKEN_PRIVILEGES _newState,
    //                                                    [In] uint _bufferLength,
    //                                                    IntPtr _previousState,
    //                                                    IntPtr _returnLength);

    //}






}
