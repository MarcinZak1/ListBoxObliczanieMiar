using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxObliczanieMiar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result = 0.0;

        private void lbOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //zmiana opcji
            //if (lbOptions.SelectedIndex > -1)
            //{
            //    MessageBox.Show(String.Format("Wybrany index opcji - {0}, treść: {1}",
            //        lbOptions.SelectedIndex, lbOptions.Items[lbOptions.SelectedIndex]));
            //}
            if (tbWejscie.Text != null)
            {
                try
                {
                    switch (lbOptions.SelectedIndex)
                    {
                        case 0:
                            tbWynik.Text = KgNaFunt(tbWejscie.Text);
                            break;
                        case 1:
                            tbWynik.Text = FuntNaKg(tbWejscie.Text);
                            break;
                        case 2:
                            tbWynik.Text = FnaC(tbWejscie.Text);
                            break;
                        case 3:
                            tbWynik.Text = CnaF(tbWejscie.Text);
                            break;
                        case 4:
                            tbWynik.Text = KmNaWezel(tbWejscie.Text);
                            break;
                        case 5:
                            tbWynik.Text = WezelNaKm(tbWejscie.Text);
                            break;
                        default:
                            break;
                    }
                }
                catch(FormatException)
                {
                    MessageBox.Show(string.Format("Wartość do zamiany jest pusta lub nie jest liczbą."));
                    lbOptions.SelectedIndex = -1;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbOptions.SelectedIndex = -1;
            tbWejscie.Text = string.Empty;
            tbWynik.Text = string.Empty;
        }

        private string FnaC(string wejscie)
        {
            result = (Convert.ToDouble(wejscie) - 32) * 0.55;
            return result.ToString();
        }
        private string CnaF(string wejscie)
        {
            result = 32 + 1.8*Convert.ToDouble(wejscie);
            return result.ToString();
        }
        private string KgNaFunt(string wejscie)
        {
            if(Convert.ToDouble(wejscie)>0)
            {
                result = 0.4095124 * Convert.ToDouble(wejscie);
                return result.ToString();
            }
            else
            {
                MessageBox.Show(String.Format("Wartość do zamiany musi być większa od 0"));
                return null;
            }
            
        }
        private string FuntNaKg(string wejscie)
        {
            if (Convert.ToDouble(wejscie) > 0)
            {
                result = Convert.ToDouble(wejscie) / 0.4095124;
                return result.ToString();
            }
            else
            {
                MessageBox.Show(String.Format("Wartość do zamiany musi być większa od 0"));
                return null;
            }
            
        }
        private string WezelNaKm(string wejscie)
        {
            if (Convert.ToDouble(wejscie) > 0)
            {
                result = Convert.ToDouble(wejscie) * 1.85166;
                return result.ToString();
            }
            else
            {
                MessageBox.Show(String.Format("Wartość do zamiany musi być większa od 0"));
                return null;
            }
            
            
        }
        private string KmNaWezel(string wejscie)
        {
            if (Convert.ToDouble(wejscie) > 0)
            {
                result = Convert.ToDouble(wejscie) / 1.85166;
                return result.ToString();
            }
            else
            {
                MessageBox.Show(String.Format("Wartość do zamiany musi być większa od 0"));
                return null;
            }
        }
    }
}
