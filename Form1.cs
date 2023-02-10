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
            var consttt = new Consts();
            var temp = consttt.Generate(min, max);
            updateNumberAndStringNumber(temp);
        }

        private void bnTranslate_Click(object sender, EventArgs e)
        {
            var number = 0;

            if (int.TryParse(tbNumber.Text, out number))
            {
                var translated = new Consts();
                updateNumberAndStringNumber(translated.Translate(number));
            }

            tbNumber.Clear();
            bnGenerate.Enabled = true;
        }

        private void updateNumberAndStringNumber(NumberText number)
        {
            lblNumber.Text = number.number.ToString();
            lblString.Text = number.text;
        }

        private void tbNumber_TextChanged(object sender, EventArgs e)
        {
            bnGenerate.Enabled = false;
        }

        private void challengeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Challenge();
            form.Show();
        }
    }
}