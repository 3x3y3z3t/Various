// ;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using exw;

namespace TimeTraveller
{


    internal class TimeMachine
    {
        public TimeMachine() 
        { }


        public bool TimeTravelToPastOrFuture(int _hours)
        {
            if (_hours == 0)
                return false;

            Kerner32.GetSystemTime(ref m_SystemTime);

            //DateTime now = DateTime.Now.ToUniversalTime();
            DateTime d = m_SystemTime.ToDateTime();

            d = d.AddHours(_hours);
            m_SystemTime.ReplaceWithDateTime(d);

            bool status = Kerner32.SetSystemTime(ref m_SystemTime);
            int err = Marshal.GetLastWin32Error();

            m_HoursDifference += _hours;

            //DateTime now = DateTime.Now.ToUniversalTime();

            return status;
        }

        public bool TravelBackToPresent(int _offsetMillis)
        {
            if (m_HoursDifference == 0)
                return false;

            DateTime d = m_SystemTime.ToDateTime();

            d = d.AddHours(-m_HoursDifference);
            d = d.AddMilliseconds(_offsetMillis);

            m_SystemTime.ReplaceWithDateTime(d);

            bool status = Kerner32.SetSystemTime(ref m_SystemTime);
            int err = Marshal.GetLastWin32Error();

            m_HoursDifference = 0;

            return status;
        }


        private int m_HoursDifference = 0;
        private SYSTEMTIME m_SystemTime = new();


    }

}
