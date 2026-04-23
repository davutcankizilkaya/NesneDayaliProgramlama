using kalitimDers;
using System.Data;
using System.Reflection.PortableExecutable;

namespace kalitimders
{
    internal class calistir
    {
        static void Main(string[] args)
        {
            ElektrikliYarisArabasi eYa = new ElektrikliYarisArabasi();
            Arac arac = new Arac();
        }
    }
    internal class Arac
    {
        public Arac() 
        {
            Console.WriteLine("Arac sinifinin constructor'i cagirildi"); 
        }
    }
}