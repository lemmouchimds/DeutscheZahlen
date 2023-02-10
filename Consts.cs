using System.Text;

namespace GermanNumbers
{

    public class Consts
    {

        public Consts()
        {
            initNumbers();
        }

        const int base10 = 10;
        //const char oneSpace = ' ';

        Dictionary<int, string>
            numbers = new Dictionary<int, string>();

        private void initNumbers()
        {
            numbers.Clear();

            numbers = new Dictionary<int, string>()
            {
                {0,"null"},
                {1,"eins"},
                {2,"zwei"},
                {3,"drei"},
                {4,"vier"},
                {5,"fünf"},
                {6,"sechs"},
                {7,"sieben"},
                {8,"acht"},
                {9,"neun"},
                {10,"zehn"},
                {11,"elf"},
                {12,"zwolf"},
                {13,"dreizehn"},
                {14,"vierzehn"},
                {15,"fünfzehn"},
                {16,"sechzehn"},
                {17,"siebzehn"},
                {18,"achtzehn"},
                {19,"neunzehn"},
                {20, "zwanzig" },
                {30, "drießig" },
                {40, "vierzig" },
                {50, "fünfzig"},
                {60, "sechzig" },
                {70, "siebzig" },
                {80, "achtzig"},
                {90, "neunzig" }
            };

            //numbers.Add()
        }

        private string threeDigits(int number)
        {
            if (number < 100)
            {
                return lessThan100(number);
            }

            return hundert(number);
        }


        private const string thausand = "thausand";
        public string translateNumbertoGreman(int number)
        {
            if (number == 0)
            {
                return numbers[number];
            }

            var result = new StringBuilder();

            if (number >= 1000)
            {
                result.Append(threeDigits(number / 1000));
                result.Append(thausand);
                number %= 1000;
            }
            

            if (number != 0)
            {
                if (number < 100)
                {
                    result.Append(lessThan100(number));    
                }
                else
                {
                    result.Append(hundert(number));
                }
            }


            return result.ToString();

        }


        private const string hundertStr = "hundert";
        private const string und = "und";

        private string hundert(int number)
        {
            var result = new StringBuilder();

            if (number >= 1000)
            {
                number %= 100;
            }

            var hundredsDigit = number / 100; //todo: remove number

            var toInsert = (hundredsDigit == 1) ? "ein" : numbers[hundredsDigit]; //todo: remove number and string
                result.Append(toInsert + hundertStr);

            number %= 100;
            if (number != 0)
            {
                result.Append(lessThan100(number));
            }

            return result.ToString();
        }


        private string lessThan100(int number)
        {
            var result = new StringBuilder();
            var tempNum = (number % 100); //todo: remove number


            if (tempNum > 20)//todo: remove number
            {
                var OnesDigit = number % base10;
                if (OnesDigit != 0)//todo: remove number
                {
                    result.Append(numbers[OnesDigit]);
                    result.Append(und);

                }
            
                var TensDigit = (tempNum / base10) * base10;

                result.Append(numbers[TensDigit]);               
            }
            else
            {
                result.Append(numbers[tempNum]);
            }


            return result.ToString();
        }
    
        public NumberText Generate(int min = 0, int max = 100)
        {
            var rand = new Random();
            var temp = rand.Next(min, max);

            return new NumberText(temp, translateNumbertoGreman(temp));
        }

        public NumberText Translate(int num)
        {
            return new NumberText(num, translateNumbertoGreman(num));
        }
    }


    public class NumberText
    {
        public int number { get; set; }
        public string text { get; set; }

        public NumberText()
        {

        }

        public NumberText(int number, string text)
        {
            this.number = number;
            this.text = text;
        }
        public static bool equal(NumberText a, NumberText b)
        {
            return a.number == b.number && string.Equals(a.text,b.text);
        }

        // override object.Equals
        //public override bool Equals(object obj)
        //{
        //    var temp = (NumberText)obj;
        //    return this.text.Equals(temp.text) && this.number == temp.number;

        //    //       
        //    // See the full list of guidelines at
        //    //   http://go.microsoft.com/fwlink/?LinkID=85237  
        //    // and also the guidance for operator== at
        //    //   http://go.microsoft.com/fwlink/?LinkId=85238
        //    //

        //    if (obj == null || GetType() != obj.GetType())
        //    {
        //        return false;
        //    }

        //    // TODO: write your implementation of Equals() here
            
        //    return base.Equals(obj);
        //}

        //// override object.GetHashCode
        //public override int GetHashCode()
        //{
        //    // TODO: write your implementation of GetHashCode() here
        //    //throw new NotImplementedException();
        //    return base.GetHashCode();
        //}
    }
}
