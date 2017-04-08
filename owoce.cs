using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace packman
{
    class owoce : IChangeColorAble
    {
         public PictureBox[] tab = new PictureBox[10];
         public void PoukladajOwoce(PictureBox o1, PictureBox o2, PictureBox o3, PictureBox o4, PictureBox o5, PictureBox o6, PictureBox o7, PictureBox o8, PictureBox o9, PictureBox o10)
        {            
            tab[0] = o1; tab[1] = o2; tab[2] = o3; tab[3] = o4; tab[4] = o5; tab[5] = o6; tab[6] = o7; tab[7] = o8; tab[8] = o9; tab[9] = o10;
        }
         public void ZmienKolorNaZieliony()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 6);
           
            if(tab[a].BackColor == System.Drawing.Color.Red )
            {
                tab[a].BackColor = System.Drawing.Color.Green;
            }
        }
         public void ZmienKolorNaCzerwony()
        {
            Random rnd = new Random();
            int a = rnd.Next(1, 10);

            if (tab[a].BackColor == System.Drawing.Color.Green)
            {
                tab[a].BackColor = System.Drawing.Color.Red;
            }

        }
    }
}
