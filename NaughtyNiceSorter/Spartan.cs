namespace NaughtyNiceSorter
{
    public abstract class Spartan
    {
      
        protected static Random rnd = new Random();
        public string Location { get; set; }
        public string Name { get; set; }
        public string Present { get; set; }

        public abstract void DecidedPresent();



        public override string ToString()
        {
            return $"Name:{Name}, Location: {Location} is a getting {Present}";
        }
    }
}