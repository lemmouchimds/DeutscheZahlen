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
                {0,"null"},
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
                {60, "sechzig" },
                {70, "siebzig" },
                {80, "achtzig"},
                {90, "neunzig" }
            };

            //numbers.Add()
        }

        public string translateNumbertoGreman(int number)
        {

            if (number < 100)
            {
                return lessThan100(number);    
            }

            return hundert(number);


            //int temp = 0;

            //while(number > 0)
            //{
            //    temp = number % base10;
            //    number /= base10;

            //    result.Append(numbers.GetValueOrDefault(temp));
            //    result.Append(oneSpace);
            //}

        }


        private string hundertStr = "hundert";
        private string und = "und";

        private string hundert(int number)
        {
            var result = new StringBuilder();

            var hundredsDigit = number / 100;

            var toInsert = (hundredsDigit == 1) ? "ein" : numbers[hundredsDigit];
            result.Append(toInsert + hundertStr);
            result.Append(lessThan100(number));

            return result.ToString();
        }


        private string lessThan100(int number)
        {
            var result = new StringBuilder();
            var tempNum = (number % 100);


            if (tempNum > 20)
            {
                var OnesDigit = number % 10;
                if (OnesDigit != 0)
                {
                    result.Append(numbers[OnesDigit]);
                    result.Append(und);

                }
            
                var TensDigit = (tempNum / 10) * 10;

                result.Append(numbers[TensDigit]);               
            }
            else
            {
                result.Append(numbers[tempNum]);
            }


            return result.ToString();
        }
    }
}
