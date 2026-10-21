namespace egzamin
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.counter);
            Osoba os1 = new Osoba();
            Console.WriteLine("Podaj id: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj nazwe: ");
            string name = Console.ReadLine();
            Osoba os2 = new Osoba(id, name);
            Osoba os3 = new Osoba(os2);
            os1.greet("Jan");
            os2.greet("Jan");
            os3.greet("Jan");
            Console.WriteLine("Liczba zarejestrowanych osób to " + Osoba.counter);
        }
    }

    public class Osoba
    {
        private int id;
        private string name;
        public static int counter = 0;

        public Osoba()
        {
            this.id = 0;
            this.name = "";
            counter++;
        }

        public Osoba(int id, string name)
        {
            this.id = id;
            this.name = name;
            counter++;
        }

        public Osoba(Osoba os2)
        {
            this.id = os2.id;
            this.name = os2.name;
            counter++;
        }

        public void greet(string nameg)
        {
            if (string.IsNullOrEmpty(this.name))
            {
                Console.WriteLine("Brak danych");
            }
            else
            {
                Console.WriteLine($"Cześć {nameg}, mam na imię {this.name}");
            }
        }
    }
}
