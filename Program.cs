namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 9; int b = 10;
            double c = 12.5, d = 18.93;
            float e = 2.56f, f = 1.0f, g = 2.78f;
            int resultInt = 0;
            double resultDouble = 0;
            float resultFloat = 0.0f;


            resultInt = AddNumber(a, b);
            resultDouble = AddNumber(c, d);
            resultFloat = AddNumber(e, f, g);
            Console.WriteLine("Wynik dodawania liczb calkowitych: " + resultInt);
            Console.WriteLine("Wynik dodawania liczb rzeczywistych: " + resultDouble);
            Console.WriteLine("Wynik dodawania float: " + resultFloat);
        }
        private static double AddNumber(double c, double d)
        {
            return c + d;
        }

        private static int AddNumber(int a, int b)
        {
            return a + b;
        }
        private static float AddNumber(float e, float f, float g)
        {
            return e + f + g;
        }
    }
}