namespace Diamant_podruhé
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadej počet řádků (celé kladné číslo), které vytvoří polovinu a střed diamantu: "); // vzniklo modifikací Stromu (pyramidy)
            string input = Console.ReadLine();
            bool overeniInt = int.TryParse(input, out int pocetRadku);

            while (!overeniInt)
            {
                Console.WriteLine("Nezadal(a) jsi celé kladné číslo! Zkus to znovu: ");
                input = Console.ReadLine();
                overeniInt = int.TryParse(input, out pocetRadku);
            }

            Console.WriteLine("Zadej znak, který chceš zobrazit: ");
            string znak = Console.ReadLine();
            Console.WriteLine();

            int cisloRadku;
            int pocetZnaku;
            int pocetMezer;
            int cisloZnaku;
            int celkemZnakuMezer = pocetRadku * 2 - 1;

            for (cisloRadku = 1; cisloRadku <= pocetRadku; cisloRadku++)
            {
                //pocetZnaku = celkemZnakuMezer - (2 * cisloRadku);
                pocetZnaku = cisloRadku * 2 - 1;

                for (pocetMezer = 0; pocetMezer <= (celkemZnakuMezer - pocetZnaku) / 2; pocetMezer++)
                {
                    Console.Write(" ");
                }

                for (cisloZnaku = 1; cisloZnaku <= pocetZnaku; cisloZnaku++)
                //for (cisloZnaku = pocetZnaku; cisloZnaku >= 1; cisloZnaku--)
                {
                    Console.Write(znak);
                }

                for (pocetMezer = 0; pocetMezer <= (celkemZnakuMezer - pocetZnaku) / 2; pocetMezer++) // tento cyklus není nutný, pouze kdybychom chtěli diamant obklopit jiným symbolem než mezerou
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }

            for (cisloRadku = 1; cisloRadku < pocetRadku; cisloRadku++)
            {
                pocetZnaku = celkemZnakuMezer - (2 * cisloRadku);
                //pocetZnaku = cisloRadku * 2 - 1;

                for (pocetMezer = 0; pocetMezer <= (celkemZnakuMezer - pocetZnaku) / 2; pocetMezer++)
                {
                    Console.Write(" ");
                }

                //for (cisloZnaku = 1; cisloZnaku <= pocetZnaku; cisloZnaku++)
                for (cisloZnaku = pocetZnaku; cisloZnaku >= 1; cisloZnaku--)
                {
                    Console.Write(znak);
                }

                for (pocetMezer = 0; pocetMezer <= (celkemZnakuMezer - pocetZnaku) / 2; pocetMezer++) // tento cyklus není nutný, pouze kdybychom chtěli diamant obklopit jiným symbolem než mezerou
                {
                    Console.Write(" ");
                }

                Console.WriteLine();
            }
        }
    }
}