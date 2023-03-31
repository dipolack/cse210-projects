 // Swimming class derived from Activity
    public class Swimming : Activity

    {
        private int _laps;

        public Swimming(DateTime date, int length, int laps) : base(date, length)

        {
            
            _laps = laps;
        
        }

        // Override methods
        public override double GetDistance()

        {
        
            return _laps * 50 / 1000.0;
        
        }

        public override double GetSpeed()

        {
         
            return GetDistance() / (double)_length * 60 / 1.609; // speed in km/h
        
        }

        public override double GetPace()
        
        {
         
            return (double)_length / GetDistance() / 60; // pace in min/km
        
        }

        // Override GetSummary method to include swimming-specific information

        public override string GetSummary()

        {
            
            return $"{base.GetSummary()} - Laps: {_laps}, Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} km/h, Pace: {GetPace():F1} min per km";
        
        }

    }
