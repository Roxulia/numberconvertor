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
    public partial class HexaDecimal_to_Others : Form
    {
        string hexa;
        menu m = new menu();
        public HexaDecimal_to_Others()
        {
            InitializeComponent();
        }

        private void btnbinary_Click(object sender, EventArgs e)
        {
            string binary = "";
            hexa = textBox1.Text;
            if (hexa.Contains('.'))
            {
                for (int i = 0; i < hexa.IndexOf('.'); i++)
                {
                    string digit = hexa.Substring(i, 1);
                    switch (digit)
                    {
                        case "0": binary += "0000"; break;
                        case "1": binary += "0001"; break;
                        case "2": binary += "0010"; break;
                        case "3": binary += "0011"; break;
                        case "4": binary += "0100"; break;
                        case "5": binary += "0101"; break;
                        case "6": binary += "0110"; break;
                        case "7": binary += "0111"; break;
                        case "8": binary += "1000"; break;
                        case "9": binary += "1001"; break;
                        case "A": binary += "1010"; break;
                        case "B": binary += "1011"; break;
                        case "C": binary += "1100"; break;
                        case "D": binary += "1101"; break;
                        case "E": binary += "1110"; break;
                        case "F": binary += "1111"; break;
                    }
                }
                binary += ".";
                for (int i = 0; i < hexa.Substring(hexa.IndexOf('.')+1).Length; i++)
                {
                    string digit = hexa.Substring(hexa.IndexOf('.')+1).Substring(i,1);
                    switch (digit)
                    {
                        case "0": binary += "0000"; break;
                        case "1": binary += "0001"; break;
                        case "2": binary += "0010"; break;
                        case "3": binary += "0011"; break;
                        case "4": binary += "0100"; break;
                        case "5": binary += "0101"; break;
                        case "6": binary += "0110"; break;
                        case "7": binary += "0111"; break;
                        case "8": binary += "1000"; break;
                        case "9": binary += "1001"; break;
                        case "A": binary += "1010"; break;
                        case "B": binary += "1011"; break;
                        case "C": binary += "1100"; break;
                        case "D": binary += "1101"; break;
                        case "E": binary += "1110"; break;
                        case "F": binary += "1111"; break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < hexa.Length; i++)
                {
                    string digit = hexa.Substring(i, 1);
                    switch (digit)
                    {
                        case "0": binary += "0000"; break;
                        case "1": binary += "0001"; break;
                        case "2": binary += "0010"; break;
                        case "3": binary += "0011"; break;
                        case "4": binary += "0100"; break;
                        case "5": binary += "0101"; break;
                        case "6": binary += "0110"; break;
                        case "7": binary += "0111"; break;
                        case "8": binary += "1000"; break;
                        case "9": binary += "1001"; break;
                        case "A": binary += "1010"; break;
                        case "B": binary += "1011"; break;
                        case "C": binary += "1100"; break;
                        case "D": binary += "1101"; break;
                        case "E": binary += "1110"; break;
                        case "F": binary += "1111"; break;
                    }
                }
            }
            binary = m.removeZero(binary);
            lblresult.Text = "In Binary = " + binary;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            double Decimal = 0;
            hexa=textBox1.Text;
            if (hexa.Contains('.'))
            {
                int j = 0, h = -1;
                for (int i = hexa.IndexOf('.')-1; i >= 0; i--)
                {
                    switch (hexa.Substring(i, 1))
                    {
                        case "A": Decimal += 10 * (Math.Pow(16, j)); break;
                        case "B": Decimal += 11 * (Math.Pow(16, j)); break;
                        case "C": Decimal += 12 * (Math.Pow(16, j)); break;
                        case "D": Decimal += 13 * (Math.Pow(16, j)); break;
                        case "E": Decimal += 14 * (Math.Pow(16, j)); break;
                        case "F": Decimal += 15 * (Math.Pow(16, j)); break;
                        default: Decimal += Convert.ToDouble(hexa.Substring(i, 1)) * (Math.Pow(16, j)); break;
                    }
                    j++;
                }
                for (int i = 0; i <hexa.Substring(hexa.IndexOf('.')+1).Length; i++)
                {

                    switch (hexa.Substring(hexa.IndexOf('.')+1).Substring(i,1))
                    {
                        case "A": Decimal += 10 * (Math.Pow(16, h)); break;
                        case "B": Decimal += 11 * (Math.Pow(16, h)); break;
                        case "C": Decimal += 12 * (Math.Pow(16,h)); break;
                        case "D": Decimal += 13 * (Math.Pow(16, h)); break;
                        case "E": Decimal += 14 * (Math.Pow(16, h)); break;
                        case "F": Decimal += 15 * (Math.Pow(16, h)); break;
                        default: Decimal += Convert.ToDouble(hexa.Substring(hexa.IndexOf('.') + 1).Substring(i, 1)) * (Math.Pow(16, h)); break;
                    }
                    h--;

                }
            }
            else
            {
                int j = 0;
                for (int i = hexa.Length - 1; i >= 0; i--)
                {
                    switch (hexa.Substring(i, 1))
                    {
                        case "A": Decimal += 10 * (int)(Math.Pow(16, j)); break;
                        case "B": Decimal += 11 * (int)(Math.Pow(16, j)); break;
                        case "C": Decimal += 12 * (int)(Math.Pow(16, j)); break;
                        case "D": Decimal += 13 * (int)(Math.Pow(16, j)); break;
                        case "E": Decimal += 14 * (int)(Math.Pow(16, j)); break;
                        case "F": Decimal += 15 * (int)(Math.Pow(16, j)); break;
                        default: Decimal += Convert.ToInt32(hexa.Substring(i, 1)) * (int)(Math.Pow(16, j)); break;
                    }
                    j++;
                }
            }
            lblresult.Text = "In Decimal = " + Decimal.ToString();
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string octal = "", binary = "";
            hexa = textBox1.Text;
            if (hexa.Contains('.'))
            {
                for (int i = 0; i < hexa.IndexOf('.'); i++)
                {
                    string digit = hexa.Substring(i, 1);
                    switch (digit)
                    {
                        case "0": binary += "0000"; break;
                        case "1": binary += "0001"; break;
                        case "2": binary += "0010"; break;
                        case "3": binary += "0011"; break;
                        case "4": binary += "0100"; break;
                        case "5": binary += "0101"; break;
                        case "6": binary += "0110"; break;
                        case "7": binary += "0111"; break;
                        case "8": binary += "1000"; break;
                        case "9": binary += "1001"; break;
                        case "A": binary += "1010"; break;
                        case "B": binary += "1011"; break;
                        case "C": binary += "1100"; break;
                        case "D": binary += "1101"; break;
                        case "E": binary += "1110"; break;
                        case "F": binary += "1111"; break;
                    }
                }
                binary += ".";
                for (int i = 0; i < hexa.Substring(hexa.IndexOf('.') + 1).Length; i++)
                {
                    string digit = hexa.Substring(hexa.IndexOf('.')+1).Substring(i,1);
                    switch (digit)
                    {
                        case "0": binary += "0000"; break;
                        case "1": binary += "0001"; break;
                        case "2": binary += "0010"; break;
                        case "3": binary += "0011"; break;
                        case "4": binary += "0100"; break;
                        case "5": binary += "0101"; break;
                        case "6": binary += "0110"; break;
                        case "7": binary += "0111"; break;
                        case "8": binary += "1000"; break;
                        case "9": binary += "1001"; break;
                        case "A": binary += "1010"; break;
                        case "B": binary += "1011"; break;
                        case "C": binary += "1100"; break;
                        case "D": binary += "1101"; break;
                        case "E": binary += "1110"; break;
                        case "F": binary += "1111"; break;
                    }
                }
                string whole, point;
                whole = binary.Substring(0, binary.IndexOf('.'));
                point = binary.Substring(binary.IndexOf('.') + 1);
                if (whole.Length % 3 != 0)
                {
                    switch (whole.Length % 3)
                    {
                        case 1: whole = "00" + whole; break;
                        case 2: whole = "0" + whole; break;
                    }
                }
                for (int i = 0; i < whole.Length; i += 3)
                {
                    int k = Int32.Parse(whole.Substring(i, 3));
                    switch (k)
                    {
                        case 000: octal += "0"; break;
                        case 001: octal += "1"; break;
                        case 010: octal+= "2"; break;
                        case 011: octal += "3"; break;
                        case 100: octal += "4"; break;
                        case 101: octal += "5"; break;
                        case 110:  octal+= "6"; break;
                        case 111: octal += "7"; break;
                    }
                }


                octal += ".";

                if (point.Length % 3 != 0)
                {
                    switch (point.Length % 3)
                    {
                        case 1: point += "00"; break;
                        case 2: point += "0"; break;
                    }
                }
                for (int i = 0; i < point.Length; i += 3)
                {
                    int k = Int32.Parse(point.Substring(i, 3));
                    switch (k)
                    {
                        case 000: octal += "0"; break;
                        case 001: octal += "1"; break;
                        case 010: octal += "2"; break;
                        case 011: octal += "3"; break;
                        case 100: octal += "4"; break;
                        case 101: octal += "5"; break;
                        case 110: octal += "6"; break;
                        case 111: octal += "7"; break;
                    }
                }
            }
            else
            {
            for (int i = 0; i <hexa.Length; i++)
            {
                string digit = hexa.Substring(i, 1);
                switch (digit)
                {
                    case "0": binary += "0000"; break;
                    case "1": binary += "0001"; break;
                    case "2": binary += "0010"; break;
                    case "3": binary += "0011"; break;
                    case "4": binary += "0100"; break;
                    case "5": binary += "0101"; break;
                    case "6": binary += "0110"; break;
                    case "7": binary += "0111"; break;
                    case "8": binary += "1000"; break;
                    case "9": binary += "1001"; break;
                    case "A": binary += "1010"; break;
                    case "B": binary += "1011"; break;
                    case "C": binary += "1100"; break;
                    case "D": binary += "1101"; break;
                    case "E": binary += "1110"; break;
                    case "F": binary += "1111"; break;
                }
            }
            if (binary.Length % 3 != 0)
            {
                switch (binary.Length % 3)
                {
                    case 1: binary = "00" + binary; break;
                    case 2: binary = "0" + binary; break;
                }
            }
            for (int i = 0; i < binary.Length; i+=3)
            {
                int k=Convert.ToInt32(binary.Substring(i,3));
                switch(k)
                {
                    case 000: octal += "0"; break;
                    case 001: octal += "1"; break;
                    case 010: octal += "2"; break;
                    case 011: octal += "3"; break;
                    case 100: octal += "4"; break;
                    case 101: octal += "5"; break;
                    case 110: octal += "6"; break;
                    case 111: octal += "7"; break;
                }
            }}
            octal = m.removeZero(octal);
            lblresult.Text="In Octal = "+octal;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            HexaDecimal_to_Others.ActiveForm.Hide();
            m.Show();
        }
    }
}
