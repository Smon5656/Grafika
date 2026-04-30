using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafika
{
    public partial class Form1 : Form
    {
        //------------------------------------------------------------------------
        //kontruktor
        //------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            //start timeru
            
            tmrCas.Interval = 1000;
            tmrCas.Start();
        }

        //stisk testovaciho tlacitka
        private void button1_Click(object sender, EventArgs e)
        {
            //my si to udelame slozitejsi, abychom si to procvicili
            //ja si tam mohu dat strint promenna a pak dat, ze se rozna data.time.now.hour,tostrint()
            //a pak txt.displat.test = lstrCas;

            //string lstrCas;
            //naplnim promennou casem

            //lstrCas = DateTime.Now.Hour.ToString() + ":"; //krokovani, F9 dam break point a F10 pokracuju
            //lstrCas += DateTime.Now.Minute.ToString() + ":";
            //lstrCas += DateTime.Now.Second.ToString();

            //vypisu na display
            //txtDisplay.Text = lstrCas;
            
        }

        private void tmrCas_Tick(object sender, EventArgs e)
        {
            string lstrCas;
            //naplnim promennou casem

            lstrCas = DateTime.Now.Hour.ToString() + ":"; //krokovani, F9 dam break point a F10 pokracuju
            lstrCas += DateTime.Now.Minute.ToString() + ":";
            lstrCas += DateTime.Now.Second.ToString();

            //vypisu na display
            txtDisplay.Text = lstrCas;

            //musim sdelit timeru aby tikal, v kontruktoru
        }
    }
}
