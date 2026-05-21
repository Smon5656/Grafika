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
        Graphics mobjGrafika;

        enum enStavRukou {nahoru, dolu};
        enStavRukou menStav;

        int kontrolastisknuti = 0;


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

            //chci, aby pero nebylo tenke ale tlustsi
            Pen MojePero;
            MojePero = new Pen(Color.Red, 2);

            //nakreslim usecku z bodu 0,0 do 100,100
            //mobjGrafika.DrawLine(MojePero, 0, 0, 100, 100);

            //elypsy a kruznice kreslim pomoci obrysovych tvaru a pak do nich dam elypsu treba
            //mobjGrafika.DrawEllipse(MojePero, 100, 100, 50, 50);

            //promenna
            kontrolastisknuti = 1;

        }

        private void tmrCas_Tick(object sender, EventArgs e)
        {
            Pen CervenePero;

            CervenePero = new Pen(Color.Red, 4);

            Pen BilePero;

            BilePero = new Pen(Color.Red, 4);

            //promenna
            string lstrCas;
            //naplnim promennou casem

            lstrCas = DateTime.Now.Hour.ToString() + ":"; //krokovani, F9 dam break point a F10 pokracuju
            lstrCas += DateTime.Now.Minute.ToString() + ":";
            lstrCas += DateTime.Now.Second.ToString();

            //vypisu na display
            txtDisplay.Text = lstrCas;

            //musim sdelit timeru aby tikal, v kontruktoru

            //-------------------------------------------------------
            //zmeny rukou
            //-------------------------------------------------------

            //vykreslit stavajici ruce bilou barvou

            //zmenit stav rukou
            if (menStav == enStavRukou.dolu)
            {
                menStav = enStavRukou.nahoru;
            }
            else
            {
                menStav = enStavRukou.dolu;
            }

            //vykreslit nove ruce nejakou barvou

            //-------------------------------------------------------------------------------------
            //muj zrudny debilni kod
            //----------------------------------------------------------------------------------------
            
            if (kontrolastisknuti == 1)
            {
              
                Pen MojePero;
                MojePero = new Pen(Color.Red, 2);

                if (menStav == enStavRukou.dolu)
                {
                    MojePero = new Pen(Color.White, 2);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 140, 150);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 210, 150);

                    MojePero = new Pen(Color.Red, 2);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 120, 80);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 230, 80);
                }
                if (menStav == enStavRukou.nahoru)
                {
                    MojePero = new Pen(Color.White, 2);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 120, 80);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 230, 80);

                    MojePero = new Pen(Color.Red, 2);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 140, 150);
                    mobjGrafika.DrawLine(MojePero, 180, 100, 210, 150);
                }

                //---------------------------------------------------
                //kreslim panacka
                //---------------------------------------------------

                //hlava
                mobjGrafika.DrawEllipse(MojePero, 150, 25, 60, 60);

                //telo
                mobjGrafika.DrawLine(MojePero, 180, 87, 180, 150);

                //nohy
                mobjGrafika.DrawLine(MojePero, 180, 150, 140, 220);
                mobjGrafika.DrawLine(MojePero, 180, 150, 210, 220);

                //ruce
                //mobjGrafika.DrawLine(MojePero, 180, 100, 140, 150);
                //mobjGrafika.DrawLine(MojePero, 180, 100, 210, 150);



            }
            
            
        }

        //funguje tohle, kdyz nahraju form
        private void Form1_Load(object sender, EventArgs e)
        {
            //vytvorim si grafiku, knihovna se pripoji na to platno
            mobjGrafika = pbPlatno.CreateGraphics();

            /*
            //menim stav rukou

            //pocatecni stav
            menStav = enStavRukou.dolu;

            //zvednute ruce
            */
            
        }
    }
}
