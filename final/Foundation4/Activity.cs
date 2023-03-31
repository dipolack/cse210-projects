using System;
using System.Collections.Generic;

    // Base Activity class
    public abstract class Activity

    {
        private DateTime _date;
        protected int _length;

        public Activity(DateTime date, int length)

        {
            
            _date = date;
            _length = length;

        }

         // Virtual methods to be overridden by derived classes
        public virtual double GetDistance()

        {
            
            return 0;

        }

        public virtual double GetSpeed()

        {
            
            return 0;
        
        }

        public virtual double GetPace()

        {
            
            return 0;
        
        }

        public virtual string GetActivityType()

        {
            
            return "Activity";

        }

         // Get summary method
        public virtual string GetSummary()

        {
            
            return $"{_date:dd MMM yyyy} {GetActivityType()}({_length} min)";

        }

    }

