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
    public partial class Octal_to_others : Form
    {
        string octal = "";
        menu m = new menu();
        public Octal_to_others()
        {
            InitializeComponent();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            string binary = "";
            octal = textBox1.Text;
            if (octal.Contains('.'))
            {
                for (int i = 0; i < octal.IndexOf('.'); i++)
                {
                    switch (octal.Substring(i, 1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
                binary += ".";
                for (int i = 0; i < octal.Substring(octal.IndexOf('.') + 1).Length; i++)
                {
                    switch (octal.Substring(octal.IndexOf('.')+1).Substring(i,1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
            }
            else
            {
                for (int i = 0; i < octal.Length; i++)
                {
                    switch (octal.Substring(i, 1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
            }
            binary = m.removeZero(binary);
            lblresult.Text = "In Binary = " + binary;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            string binary = "", hexa = "";
            octal = textBox1.Text;
            if (octal.Contains('.'))
            {
                for (int i = 0; i < octal.IndexOf('.'); i++)
                {
                    switch (octal.Substring(i, 1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
                binary += ".";
                for (int i = 0; i < octal.Substring(octal.IndexOf('.') + 1).Length; i++)
                {
                    switch (octal.Substring(octal.IndexOf('.') + 1).Substring(i, 1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
                string whole, point;
                whole = binary.Substring(0, binary.IndexOf('.'));
                point = binary.Substring(binary.IndexOf('.') + 1);
                if (whole.Length % 4 != 0)
                {
                    switch (whole.Length % 4)
                    {
                        case 1: whole = "000" + whole; break;
                        case 2: whole = "00" + whole; break;
                        case 3: whole = "0" + whole; break;
                    }
                }
                for (int i = 0; i < whole.Length; i += 4)
                {
                    int k = Int32.Parse(whole.Substring(i, 4));
                    switch (k)
                    {
                        case 0000: hexa += "0"; break;
                        case 0001: hexa += "1"; break;
                        case 0010: hexa += "2"; break;
                        case 0011:  hexa+= "3"; break;
                        case 0100:  hexa+= "4"; break;
                        case 0101:  hexa+= "5"; break;
                        case 0110:  hexa+= "6"; break;
                        case 0111:  hexa+= "7"; break;
                        case 1000:  hexa+= "8"; break;
                        case 1001:  hexa+= "9"; break;
                        case 1010:  hexa+= "A"; break;
                        case 1011: hexa+= "B"; break;
                        case 1100:  hexa+= "C"; break;
                        case 1101:  hexa+= "D"; break;
                        case 1110:  hexa+= "E"; break;
                        case 1111: hexa += "F"; break;
                    }
                }

                hexa += ".";

                if (point.Length % 4 != 0)
                {
                    switch (point.Length % 4)
                    {
                        case 1: point += "000"; break;
                        case 2: point += "00"; break;
                        case 3: point += "0"; break;
                    }
                }
                for (int i = 0; i < point.Length; i += 4)
                {
                    int k = Int32.Parse(point.Substring(i, 4));
                    switch (k)
                    {
                        case 0000: hexa += "0"; break;
                        case 0001: hexa+= "1"; break;
                        case 0010:  hexa+= "2"; break;
                        case 0011:  hexa+= "3"; break;
                        case 0100:  hexa+= "4"; break;
                        case 0101: hexa+= "5"; break;
                        case 0110:  hexa+= "6"; break;
                        case 0111:  hexa+= "7"; break;
                        case 1000: hexa+= "8"; break;
                        case 1001: hexa+= "9"; break;
                        case 1010: hexa+= "A"; break;
                        case 1011: hexa+= "B"; break;
                        case 1100: hexa+= "C"; break;
                        case 1101: hexa+= "D"; break;
                        case 1110:hexa += "E"; break;
                        case 1111:hexa += "F"; break;
                    }
                }

            }
            else
            {
                for (int i = 0; i < octal.Length; i++)
                {
                    switch (octal.Substring(i, 1))
                    {
                        case "0": binary += "000"; break;
                        case "1": binary += "001"; break;
                        case "2": binary += "010"; break;
                        case "3": binary += "011"; break;
                        case "4": binary += "100"; break;
                        case "5": binary += "101"; break;
                        case "6": binary += "110"; break;
                        case "7": binary += "111"; break;

                    }
                }
                if (binary.Length % 4 != 0)
                {
                    switch (binary.Length % 4)
                    {
                        case 1: binary = "000" + binary; break;
                        case 2: binary = "00" + binary; break;
                        case 3: binary = "0" + binary; break;
                    }
                }
                for (int i = 0; i < binary.Length; i += 4)
                {
                    switch (binary.Substring(i, 4))
                    {
                        case "0000": hexa += "0"; break;
                        case "0001": hexa += "1"; break;
                        case "0010": hexa += "2"; break;
                        case "0011": hexa += "3"; break;
                        case "0100": hexa += "4"; break;
                        case "0101": hexa += "5"; break;
                        case "0110": hexa += "6"; break;
                        case "0111": hexa += "7"; break;
                        case "1000": hexa += "8"; break;
                        case "1001": hexa += "9"; break;
                        case "1010": hexa += "A"; break;
                        case "1011": hexa += "B"; break;
                        case "1100": hexa += "C"; break;
                        case "1101": hexa += "D"; break;
                        case "1110": hexa += "E"; break;
                        case "1111": hexa += "F"; break;
                    }
                }
            }
            hexa=m.removeZero(hexa);
            lblresult.Text = "In HexaDecimal = " + hexa;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            double res = 0;
            octal = textBox1.Text;
            if (octal.Contains('.'))
            {
                int j = 0, h = -1;
                for (int i = octal.IndexOf('.')-1; i >= 0; i--)
                {
                    int k = Convert.ToInt32(octal.Substring(i, 1));
                    res += k * (Math.Pow(8, j));
                    j++;
                }
                for (int i = 0; i < octal.Substring(octal.IndexOf('.') + 1).Length; i++)
                {
                    int k = Convert.ToInt32(octal.Substring(octal.IndexOf('.')+1).Substring(i,1));
                    res += k * (Math.Pow(8, h));
                    h--;
                }
            }
            else
            {
                int j = 0;
                for (int i = octal.Length - 1; i >= 0; i--)
                {
                    int k = Convert.ToInt32(octal.Substring(i, 1));
                    res += k * (int)(Math.Pow(8, j));
                    j++;
                }
            }
            lblresult.Text = "In Decimal = " + res.ToString();
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Octal_to_others.ActiveForm.Hide();
            m.Show();
        }
    }
}
