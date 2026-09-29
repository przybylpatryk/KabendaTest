namespace kabenda
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst do zaszyfrowania:");
            string text = Console.ReadLine();
            Console.WriteLine("Podaj klucz:");
            int key = int.Parse(Console.ReadLine());

            string encryptedText = Encrypt(text, key);
            Console.WriteLine("Zaszyfrowany tekst: " + encryptedText);
        }

        public static string Encrypt(string text, int key)
        {
            string letters = "abcdefghijklmnopqrstuvwxyz";
            string encryptedText = "";

            for (int i = 0; i < text.Length; i++)
            {

                if (!letters.Contains(text[i]))
                {
                    encryptedText += text[i];
                    continue;
                }

                int index = (letters.IndexOf(text[i]) + key) % letters.Length;

                if (index < 0)
                {
                    encryptedText += letters[index + letters.Length];

                }
                else
                {
                    encryptedText += letters[index];
                } 
            }
            return encryptedText;
        }
    }
}