using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_2._2
{
    class AlarmClock
    {

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



        public AlarmClock()
            : this(0, 0)
        {

        }

       


        public AlarmClock(int hour, int minute):this(hour, minute, 0,0)
        {

            


        }


        public AlarmClock(int hour, int minute, int alarmHour, int alarmMinute)
        { 
        
            AlarmHour = alarmHour;
            AlarmMinute = alarmMinute;
            Hour = hour;
            Minute = minute;

        }


        public bool TickTock()
        {

            _minute++;

            if (_minute > 59)
            { _hour++; _minute = 0; }
            
            if (_hour > 23)
            { Hour = 0; }
            
            if (_hour == _alarmHour && _minute == _alarmMinute)
            { return true; }
            
            else
                return false;
        } 

        public string ToString()
        {

            if (_minute < 10)
            {
                displayTime = String.Format("{0, 5}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
                return displayTime;
            }

            else
            {
                displayTime = String.Format("{0,5}:{1:00} <{2}:{3:00}>", _hour, _minute, _alarmHour, _alarmMinute);
                return displayTime;
            }

            
        }
    
    }
}




