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


            // Test av klockan där vi själva sätter in värdena/tiden som vi vill ha på displayen.
           //  Vi får även skapa nya fält för varje nytt test, clockTest 1, 2...
          //   Vi får kalla på våra metoder för att kunna skriva ut ett meddelande(string).
         //    De två första väderna vi sätter in är till klockan & de två sista som skrivs in är till alarmklockan.

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


            // Vi provar vår klocka igen. Denna gången med en TryCatch metod. Om värdena överstrider reglerna som vi har satt i klassen AlarmClock så skickas ett felmeddelande.
           //  Även här kallar vi på en metod för att skriva ut vårt meddelande.


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




        // Klockdisplay
       //  Med hjälp av en forloop så ökas minutvärdet en minut så långt som vi vill att klockan ska gå (Vad vi själva att satt in som värde).
      //   När värdet på alarmklockan stämmer överrens med den vanliga klockan så dyker ett meddelande upp bredvid den tiden.
     //    Vi kallar även på vår klass & döper om den till "ct".   

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

        // Här skapar vi nya metoder för våra meddelanden.

            private static string HorizontalLine;

            private static void ViewErrorMessage(string message)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(message);
                Console.ResetColor();
            }




        public static void ViewTestHeader(string header)
        {
            HorizontalLine = ("=======================================");

            Console.WriteLine(HorizontalLine);
            Console.WriteLine(header);
            Console.WriteLine();
        }




        }
    }


