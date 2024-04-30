// ;
using System;
using System.Runtime.InteropServices;

namespace exw
{
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


    internal class Kerner32
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern void GetSystemTime(ref SYSTEMTIME _lpSystemTime);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool SetSystemTime([In] ref SYSTEMTIME _lpSystemTime);

    }





}
