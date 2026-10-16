using Bankszamla_FR;

namespace Bankszamla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FolyoSzamla folyo = new FolyoSzamla("00120102-03451234-00000000", "Kiss Péter", 5000m);

            MegtakaritasiSzamla megtakaritas = new MegtakaritasiSzamla("00120102-03451234-11111111", "Nagy Anna", 20000m);

            Console.WriteLine("Folyószámla:");
            Console.WriteLine("Számlaszám: " + folyo.Szamlaszam);
            Console.WriteLine("Tulajdonos: " + folyo.Tulajdonos);
            Console.WriteLine("Egyenleg: " + folyo.Egyenleg + " Ft");
            Console.WriteLine("Hitelkeret: " + folyo.Hitelkeret + " Ft");

            Console.WriteLine();

            Console.WriteLine("Megtakarítási számla:");
            Console.WriteLine("Számlaszám: " + megtakaritas.Szamlaszam);
            Console.WriteLine("Tulajdonos: " + megtakaritas.Tulajdonos);
            Console.WriteLine("Egyenleg: " + megtakaritas.Egyenleg + " Ft");

            folyo.Befizetes(3000m);
            megtakaritas.Befizetes(5000m);

            Console.WriteLine();
            Console.WriteLine("Befizetés után:");
            Console.WriteLine("Folyószámla: " + folyo.Egyenleg + " Ft");
            Console.WriteLine("Megtakarítási számla: " + megtakaritas.Egyenleg + " Ft");

            folyo.Kifizetes(15000m);
            megtakaritas.Kifizetes(10000m);

            Console.WriteLine();
            Console.WriteLine("Kifizetés után:");
            Console.WriteLine("Folyószámla: " + folyo.Egyenleg + " Ft");
            Console.WriteLine("Megtakarítási számla: " + megtakaritas.Egyenleg + " Ft");
        }
    }
}