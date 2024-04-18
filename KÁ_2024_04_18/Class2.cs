using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KÁ_2024_04_18
{
    class EredmenyekRepo
    {
        public static string path { get; set; }
        public static bool SkipHeader { get; set; } = true;
        public static char separator { get; set; } = ',';

        public static List<Eredmenyek> FindAll()
        {
            using (StreamReader reader = new StreamReader(path))
            {
                if (SkipHeader)
                    reader.ReadLine();


                List<Eredmenyek> People = new List<Eredmenyek>();

                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    Eredmenyek person = Eredmenyek.CreateFromLine(line, separator);
                    People.Add(person);

                }

                return People;
            }
        }

        public static List<Eredmenyek> FindAllBySearch(string vezeteknev, string keresztnev, string targy, string szazalek, string erdemjegy)
        {
            List<Eredmenyek> Eredmeny = new List<Eredmenyek>();

            foreach (Eredmenyek eredmeny in FindAll())
            {

                if (!eredmeny.VezetekNev.ToLower().Contains(vezeteknev.ToLower().Trim()))
                    continue;
                if (!eredmeny.KeresztNev.ToLower().Contains(keresztnev.ToLower().Trim()))
                    continue;
                if (!eredmeny.Targy.ToLower().Contains(targy.ToLower().Trim()))
                    continue;
                if (!eredmeny.Szazalek.ToString().Contains(szazalek.ToLower().Trim()))
                    continue;
                if (!eredmeny.Erdemjegy.ToString().ToLower().Contains(erdemjegy.ToLower().Trim()))
                    continue;

                    Eredmeny.Add(eredmeny);
            }

            return Eredmeny;
        }

    }
}
