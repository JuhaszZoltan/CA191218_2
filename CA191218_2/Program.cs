using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA191218_2
{
    struct Diak
    {
        public string vNev;
        public string kNev;
        public int magas;
        public float suly;
        public bool nem;
    }

    class Program
    {
        static Diak[] diakok = new Diak[100];
        static void Main()
        {
            Beolvas();
            LegkoverebbLany();
            Console.ReadKey();
        }

        private static void LegkoverebbLany()
        {
            int maxi = 0;
            for (int i = 0; i < diakok.Length; i++)
            {
                if (!diakok[i].nem)
                {
                    if (diakok[i].suly > diakok[maxi].suly) maxi = i;
                }
            }
            Console.WriteLine($"Legkövérebb lány: {diakok[maxi].vNev} {diakok[maxi].kNev}");
        }

        private static void Beolvas()
        {
            var sr = new StreamReader(@"..\..\diakok.txt", Encoding.UTF8);
            for (int i = 0; i < diakok.Length; i++)
            {
                var sor = sr.ReadLine().Split(' ');
                diakok[i] = new Diak()
                {
                    vNev = sor[0],
                    kNev = sor[1],
                    magas = int.Parse(sor[2]),
                    suly = float.Parse(sor[3]),
                    nem = sor[4] == "fiú",
                };
            }
            sr.Close();
        }
    }
}
