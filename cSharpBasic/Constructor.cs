namespace AllAboutConstructors

{    
    public class Country

    {
        public string Name { get; set; }//This is a property 
        public int Population { get; set; }
        public readonly double AREA = 1234.56;//this is a constant variable 
        public static readonly bool isonEARTH;
        //instance constructor 
         // Deafult constructor -parameter less constructor
        public Country()
        {

        }



        // parameterized constructor 
        public Country(string name)
        {
           Name = name;
        }

        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }
        static Country()
        {
          isonEARTH = true;
        }
    }

    public class demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");

        }

    }
}