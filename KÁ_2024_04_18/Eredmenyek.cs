using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KA_2024_04_18
{
    class Eredmenyek
    {
        public int ID { get; set; }
        public string VezetekNev { get; set; }
        public string KeresztNev { get; set; }
        public string Targy { get; set; }
        public int Szazalek { get; set; }
        public int Eredmjegy {
            get 
            {
                if (Szazalek < 25)
                    return 1;
                if (Szazalek < 33)
                    return 2;
                if (Szazalek < 47)
                    return 3;
                if (Szazalek < 60)
                    return 4;
                return 5;
            } 
        }



        public override string ToString()
        {
            return $"Person<{VezetekNev} {KeresztNev} - {Targy}:{Erdemjegy}>";
        }

        public static Person CreateFromLine(string line, char separetor = ',')
        {
            string[] values = line.Split(separetor);

            return new Eredmenyek()
            {
                ID = int.Parse(values[0]),
                VezeekNev = values[1],
                KeresztNev = values[2],
                Targy = values[3],
                Szazalek = int.Parse(values[4]),
                Eredmjegy = int.Parse(values[5])
            };
        }
    }
}
