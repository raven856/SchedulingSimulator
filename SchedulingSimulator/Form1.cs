using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchedulingSimulator
{
    public partial class Form1 : Form
    {
        int currentTime = -1;

        Job[] jobs = new Job[10];
        List<Job> waitList;
        public Form1()
        {
            jobs[0] = new Job("A", 0, 16);
            jobs[1] = new Job("B", 3, 2);
            jobs[2] = new Job("C", 5, 11);
            jobs[3] = new Job("D", 9, 6);
            jobs[4] = new Job("E", 10, 1);
            jobs[5] = new Job("F", 12, 9);
            jobs[6] = new Job("G", 14, 4);
            jobs[7] = new Job("H", 16, 14);
            jobs[8] = new Job("I", 17, 1);
            jobs[9] = new Job("J", 19, 8);

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            currentTime++;
            //Start: Add The Arriving Job
            for(int i = 0; i < 10; i++)
            {
                if(jobs[i].arrivalTime == currentTime)
                {
                    waitList.Add(jobs[i]);
                    break;
                }
            }
            //End: Add The Arriving Job

        }
    }
}
