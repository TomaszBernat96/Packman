using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packman
{
    class player : IScoreAble,ILifeScore
    {
      
      public int wynik { get; set; }
      public int zycie { get; set; }
      public int licznik_grafik_kolek=0;
      public int licznik_grafik_zycia = 0;

        public player()
        {
            wynik = 0;
            zycie = 4;
        }

        public void DodajPunkty(PictureBox x, PictureBox y, Label z, ProgressBar o)
        {
            if (y.Enabled == true)
            {
                if ((y.BackColor == System.Drawing.Color.Red) && (x.Right > y.Left - 3.5 && x.Left < y.Right - x.Width / 2 && x.Bottom > y.Top && x.Top < y.Bottom))
                {

                    if (o.Value < 4 && licznik_grafik_zycia == 5)
                    {
                        o.Value += 1;
                    }
                    y.Hide();
                    y.Enabled = false;
                    y.Visible = false;
                    wynik += 100;
                    z.Text = Convert.ToString(wynik);
                    licznik_grafik_kolek++;
                    licznik_grafik_zycia++;
              

                }
            }
        
        }    
     
        public void Wygrana(Label a1,Label a, Timer b, Timer c, Timer d, PictureBox e, Panel f, Label g,Label h)
        {
            if(licznik_grafik_kolek==10 && a.Text!="0")
            {
                f.Visible = true;
                f.Location = new Point(304, 46);
                f.Size = new Size(336, 240);
                f.BackColor = Color.Black;
                e.Visible = false;
                d.Enabled = false;
                c.Enabled = false;
                b.Enabled = false;
                g.Text = "\tGRATULACJE WYGRALES.";
                wynik = Convert.ToInt32(a1.Text);
                wynik = wynik + (Convert.ToInt32(a.Text) * 5);
                a1.Text = Convert.ToString(wynik);
                h.Text = Convert.ToString(wynik);
            }
        }

        public void Przegrana(Label a1, Label a, Timer b, Timer c, Timer d, PictureBox e, Panel f, Label g, Label h, ProgressBar o)
        {
            if (o.Value==0 && a.Text != "0")
            {
                f.Visible = true;
                f.Location = new Point(304, 46);
                f.Size = new Size(336, 240);
                f.BackColor = Color.Black;
                e.Visible = false;
                d.Enabled = false;
                c.Enabled = false;
                b.Enabled = false;
                g.Text = "     PRZEGRALES !!!";
                wynik = Convert.ToInt32(a1.Text);
                wynik = wynik + (Convert.ToInt32(a.Text) * 5);
                wynik -= 200;
                a1.Text = Convert.ToString(wynik);
                h.Text = Convert.ToString(wynik);
            }
        }

        public void OdejmijPktZycia( PictureBox x, PictureBox y, ProgressBar e)
        {
            if (y.Enabled == true)
            { 
                if ((x.Right > y.Left - 3.5 && x.Left < y.Right - x.Width / 2 && x.Bottom > y.Top && x.Top < y.Bottom) && (y.BackColor == System.Drawing.Color.Green))
                {
                
                    y.Hide();
                    y.Enabled = false;
                    y.Visible = false;
                    e.Value -= 1;
                    //dorob kilka kolorowych plansz 
                    licznik_grafik_kolek++;
                  
                }
            }
        }
 
   

    }
}
