namespace GermanNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var temp = rand.Next(1000);
            updateNumberAndStringNumber(temp);
            //lblString.Text = constssss.translateNumbertoGreman(115);
        }

        private void bnTranslate_Click(object sender, EventArgs e)
        {
            var number = 0;

            if (int.TryParse(tbNumber.Text, out number))
            {
                updateNumberAndStringNumber(number);
            }
        }


        private void updateNumberAndStringNumber(int number)
        {
            lblNumber.Text = number.ToString();
            var constssss = new Consts();
            lblString.Text = constssss.translateNumbertoGreman(number);
        }

    }
}