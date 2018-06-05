using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace TimerExample
{
    class Program
    {
        const int FULL = 10;
        static void Main(string[] args)
        {
            int interval = 0;
            int MM_Choice;
            bool mCanReleaseFood = false;


            Console.WriteLine("Choose an option to see the possibilities with the Timer class!");
            Console.WriteLine("1. Basic Timer");
            Console.WriteLine("2. Thread Timer");
            MM_Choice = Int16.Parse(Console.ReadLine());

            switch (MM_Choice)
            {
                case 1:
                    Console.WriteLine("\nEnter a value for the timer Interval duration.");
                    interval = Int32.Parse(Console.ReadLine()) * 1000;
                    BasicTimer(interval);
                    break;

                case 2:
                    ThreadTimer();
                    break;

                default:
                    break;
            }
        }

        //==================BASIC TIMER
        private static void BasicTimer(int i)
        {
            Console.WriteLine("/nTimer has begun.");
            Console.WriteLine("When finished, enter 'q' to quit the program.");
            Timer aTimer = new Timer();// Creates aTimer object

            aTimer.Elapsed += new ElapsedEventHandler(BasicOnTimedEvent); // OnTimedEvent is the event/ thing that is called after Interval has passed 
            aTimer.Interval = i; // The duration to wait until the ElapsedEventHandler event is called.
            aTimer.Enabled = true; // "Starts" the Interval

            while (Console.Read() != 'q') ;
        }

        private static void BasicOnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine(e.SignalTime);
        }


        //==================THREAD TIMER
        private static void ThreadTimer()
        {
            Console.WriteLine("/nTimer has begun.");
            Console.WriteLine("When finished, enter 'q' to quit the program.");
            Timer aTimer = new Timer();// Creates aTimer object

            aTimer.Elapsed += new ElapsedEventHandler(ThreadOnTimedEvent); // OnTimedEvent is the event/ thing that is called after Interval has passed 
            aTimer.Interval = 10000; // The duration to wait until the ElapsedEventHandler event is called.
            aTimer.Enabled = true; // "Starts" the Interval

            while (Console.Read() != 'q') ;
        }

        private static void ThreadOnTimedEvent(object sender, ElapsedEventArgs e)
        {
            Random rand = new Random();
            // every 10 sec, check weight.
            double w = rand.Next(0, FULL);

            Console.WriteLine("Weight: {0}", w);

            // Bowl is empty
            if (w == 0)
            {
                Console.WriteLine("Bowl is empty...");
            }
            else if (w < (FULL / 2))// if bowl is less than half full
            {
                Console.WriteLine("Bowl is less than half full...");
            }
        }
    }
}
