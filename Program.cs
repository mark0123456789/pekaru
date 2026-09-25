namespace pekaru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pekaruk> pekaruk = new List<Pekaruk>();

            
            pekaruk.Add(new Pekaruk("Barackos Túrós párna", true, 299, true));
            pekaruk.Add(new Pekaruk("Kakaós csiga", true, 349, false));
            pekaruk.Add(new Pekaruk("Sajtos pogácsa", false, 249, true));

            pekaruk.Add(new Kenyerek("Házi Vekni", 459, false, 500));
            pekaruk.Add(new Kenyerek("Fehér kenyér", 399, true, 500));
            pekaruk.Add(new Kenyerek("Teljes kiőrlésű kenyér", 599, false, 750));

            
            Console.WriteLine("A pékáruk:");
            Console.WriteLine("------------------------------------------------------------------------------------------------------");

            foreach (Pekaruk p in pekaruk)
            {
                Console.WriteLine(p);
            }

            // 1. Mennyibe kerülnek, ha mindenből kettőt veszünk?
            double osszeg = pekaruk.Sum(p => p.Ar() * 2);

            Console.WriteLine();
            Console.WriteLine($"1. Két-két darab összesen: {osszeg} Ft");

            // 2. Csak a NEM kenyerek megjelenítése
            Console.WriteLine();
            Console.WriteLine("2. Nem kenyér pékáruk:");
            Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");

            foreach (Pekaruk p in pekaruk)
            {
                if (p is not Kenyerek)
                {
                    Console.WriteLine(p);
                }
            }

            // 3. Legolcsóbb kenyér
            Kenyerek legolcsobbKenyér = pekaruk
                .OfType<Kenyerek>()
                .OrderBy(p => p.Ar())
                .First();

            Console.WriteLine();
            Console.WriteLine("3. Legolcsóbb kenyér:");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine(legolcsobbKenyér);
        }
    }
}
