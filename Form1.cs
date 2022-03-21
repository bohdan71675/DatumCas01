using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatumCas01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            char[] separators = { ' ', ';' };
            DateTime nejstarsi = new DateTime();
            for (int i = 0; i < textBox1.Lines.Count(); ++i)
            {
                string[] stringsplit = s.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                DateTime str = DateTime.Parse(textBox1.Lines[i].ToString());
                while (str > 0)
                {
                    DateTime idk = DateTime.Parse(stringsplit[2].ToString());
                    if (idk > nejstarsi)
                    {
                        nejstarsi = idk;
                    }
                    --str;
                 }

            }
            MessageBox.Show("Datum nejstarší osoby je: " + nejstarsi);
        }
    }
}
