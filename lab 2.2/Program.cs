using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewTestHeader("Test 1.\nTest av standardkonstrukton.");
                AlarmClock clockTest1 = new AlarmClock();
                Console.WriteLine(clockTest1.ToString());


            ViewTestHeader("Test 2.\nTest av konstrukton med två parametrar, (9, 42).");
                AlarmClock clockTest2 = new AlarmClock(9, 42);
                Console
                    .WriteLine(clockTest2.ToString());

            ViewTestHeader("Test 3.\nTest av konstrukton med fyra parametrar, (13, 24, 7, 35).");
                AlarmClock clockTest3 = new AlarmClock(13, 24, 7, 35);
                Console.WriteLine(clockTest3.ToString());


            ViewTestHeader("\nTest 4.\nStäller befintligt AlarmClock-objekt till tiden 23:58 & låter den gå 13 minuter.");
                clockTest3.Hour = 23;
                clockTest3.Minute = 58;
                clockTest3.AlarmHour = 7;
                clockTest3.AlarmMinute = 35;
                Run(clockTest3, 13);


            ViewTestHeader("\nTest 5.\nStäller befintligt AlarmClock-objekt till tiden 6:12 & alarmtiden til 6:15 & låter den gå i 6 minuter.");
                clockTest3.Hour = 6;
                clockTest3.Minute = 12;
                clockTest3.AlarmHour = 6;
                clockTest3.AlarmMinute = 15;
                Run(clockTest3, 6);


            ViewTestHeader("\nTest 6.\nTestar egenskaperna så att undantag kastas då tid & alarmtid tilldelas \nfelaktiga värden.");

                try
                {
                    clockTest3.Hour = 30;
                }
                catch (ArgumentException)
                {
                    ViewErrorMessage("Timmen är inte i intervallet 0-23."); 
                }


                    try
                    {
                        clockTest3.Minute = 70;
                    }
                    catch (ArgumentException)
                    {
                        ViewErrorMessage("Minuten är inte i intervallet 0-59.");
                    }


                try
                {
                    clockTest3.AlarmHour = 30;
                }
                catch (ArgumentException)
                {
                    ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23.");
                }


                    try
                    {
                        clockTest3.AlarmMinute = 70;
                    }
                    catch (ArgumentException)
                    {
                        ViewErrorMessage("Alarmminuten är inte i intervallet 0-59.");
                    }


            ViewTestHeader("Test 7. \nTestar konstruktorer så att undantag kastas då tid & alarmtid tilldelas \nfelaktiga värden.");

                try
                {
                    AlarmClock clockTest4 = new AlarmClock(24, 0);
                }
                catch (ArgumentException)
                {
                    ViewErrorMessage("Timmen är inte i intervallet 0-23.");
                }


                try
                {
                    AlarmClock clockTest5 = new AlarmClock(0, 0, 24, 0);
                }
                catch (ArgumentException)
                {
                    ViewErrorMessage("Alarmtimmen är inte i intervallet 0-23.");
                }


        }






        private static void Run(AlarmClock ct, int minute)
        {


            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(" ╔══════════════════════════════════════╗ ");
            Console.WriteLine(" ║       Väckarklockan URLED <TM>       ║ ");
            Console.WriteLine(" ║        Modellnr.:1DV402S2L2A         ║ ");
            Console.WriteLine(" ╚══════════════════════════════════════╝ ");
            Console.ResetColor();
            Console.WriteLine();



            for (int i = 0; i < minute; i++)
            {


                if (ct.TickTock())
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write("♫");
                    Console.Write(ct.ToString());
                    Console.WriteLine("  BEEP! BEEP! BEEP! BEEP!");
                    Console.ResetColor();
                }
                else
                {
                    Console.Write(" ");
                    Console.WriteLine(ct.ToString());
                }
            

            }
           
 
        }



            private static void ViewErrorMessage(string message)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }




        public static void ViewTestHeader(string header)
        {
            Console.WriteLine("=======================================");
            Console.WriteLine(header);
            Console.WriteLine();
        }




        }
    }


