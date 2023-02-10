using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GermanNumbers
{
    public partial class Challenge : Form
    {



        public Challenge()
        {
            InitializeComponent();
        }


        private int min = 0;
        private int max = 10;
        private static NumberText numberText;

        private void bnOK_Click(object sender, EventArgs e)
        {
            var answer = false;
            var txt = tbText.Text.Trim(' ', ',', ';', '-','\t', '\n', '\r');

            var toCompare = new NumberText(numberText.number, txt);
            if (NumberText.equal(toCompare, numberText))
            {
                answer = true;
            }
            else
            {
                tbText.SelectAll();
            }

            writeCorrectOrWrong(answer);
            DialogResult = DialogResult.None;
        }


        private void writeCorrectOrWrong(bool correct)
        {
            if (correct)
            {
                lblAnswer.Text = "Correct";
            }
            else
            {
                lblAnswer.Text = "Wrong";
            }
        }

        private void bnGenerate_Click(object sender, EventArgs e)
        {
            var temp = new Consts();
            var num =  temp.Generate(min, max);
            tbNumber.Text = num.number.ToString();
            numberText = num;
        }
    }
}
