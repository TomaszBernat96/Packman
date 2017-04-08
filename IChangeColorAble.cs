using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packman
{
    interface IChangeColorAble
    {
        void PoukladajOwoce(PictureBox o1, PictureBox o2, PictureBox o3, PictureBox o4, PictureBox o5, PictureBox o6, PictureBox o7, PictureBox o8, PictureBox o9, PictureBox o10);
        void ZmienKolorNaZieliony();
        void ZmienKolorNaCzerwony();
    }
}
