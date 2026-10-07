using System.Diagnostics.Metrics;

namespace egzamin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ilość oczek:");
            int dots = int.Parse(Console.ReadLine());
            Kosc kosc1 = new Kosc(dots);
            Console.WriteLine("Licznik: " + Kosc.counter);
            Console.Write("Wylosowane liczny:" + kosc1.dots + " / ");
            kosc1.getDiceThrow();
            Console.WriteLine("Nazwa pliku: kosc" + kosc1.imgIdx + ".png");
            Kosc kosc2 = new Kosc();
            Console.WriteLine("Licznik: " + Kosc.counter);
            Console.Write("Wylosowane liczny:" + kosc2.dots + " / ");
            kosc2.getDiceThrow();
            Console.WriteLine("Nazwa pliku: kosc" + kosc2.imgIdx + ".png");
        }
    }

    public class Kosc
    {
        public static int counter = 0;
        public string[] images = { "kosc0.png", "kosc1.png", "kosc2.png", "kosc3.png", "kosc4.png", "kosc5.png", "kosc6.png" };
        public int dots;
        public int imgIdx;
        public bool isAvailable;

        public Kosc(int diceV)
        {
            if (!(diceV >= 0 && diceV <= 6))
            {
                diceV = 0;
            }
            this.dots = diceV;
            this.imgIdx = diceV;
            this.isAvailable = true;
            counter++;
        }

        public Kosc()
        {
            Random random = new Random();
            int randDot = random.Next(1, 7);
            this.dots = randDot;
            this.imgIdx = randDot;
            this.isAvailable = true;
            counter++;
        }

        public void diceThrow()
        {
            if (isAvailable)
            {
                Random random = new Random();
                int randDot = random.Next(1, 7);
                dots = randDot;
                imgIdx = randDot;
            }
        }

        public void blockDice()
        {
            isAvailable = false;
        }

        public void getDiceThrow()
        {
            switch (dots)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("jeden");
                    break;
                case 2:
                    Console.WriteLine("dwa");
                    break;
                case 3:
                    Console.WriteLine("trzy");
                    break;
                case 4:
                    Console.WriteLine("cztery");
                    break;
                case 5:
                    Console.WriteLine("pięć");
                    break;
                case 6:
                    Console.WriteLine("sześć");
                    break;
            }
        }
    }
}
