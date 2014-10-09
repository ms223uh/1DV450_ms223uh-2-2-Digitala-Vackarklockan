using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._2
{
    class AlarmClock
    {

        // Här skapar vi nya fält & egenskaper.
       //  Vi sätter även regler på våra fält.
      //   Timfältet får bara vara inom en intervall 0-23.
     //    Minutfältet får bara vara inom en intervall 0-59.

        private int _alarmHour;

        public int AlarmHour
        {
            get { return _alarmHour; }
            set 
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();  
                }
            
                _alarmHour = value; 
            }
        }



        private int _alarmMinute;

        public int AlarmMinute
        {
            get { return _alarmMinute; }
            set 
            {
                if (value < 0 || value > 59)

                    throw new ArgumentException();  
            
                _alarmMinute = value;
            }
            }



        private int _hour;

        public int Hour
        {
            get { return _hour; }
            set
            {
                if (value < 0 || value > 23)
                {
                    throw new ArgumentException();
                }
                _hour = value;
            }
        }



        private int _minute;

        public int Minute
        {
            get { return _minute; }
            set
            {
                if (value < 0 || value > 59)
                {
                    throw new ArgumentException();
                }
                _minute = value;
            }
        }

        private string displayTime;

        // Skapar nya metoder & bestämmer vilka egenskaper dem ska rätta sig efter.

        public AlarmClock()
            : this(0, 0)
        {

        }

       


        public AlarmClock(int hour, int minute):this(hour, minute, 0,0)
        {

            


        }

        // Skapar ny metod & bestämmer vilka fält/egenskaper som ska ingå.

        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        { 
        
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            Hour = hour;
            Minute = minute;

        }

        // Här bestämmer vi att när minutvisaren slår över 59 så ökar vi värdet på timvisare med 1 & minutvisaren slår om till 0 & börjar om.
       //  Här bestämmer vi även att om klockan & alarmklockan stämmer överrens så ska ett meddelande skrivas ut (visas i Program klassen).

        public bool TickTock()
        {

    

           if (Minute < 59)
           {
               Minute++;
           }
           else
           {
               Minute = 0;
               if (Hour < 23)
               {
                   Hour++;
               }
               else
               {
                   Hour = 0; 
               }
           }
             /*   _hour++; _minute = 0; }
            
            if (_hour > 23)
            { _hour = 0; }*/
            
            if (Hour == AlarmHour && Minute == AlarmMinute)
            { return true; }
            
            else
                return false;
              
        } 


        // Bestämmer hur decimalvärdet ska skrivas ut.

        public string ToString()
        {

            if (Minute < 10)
            {
                displayTime = String.Format("{0,5}:{1:00} <{2}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute);
                return displayTime;
            }

            else
            {
                displayTime = String.Format("{0,5}:{1:00} <{2}:{3:00}>", Hour, Minute, AlarmHour, AlarmMinute);
                return displayTime;
            }

            
        }
    
    }
}




