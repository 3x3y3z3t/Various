using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }


        private void numHours_ValueChanged(object sender, EventArgs e)
        {
            //int value = (int)numHours.Value;
            //DateTime d = DateTime.Now.AddHours(value);

        }

        private void btnTravel_Click(object sender, EventArgs e)
        {
            int hours = (int)numHours.Value;
            if (hours == 0)
            {
                Console.WriteLine("No travel (hours == 0)");
                return;
            }

            DateTime now = DateTime.Now;
            DateTime d = now.AddHours(hours);

            Console.WriteLine("Travelling to " + d.ToString());
            btnTravel.Enabled = false;
            m_TimeMachine.TimeTravelToPastOrFuture(hours);

            Task.Delay(c_DelayMillis).Wait();

            Console.WriteLine("Travelling to " + now.ToString());
            m_TimeMachine.TravelBackToPresent(c_DelayMillis);
            btnTravel.Enabled = true;


        }


        private const int c_DelayMillis = 1000;
        private readonly TimeMachine m_TimeMachine;


    }

}
