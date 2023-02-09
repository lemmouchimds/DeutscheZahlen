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
            var temp = rand.Next(70);
            lblNumber.Text = temp.ToString();
            var constssss = new Consts();
            lblString.Text = constssss.translateNumbertoGreman(temp);
        }
    }
}