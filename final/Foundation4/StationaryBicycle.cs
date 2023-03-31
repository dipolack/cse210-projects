// Stationary Bicycle class derived from Activity
    public class StationaryBicycle : Activity

    {
        private double _speed;

        public StationaryBicycle(DateTime date, int length, double speed) : base(date, length)

        {
            
            _speed = speed;
        
        }

         // Override methods
        public override double GetSpeed()

        {
            
            return _speed;
        
        }

        public override double GetPace()

        {
            
            return 60 / _speed;
        
        }

         public override string GetActivityType()

        {
            
            return "Stationary Bicycle";
        
        }

        // Override GetSummary method to include stationary bicycle-specific information
        public override string GetSummary()

        {
            
            return $"{base.GetSummary()} - Speed {_speed:F1} km/h, Pace: {GetPace():F1} min per km";
        
        }
        
    }