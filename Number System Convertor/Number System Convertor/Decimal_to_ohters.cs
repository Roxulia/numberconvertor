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
    public partial class Decimal_to_others : Form
    {
        int num;
        public Decimal_to_others()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Decimal_to_others.ActiveForm.Hide();
            menu m = new menu();
            m.Show();
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            string deci = textBox1.Text; string binary = ""; string res = "";
            
            if (deci.Contains('.'))
            {
                int whole = Convert.ToInt32(deci.Substring(0, deci.IndexOf('.')));
                double point = Convert.ToDouble("0" + deci.Substring(deci.IndexOf('.')));
                string pt = point.ToString();
                while (whole != 0)
                {
                    binary += (whole % 2).ToString();
                    whole /= 2;
                }
                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    res += binary.Substring(i, 1);
                }
                res += "."; int count = 0;
                while (pt.Contains('.'))
                {
                    point *= 2;
                    pt = point.ToString();
                    if (pt.Contains('.'))
                    {
                        res += pt.Substring(0, pt.IndexOf('.'));
                        point = Convert.ToDouble("0" + pt.Substring(pt.IndexOf('.')));
                    }
                    else
                    {
                        res += pt;
                        point = Convert.ToDouble(pt);
                    }
                    if (count > 9)
                    {
                        break;
                    } count++;
                    

                }

            }
            else
            {
                num = Convert.ToInt32(textBox1.Text);
                while (num != 0)
                {
                    binary += (num % 2).ToString();
                    num /= 2;
                }

                for (int i = binary.Length - 1; i >= 0; i--)
                {
                    res = res + binary.Substring(i, 1);
                }
            }
            lblresult.Text = "In Binary = " + res;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnHexa_Click(object sender, EventArgs e)
        {
            string hexa = "", res = "",deci=textBox1.Text;
            if (deci.Contains('.'))
            {
                int whole = Convert.ToInt32(deci.Substring(0, deci.IndexOf('.')));
                double point = Convert.ToDouble("0" + deci.Substring(deci.IndexOf('.')));
                string pt = point.ToString();
                while (whole != 0)
                {
                    switch (whole % 16)
                    {
                        case 10: hexa += "A"; break;
                        case 11: hexa += "B"; break;
                        case 12: hexa += "C"; break;
                        case 13: hexa += "D"; break;
                        case 14: hexa += "E"; break;
                        case 15: hexa += "F"; break;
                        default: hexa += (whole % 16).ToString(); break;

                    }
                    whole /= 16;
                }
                for (int i = hexa.Length - 1; i >= 0; i--)
                {
                    res += hexa.Substring(i, 1);
                }
                res += ".";
                int count = 0;
                while (pt.Contains('.'))
                {
                    point *= 16;
                    pt = point.ToString();
                    if (pt.Contains('.'))
                    {
                        switch (pt.Substring(0, pt.IndexOf('.')))
                        {
                            case "10": res += "A"; break;
                            case "11": res += "B"; break;
                            case "12": res += "C"; break;
                            case "13": res += "D"; break;
                            case "14": res += "E"; break;
                            case "15": res += "F"; break;
                            default: res += pt.Substring(0, pt.IndexOf('.')); break;
                        }
                        point = Convert.ToDouble("0" + pt.Substring(pt.IndexOf('.')));
                    }
                    else
                    {
                        switch (pt.Substring(0))
                        {
                            case "10": res += "A"; break;
                            case "11": res += "B"; break;
                            case "12": res += "C"; break;
                            case "13": res += "D"; break;
                            case "14": res += "E"; break;
                            case "15": res += "F"; break;
                            default: res += pt; break;
                        }
                        point = Convert.ToDouble(pt);
                    }
                    count++;
                    if (count > 9)
                    {
                        break;
                    }
                }

            }
            else
            {
                num = Convert.ToInt32(deci);

                while (num != 0)
                {
                    switch (num % 16)
                    {
                        case 10: hexa += "A"; break;
                        case 11: hexa += "B"; break;
                        case 12: hexa += "C"; break;
                        case 13: hexa += "D"; break;
                        case 14: hexa += "E"; break;
                        case 15: hexa += "F"; break;
                        default: hexa += (num % 16).ToString(); break;
                    }
                    num /= 16;
                }
                for (int i = hexa.Length - 1; i >= 0; i--)
                {
                    res += hexa.Substring(i, 1);
                }
            }
            lblresult.Text = "In HexaDecimal = " + res;
            textBox1.SelectAll();
            textBox1.Focus();
        }

        private void btnOctal_Click(object sender, EventArgs e)
        {
            string octal = "", res = "", deci = textBox1.Text;
            if (deci.Contains('.'))
            {
                int whole = Convert.ToInt32(deci.Substring(0, deci.IndexOf('.')));
                double point = Convert.ToDouble("0" + deci.Substring(deci.IndexOf('.')));
                string pt = point.ToString();
                while (whole != 0)
                {
                    octal += (whole % 8).ToString();
                    whole /= 8;
                }
                for (int i = octal.Length - 1; i >= 0; i--)
                {
                    res += octal.Substring(i, 1);
                }
                res += "."; int count = 0;
                while (pt.Contains('.'))
                {
                    point *= 8;
                    pt = point.ToString();
                    if (pt.Contains('.'))
                    {
                        res += pt.Substring(0, pt.IndexOf('.'));
                        point = Convert.ToDouble("0" + pt.Substring(pt.IndexOf('.')));
                    }
                    else
                    {
                        res += pt;
                        point = Convert.ToDouble(pt);
                    }
                    if (count > 9)
                    {
                        break;
                    }
                    count++;
                }
            }
            else
            {
                num = Convert.ToInt32(textBox1.Text);

                while (num != 0)
                {
                    octal += (num % 8).ToString();
                    num /= 8;
                }
                for (int i = octal.Length - 1; i >= 0; i--)
                {
                    res += octal.Substring(i, 1);
                }
            }
            lblresult.Text = "In Octal = " + res;
            textBox1.SelectAll();
            textBox1.Focus();
        }
    }
}
