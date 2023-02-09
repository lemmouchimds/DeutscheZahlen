using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GermanNumbers
{

    internal class Consts
    {

        public Consts()
        {
            initNumbers();
        }

        const int base10 = 10;
        const char oneSpace = ' ';

        Dictionary<int, string>
            numbers = new Dictionary<int, string>();

        public void initNumbers()
        {
            numbers.Clear();

            numbers = new Dictionary<int, string>()
            {
                {0,"nul"},
                {1,"eins"},
                {2,"zwei"},
                {3,"drei"},
                {4,"vier"},
                {5,"funf"},
                {6,"sechs"},
                {7,"sieben"},
                {8,"acht"},
                {9,"neun"},
                {10,"zehn"},
                {11,"elf"},
                {12,"zwolf"},
                {13,"dreizehn"},
                {14,"vierzehn"},
                {15,"funfzehn"},
                {16,"sechzehn"},
                {17,"siebzehn"},
                {18,"achtzehn"},
                {19,"neunzehn"},
                {20, "zwantig" },
                {30, "driessig" },
                {40, "vierzig" },
                {50, "funfzig"},
                {60, "sechszig" },
                {70, "siebzig" },
                {80, "achtzig"},
                {90, "neinzig" }
            };

            //numbers.Add()
        }

        public string translateNumbertoGreman(int number)
        {
            var result = new StringBuilder();
            int temp = 0;

            while(number > 0)
            {
                temp = number % base10;
                number /= base10;

                result.Append(numbers.GetValueOrDefault(temp));
                result.Append(oneSpace);
            }

            return result.ToString();
        }


    }
}
