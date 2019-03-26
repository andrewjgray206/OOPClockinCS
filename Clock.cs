using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CounterTest
{
    class Clock
    {
        private readonly Counter _hours;
        private readonly Counter _minutes; //three counters for hours mins and secs, 
        private readonly Counter _seconds; //no need for an array as a clock always has these, and are easier to reference individually.

        public Clock() //constructor.
        {
            _hours = new Counter("Hours");
            _minutes = new Counter("Minutes");
            _seconds = new Counter("Seconds");
        }

        public string PrintTime()
        {
            return String.Format("{0:00}:{1:00}:{2:00}", _hours.Value, _minutes.Value, _seconds.Value);
        }

        public void Tick()
        {
            _seconds.Increment();
            if (_seconds.Value == 60)
            {
                _seconds.Reset();
                _minutes.Increment();
            }
            if (_minutes.Value == 60)
            {
                _minutes.Reset();
                _seconds.Reset();
                _hours.Increment();
            }
            if (_hours.Value == 24)
            {
                _seconds.Reset();
                _minutes.Reset();
                _hours.Reset();
            }
        }
        
        public void ResetClock() //resets the clock to 00:00:00
        {
            _seconds.Reset();
            _minutes.Reset();
            _hours.Reset();
        }

        public void AddHour() //this exists purely for testing purposes.
        {
            _hours.Increment();
        }
    }
}
