using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace DogFoodAutomationMachine
{
    class Program
    {
        const int FULL = 10; // Represents max bowl weight.

        static void Main(string[] args)
        {
            CanReleaseFood();
        }




        // Returns a random value that acts as the weight in the bowl.
        static double GetWeight()
        {
            Random rand = new Random();
            double w = rand.Next(0, FULL+1);

            return w;
        }

        // Checks bowl weight every Interval.
        static void CanReleaseFood()
        {
            Console.WriteLine("Timer has begun.");
            Console.WriteLine("When finished, enter 'q' to quit the program.");

            Timer aTimer = new Timer();// Creates aTimer object.

            aTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent); // OnTimedEvent is the event/ thing that is called after Interval has passed 
            aTimer.Interval = 3000; // The duration to wait until the ElapsedEventHandler event is called.
            aTimer.Enabled = true; // "Starts" the Interval

            while (Console.Read() != 'q'); // Conditional to end simulator loop.
        }
        
        // Determines if bowl needs filling. 
        static void OnTimedEvent(object sender, ElapsedEventArgs e)
        {
            bool CRF = false; // Conditional to allow refilling of bowl.
            double weight = GetWeight();

            Console.WriteLine("\nWeight: {0}", weight);

            // Bowl is empty.
            if (weight == 0)
            {
                Console.WriteLine("Bowl is empty...");

                CRF = true;
                ReleaseFood(CRF);
            }
            // Bowl is less than half full.
            else if (weight < (FULL / 2))
            {
                Console.WriteLine("Bowl is less than half full...");

                CRF = true;
                ReleaseFood(CRF);
            }
            // Bowl doesn't need filling.
            else
            {
                CRF = false;
            }
            
        }

        // Activates Rotation Blades given certain conditions.
        static void ReleaseFood(bool CanRelease)
        {
            double weight = GetWeight();

            if(CanRelease == true)
            {
                Console.WriteLine("\nAdding food");

                // Add weight until it's half full
                while(weight < (FULL / 2))
                {
                    ActivateRB(ref weight);
                }
            }
        }

        // Simulates the internal blades rotating & adding food. 
        static void ActivateRB(ref double weight)
        {
            Random rand = new Random();
            int nw;

            nw = rand.Next(0, 11);
            weight += nw;
            if(weight > 0)
            {
                Console.WriteLine("New Weight: {0}", weight);
            }
        }
    }
}
