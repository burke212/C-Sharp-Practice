using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DogFoodAutomationMachine
{
    class Program
    {
        const int FULL = 10;
        private int mTimer=0;
        private bool M_CanReleaseFood = false;

        static void Main(string[] args)
        {
            CanReleaseFood();
        }

        //static void Timer()
        //{
        //    /*
        //     timer = 1hr
        //     while(timer != 0)
        //        timer - 1sec
        //     timer alarm
        //     */

        //    Timer timer = new Timer();
        //    timer.Elapsed += new ElapsedEventHandler();
        //    //timer.Interval = 3600000;// 1 hour
        //    timer.Interval = 5000;// 5 seconds
        //    timer.Enabled = true;
        //}

        static double GetWeight()
        {
            Random rand = new Random();
            // every 10 sec, check weight.
            double w = rand.Next(0, FULL+1);

            return w;
        }

        // Checks bowl weight every Interval.
        static void CanReleaseFood()
        {
            Console.WriteLine("/nTimer has begun.");
            Console.WriteLine("When finished, enter 'q' to quit the program.");
            Timer aTimer = new Timer();// Creates aTimer object

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent); // OnTimedEvent is the event/ thing that is called after Interval has passed 
            aTimer.Interval = 10000; // The duration to wait until the ElapsedEventHandler event is called.
            aTimer.Enabled = true; // "Starts" the Interval

            while (Console.Read() != 'q') ;
        }
        
        // Determines if bowl needs filling by getting bowl weight. 
        static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Program obj = new Program();
            double weight = GetWeight();

            Console.WriteLine("Weight: {0}", weight);

            // Bowl is empty
            if (weight == 0)
            {
                Console.WriteLine("Bowl is empty...");
                
                obj.M_CanReleaseFood = true;
            }
            // if bowl is less than half full
            else if (weight < (FULL / 2))
            {
                Console.WriteLine("Bowl is less than half full...");
                obj.M_CanReleaseFood = true;
            }
            // Bowl doesn't need filling
            else
            {
                obj.M_CanReleaseFood = false;
            }
            ReleaseFood();
        }

        static void ReleaseFood()
        {
            Program obj = new Program();
            double weight = GetWeight();

            if(obj.M_CanReleaseFood == true)
            {
                // Release food. 
                Console.WriteLine("Adding food");

                // Add weight until it's half full
                while(weight < (FULL / 2))
                {
                    ActivateRB(ref weight);
                }
            }
        }

        static void ActivateRB(ref double weight)
        {
            Random rand = new Random();
            int nw;

            nw = rand.Next(0, 11);
            weight += nw;

            Console.WriteLine("New Weight: {0}", weight);
        }
    }
}
