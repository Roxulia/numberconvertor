using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Number_System_Convertor
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Hide();
            Binary_to_others b = new Binary_to_others();
            b.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Hide();
            Decimal_to_others d = new Decimal_to_others();
            d.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Hide();
            HexaDecimal_to_Others h = new HexaDecimal_to_Others();
            h.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menu.ActiveForm.Hide();
            Octal_to_others o = new Octal_to_others();
            o.Show();
        }
        public string removeZero(string word)
        {
            
            while (word.ElementAt(0) == '0')
            {
                word=word.Remove(0, 1);
                
            }
            return word;
        }
    }
}
