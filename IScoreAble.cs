using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packman
{
    interface IScoreAble
    {
      int  wynik {get;set;}

        // dorob ten rest co usunales
        void DodajPunkty(PictureBox x, PictureBox y, Label z, ProgressBar o);    
        void Wygrana(Label a1, Label a, Timer b, Timer c, Timer d, PictureBox e, Panel f, Label g, Label h);
        void Przegrana(Label a1, Label a, Timer b, Timer c, Timer d, PictureBox e, Panel f, Label g, Label h, ProgressBar o);
    }
}
