using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encryption;
using Decryption;
using System.Windows.Forms;
using System.IO;

namespace Base64App
{
    public partial class Form1 : Form
    {
        string Zgjedh = "Kodo";
        Encryption.toBase64 Kodo = new Encryption.toBase64();
        Decryption.fromBase64 Dekodo = new Decryption.fromBase64();

        public Form1()
        {
            InitializeComponent();

            groupBox1.ForeColor = Color.DarkOliveGreen;
            groupBox2.ForeColor = Color.DarkOliveGreen;

            rdbZgjedhKodo.Checked = true;
            rdbImportTekst.Checked = true;
        }
        
        private void rdbZgjedhDekodo_CheckedChanged(object sender, EventArgs e)
        {
            Zgjedh = "Dekodo";
            btnDo.Text = Zgjedh;
        }

        private void rdbZgjedhKodo_CheckedChanged(object sender, EventArgs e)
        {
            Zgjedh = "Kodo";
            btnDo.Text = Zgjedh;
        }

        private void rdbImportTekst_CheckedChanged(object sender, EventArgs e)
        {
            txtInputTekst.Enabled = false;
            Browse.Enabled = true;

            txtInputTekst.Text = "";
            txtTekstiJuaj.Text = "";
            txtOutputTekst.Text = "";
        }

        private void rdbShkruajTekst_CheckedChanged(object sender, EventArgs e)
        {
            Browse.Enabled = false;
            txtInputTekst.Enabled = true;

            txtInputTekst.Text = "";
            txtTekstiJuaj.Text = "";
            txtOutputTekst.Text = "";
        }

        private void Browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog browser = new OpenFileDialog();
            browser.Title = "Direktiva për hapjen e fajllit!";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                txtInputTekst.Text = browser.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Zgjedh == "Kodo")
            {
                if (rdbImportTekst.Checked == true)
                {
                    StreamReader tekstiLexuar = new StreamReader(txtInputTekst.Text);

                    txtTekstiJuaj.Text = tekstiLexuar.ReadToEnd();

                    txtOutputTekst.Text = Kodo.Encode(txtTekstiJuaj.Text);

                    tekstiLexuar.Close();
                }
                else
                {
                    txtTekstiJuaj.Text = txtInputTekst.Text;
                    txtOutputTekst.Text = Kodo.Encode(txtInputTekst.Text);
                }
            }
            else
            {
                if (rdbImportTekst.Checked == true)
                {
                    
                    StreamReader tekstiLexuar = new StreamReader(txtInputTekst.Text);
                    string teksti = tekstiLexuar.ReadToEnd();

                    if (Dekodo.isStringValid(teksti))
                    {

                        txtTekstiJuaj.Text = teksti;

                        txtOutputTekst.Text = Dekodo.Decode(teksti);
                        tekstiLexuar.Close();
                    }
                    else
                    {
                        MessageBox.Show("Jo valid!");
                        tekstiLexuar.Close();
                        return;
                    }
                }
                else
                {
                    txtTekstiJuaj.Text = txtInputTekst.Text;
                    txtOutputTekst.Text = Dekodo.Decode(txtInputTekst.Text);
                }
            }
        }

        //nuk mundet me u fshi?!
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog browser = new SaveFileDialog();
            browser.Filter = "Text Format|*.txt";
            browser.Title = "Direktiva për ruajtjen e fajllit!";

            if (browser.ShowDialog() == DialogResult.OK)
            {
                StreamWriter shkruajTekst = new StreamWriter(browser.FileName);

                shkruajTekst.Write(txtOutputTekst.Text);
                shkruajTekst.Close();


                MessageBox.Show("Keni ruajtur me sukses tekstin!", "Informatë");
            }
        }
    }
}
