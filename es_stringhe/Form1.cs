using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es_stringhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string parola = txt_n1.Text;
            int vocali = 0, lunghezza = parola.Length;
            bool diversi = true;
            char temp;

            if (string.IsNullOrEmpty (parola)) 
            {
                MessageBox.Show("Attenzione! Inserire una parola");
            }
            else
            {
                for (int i = 0; i < parola.Length; i++)
                {

                    if (parola[i] == 'a' || parola[i] == 'e' || parola[i] == 'i' || parola[i] == 'o' || parola[i] == 'u')
                    {
                        vocali = vocali + 1;
                    }


                }

                lbl_n2.Text = "Numero di vocali: " + vocali;
            }
        }
    }
}
