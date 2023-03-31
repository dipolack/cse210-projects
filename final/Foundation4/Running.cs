 // Running class derived from Activity
    public class Running : Activity

    {
        private double _distance;

        public Running(DateTime date, int length, double distance) : base(date, length)
        
        {
           
            _distance = distance;

        }

        // Override methods
        public override double GetDistance()

        {
           
            return _distance;

        }

        public override double GetSpeed()

        {
            
            // speed in km/h
            
            return _distance / (double)_length * 60 / 1.609; 

        }

        public override double GetPace()

        {
            // pace in min/km
            
            return (double)_length / _distance / 60; 

        }

         public override string GetActivityType()

        {
            
            return "Running";

        }

        // Override GetSummary method to include running-specific information
        public override string GetSummary()

        {
            
            return $"{base.GetSummary()} - Distance {_distance:F1} miles, Speed {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
        
        }
    
    }