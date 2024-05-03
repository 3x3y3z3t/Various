// ;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTraveller
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            m_TimeMachine = new TimeMachine();
            m_Timer = new(PerformTimeTravel, null, Timeout.Infinite, Timeout.Infinite);
        }

        private void PerformTimeTravel(object? _state)
        {
            if (m_Hours == 0)
            {
                Console.WriteLine("No travel (hours == 0)");
                return;
            }

            DateTime now = DateTime.Now;
            //DateTime d = now.AddHours(hours);

            //Console.WriteLine("Travelling to " + d.ToString());
            if (!m_IsTimeLoop)
                btnTravel.Enabled = false;

            m_TimeMachine.TimeTravelToPastOrFuture(m_Hours);

            Task.Delay(c_DelayMillis).Wait();

            //Console.WriteLine("Travelling to " + now.ToString());
            m_TimeMachine.TravelBackToPresent(c_DelayMillis);

            if (!m_IsTimeLoop)
                btnTravel.Enabled = true;
        }

        private void numHours_ValueChanged(object sender, EventArgs e)
        {
            m_Hours = (int)numHours.Value;
        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            PerformTimeTravel(null);
        }

        private void cbAuto_CheckedChanged(object sender, EventArgs e)
        {
            m_IsTimeLoop = cbAuto.Checked;

            if (cbAuto.Checked)
            {
                btnTravel.Enabled = false;
                m_Timer.Change(0, 1000);
            }
            else
            {
                btnTravel.Enabled = true;
                m_Timer.Change(Timeout.Infinite, Timeout.Infinite);
            }
        }


        private const int c_DelayMillis = 300;
        private readonly TimeMachine m_TimeMachine;
        private readonly System.Threading.Timer m_Timer;

        private int m_Hours = 0;
        private bool m_IsTimeLoop = false;
    }

}
