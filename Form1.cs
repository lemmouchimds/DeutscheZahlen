namespace GermanNumbers
{
    public partial class Form1 : Form
    {

        private int max = 1000;
        private int min = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            var temp = rand.Next(min, max);
            updateNumberAndStringNumber(temp);
            tbNumber.Clear();
            //lblString.Text = constssss.translateNumbertoGreman(115);
        }

        private void bnTranslate_Click(object sender, EventArgs e)
        {
            var number = 0;

            if (int.TryParse(tbNumber.Text, out number))
            {
                updateNumberAndStringNumber(number);
            }

            tbNumber.Clear();
            bnGenerate.Enabled = true;
        }


        private void updateNumberAndStringNumber(int number)
        {
            lblNumber.Text = number.ToString();
            var constssss = new Consts();
            lblString.Text = constssss.translateNumbertoGreman(number);
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            bnGenerate.Enabled = false;
        }
    }
}