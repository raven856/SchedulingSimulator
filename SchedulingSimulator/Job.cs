using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingSimulator
{
    public class Job
    {
        //Instance Variables
        string id;
        public int arrivalTime;
        public int cpuCycle;
        public int waitTime = 0;
        public int turnaroundTime;
        public int remainingTime;
        public bool waiting = true;
        public bool completed = false;

        //Constructor
        public Job(string anId, int anArrivalTime, int aCpuCycle)
        {
            id = anId;
            arrivalTime = anArrivalTime;
            cpuCycle = aCpuCycle;
            remainingTime = aCpuCycle;
        }

       // public void 

    }
}
