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
    public partial class Binary_to_others : Form
    {
        string binary;
        
        menu m = new menu();
        public Binary_to_others()
        {
            InitializeComponent();
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            binary = txtnum.Text;
            double res = 0;
            if (binary.Contains('.'))
            {
                string whole, point;
                int j = 0, h = 1;
                whole = binary.Substring(0, binary.IndexOf('.'));
                point = binary.Substring(binary.IndexOf('.') + 1);
                for (int i = whole.Length - 1; i >= 0; i--)
                {
                    int k = Int32.Parse(whole.Substring(i, 1));
                    res += k * (int)(Math.Pow(2, j));
                    j++;
                }
                for (int i = point.Length - 1; i >= 0; i--)
                {
                    double k = Int32.Parse(point.Substring(i, 1));
                    res += k * Math.Pow(2, -h);
                    h++;
                }
            }
            else
            {
                int j = 0;
                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    int k = Int32.Parse(binary.Substring(i, 1));
                    res += k * (int)(Math.Pow(2, j));
                    j++;
                }
            }
            string result = "" + res.ToString();
            lblresult.Text = "In Decimal = " + result;
            txtnum.SelectAll();
            txtnum.Focus();
        }

        private void btnHex_Click(object sender, EventArgs e)
        {
            string result = "", whole, point;
            binary = txtnum.Text;
            if (binary.Contains('.'))
            {
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
                        case 0000: result += "0"; break;
                        case 0001: result += "1"; break;
                        case 0010: result += "2"; break;
                        case 0011: result += "3"; break;
                        case 0100: result += "4"; break;
                        case 0101: result += "5"; break;
                        case 0110: result += "6"; break;
                        case 0111: result += "7"; break;
                        case 1000: result += "8"; break;
                        case 1001: result += "9"; break;
                        case 1010: result += "A"; break;
                        case 1011: result += "B"; break;
                        case 1100: result += "C"; break;
                        case 1101: result += "D"; break;
                        case 1110: result += "E"; break;
                        case 1111: result += "F"; break;
                    }
                }

                result += ".";

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
                        case 0000: result += "0"; break;
                        case 0001: result += "1"; break;
                        case 0010: result += "2"; break;
                        case 0011: result += "3"; break;
                        case 0100: result += "4"; break;
                        case 0101: result += "5"; break;
                        case 0110: result += "6"; break;
                        case 0111: result += "7"; break;
                        case 1000: result += "8"; break;
                        case 1001: result += "9"; break;
                        case 1010: result += "A"; break;
                        case 1011: result += "B"; break;
                        case 1100: result += "C"; break;
                        case 1101: result += "D"; break;
                        case 1110: result += "E"; break;
                        case 1111: result += "F"; break;
                    }
                }
            }
            else
            {
                if (binary.Length % 4 != 0)
                {
                    switch (binary.Length % 4)
                    {
                        case 1: binary = "000" + binary; break;
                        case 2: binary= "00" +binary; break;
                        case 3: binary= "0" + binary; break;
                    }
                }
                for (int i = 0; i < binary.Length; i += 4)
                {
                    int k = Int32.Parse(binary.Substring(i, 4));
                    switch (k)
                    {
                        case 0000: result += "0"; break;
                        case 0001: result += "1"; break;
                        case 0010: result += "2"; break;
                        case 0011: result += "3"; break;
                        case 0100: result += "4"; break;
                        case 0101: result += "5"; break;
                        case 0110: result += "6"; break;
                        case 0111: result += "7"; break;
                        case 1000: result += "8"; break;
                        case 1001: result += "9"; break;
                        case 1010: result += "A"; break;
                        case 1011: result += "B"; break;
                        case 1100: result += "C"; break;
                        case 1101: result += "D"; break;
                        case 1110: result += "E"; break;
                        case 1111: result += "F"; break;
                    }
                }
            }
            lblresult.Text = "In HexaDecimal = " + result;
            txtnum.SelectAll();
            txtnum.Focus();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string result = "";
            binary = txtnum.Text;
            if (binary.Contains('.'))
            {
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
                        case 000: result += "0"; break;
                        case 001: result += "1"; break;
                        case 010: result += "2"; break;
                        case 011: result += "3"; break;
                        case 100: result += "4"; break;
                        case 101: result += "5"; break;
                        case 110: result += "6"; break;
                        case 111: result += "7"; break;
                    }
                }


                result += ".";

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
                        case 000: result += "0"; break;
                        case 001: result += "1"; break;
                        case 010: result += "2"; break;
                        case 011: result += "3"; break;
                        case 100: result += "4"; break;
                        case 101: result += "5"; break;
                        case 110: result += "6"; break;
                        case 111: result += "7"; break;
                    }
                }
            }
            else
            {
                if (binary.Length % 3 != 0)
                {
                    switch (binary.Length % 3)
                    {
                        case 1: binary = "00" + binary; break;
                        case 2: binary = "0" + binary; break;
                    }
                }
                for (int i = 0; i < binary.Length; i += 3)
                {
                    int k = Int32.Parse(binary.Substring(i, 3));
                    switch (k)
                    {
                        case 000: result += "0"; break;
                        case 001: result += "1"; break;
                        case 010: result += "2"; break;
                        case 011: result += "3"; break;
                        case 100: result += "4"; break;
                        case 101: result += "5"; break;
                        case 110: result += "6"; break;
                        case 111: result += "7"; break;
                    }
                }
            }
            lblresult.Text = "In Octal = " + result;
            txtnum.SelectAll();
            txtnum.Focus();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            Binary_to_others.ActiveForm.Hide();
            m.Show();
        }
    }
}
