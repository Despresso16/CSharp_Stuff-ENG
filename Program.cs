namespace ClassStuff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linie ZKG KM!");
            Autobus linia = new Autobus();
            while (true)
            {
                Console.Write("Podaj linie: ");
                linia.Linia = Console.ReadLine();
                linia.ktoraLinia();

            }
           
            
            

        }
        class Autobus
        {
            public string Linia;
            public string Punkt1;
            public string Punkt2;
            public string[,] przyjazd = { { "", "", "" }, {"", "", "" } };
            public void ktoraLinia() 
            {
                switch (this.Linia)
                {
                    case "472":
                        this.Punkt1 = "Chechlo petla";
                        this.Punkt2 = "Olkusz Dworzec PKP";
                        przyjazd[] = { {"7.13", "7.52", "9.50"}, {"7.35", "8.20", "10.25" } };
                        break;
                    case "476":
                        this.Punkt1 = "Rodaki petla";
                        this.Punkt2 = "Olkusz Dworzec PKP";
                        break;
                    case "477":
                        this.Punkt1 = "Rodaki petla";
                        this.Punkt2 = "Olkusz Dworzec PKP";
                        break;
                    case "470":
                        this.Punkt1 = "Cieslin dom ludowy";
                        this.Punkt2 = "Olkusz E. Orzeszkowej";
                        break;
                    default:
                        Console.WriteLine("Brak linii w danych sproboj ponownie:");
                        break;
                }
            }
            

        }
    }
}