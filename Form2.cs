using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace packman
{
    public partial class deck : Form
    {
        int c;
        owoce owoc_pojemnik = new owoce();
        player graczek_pojemnik = new player();
        bool lewo;
        bool prawo;
        bool gora;
        bool dol;

        public deck()
        {
            Random rnd = new Random();
            c = rnd.Next(70, 120);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Cursor = Cursors.No;
            InitializeComponent();
        }

        private void deck_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { prawo = true; }
            if (e.KeyCode == Keys.Left) { lewo = true; }
            if (e.KeyCode == Keys.Up) { gora = true; }
            if (e.KeyCode == Keys.Down) { dol = true; }
        }

        private void deck_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right) { prawo = false; }
            if (e.KeyCode == Keys.Left) { lewo = false; }
            if (e.KeyCode == Keys.Up) { gora = false; }
            if (e.KeyCode == Keys.Down) { dol = false; }
        }

        private void ruch_Tick(object sender, EventArgs e)
        {
            //Kolizja z prawej strony scian
            #region
            if (postac.Right > sciana1.Left - 3.5 && postac.Left < sciana1.Right - postac.Width / 2 && postac.Bottom > sciana1.Top && postac.Top < sciana1.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana2.Left - 3.3 && postac.Left < sciana2.Right - postac.Width / 2 && postac.Bottom > sciana2.Top && postac.Top < sciana2.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana3.Left - 1.5 && postac.Left < sciana3.Right - postac.Width / 2 && postac.Bottom > sciana3.Top && postac.Top < sciana3.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana4.Left - 2.3 && postac.Left < sciana4.Right - postac.Width / 2 && postac.Bottom > sciana4.Top && postac.Top < sciana4.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana5.Left - 1.5 && postac.Left < sciana5.Right - postac.Width / 2 && postac.Bottom > sciana5.Top && postac.Top < sciana5.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana6.Left - 1.5 && postac.Left < sciana6.Right - postac.Width / 2 && postac.Bottom > sciana6.Top && postac.Top < sciana6.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana7.Left - 4 && postac.Left < sciana7.Right - postac.Width / 2 && postac.Bottom > sciana7.Top && postac.Top < sciana7.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana8.Left - 1.5 && postac.Left < sciana8.Right - postac.Width / 2 && postac.Bottom > sciana8.Top && postac.Top < sciana8.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana9.Left - 1.5 && postac.Left < sciana9.Right - postac.Width / 2 && postac.Bottom > sciana9.Top && postac.Top < sciana9.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana10.Left -5 && postac.Left<sciana10.Right-postac.Width/2&&postac.Bottom>sciana10.Top&&postac.Top<sciana10.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana11.Left - 5 && postac.Left < sciana11.Right - postac.Width / 2 && postac.Bottom > sciana11.Top && postac.Top < sciana11.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana12.Left - 2.4 && postac.Left < sciana12.Right - postac.Width / 2 && postac.Bottom > sciana12.Top && postac.Top < sciana12.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana13.Left - 2.3 && postac.Left < sciana13.Right - postac.Width / 2 && postac.Bottom > sciana13.Top && postac.Top < sciana13.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana14.Left - 1.5 && postac.Left < sciana14.Right - postac.Width / 2 && postac.Bottom > sciana14.Top && postac.Top < sciana14.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana15.Left - 2.3 && postac.Left < sciana15.Right - postac.Width / 2 && postac.Bottom > sciana15.Top && postac.Top < sciana15.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana16.Left - 1.5 && postac.Left < sciana16.Right - postac.Width / 2 && postac.Bottom > sciana16.Top && postac.Top < sciana16.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana17.Left - 2.4 && postac.Left < sciana17.Right - postac.Width / 2 && postac.Bottom > sciana17.Top && postac.Top < sciana17.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana18.Left - 2.4 && postac.Left < sciana18.Right - postac.Width / 2 && postac.Bottom > sciana18.Top && postac.Top < sciana18.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana19.Left - 2.4 && postac.Left < sciana19.Right - postac.Width / 2 && postac.Bottom > sciana19.Top && postac.Top < sciana19.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana20.Left - 4 && postac.Left < sciana20.Right - postac.Width / 2 && postac.Bottom > sciana20.Top && postac.Top < sciana20.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana21.Left - 1.5 && postac.Left < sciana21.Right - postac.Width / 2 && postac.Bottom > sciana21.Top && postac.Top < sciana21.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana22.Left - 1.5 && postac.Left < sciana22.Right - postac.Width / 2 && postac.Bottom > sciana22.Top && postac.Top < sciana22.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana23.Left - 1.5 && postac.Left < sciana23.Right - postac.Width / 2 && postac.Bottom > sciana23.Top && postac.Top < sciana23.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana24.Left - 2.4 && postac.Left < sciana24.Right - postac.Width / 2 && postac.Bottom > sciana24.Top && postac.Top < sciana24.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana25.Left - 1.5 && postac.Left < sciana25.Right - postac.Width / 2 && postac.Bottom > sciana25.Top && postac.Top < sciana25.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana26.Left - 1.5 && postac.Left < sciana26.Right - postac.Width / 2 && postac.Bottom > sciana26.Top && postac.Top < sciana26.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana27.Left - 3.3 && postac.Left < sciana27.Right - postac.Width / 2 && postac.Bottom > sciana27.Top && postac.Top < sciana27.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana28.Left - 1.5 && postac.Left < sciana28.Right - postac.Width / 2 && postac.Bottom > sciana28.Top && postac.Top < sciana28.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana29.Left - 1.5 && postac.Left < sciana29.Right - postac.Width / 2 && postac.Bottom > sciana29.Top && postac.Top < sciana29.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana30.Left -3.3 && postac.Left < sciana30.Right - postac.Width / 2 && postac.Bottom > sciana30.Top && postac.Top < sciana30.Bottom)
            {
                prawo = false;

            }
            if (postac.Right > sciana31.Left - 2.4 && postac.Left < sciana31.Right - postac.Width / 2 && postac.Bottom > sciana31.Top && postac.Top < sciana31.Bottom)
            {
                prawo = false;

            }
            #endregion

            // Kolizja z lewej strony scian
            #region
            if (postac.Left < sciana1.Right + 2.5 && postac.Right > sciana1.Left + postac.Width / 2 && postac.Bottom > sciana1.Top && postac.Top < sciana1.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana2.Right + 2.8 && postac.Right > sciana2.Left + postac.Width / 2 && postac.Bottom > sciana2.Top && postac.Top < sciana2.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana3.Right + 2.8 && postac.Right > sciana3.Left + postac.Width / 2 && postac.Bottom > sciana3.Top && postac.Top < sciana3.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana4.Right+4.2 && postac.Right > sciana4.Left + postac.Width / 2 && postac.Bottom > sciana4.Top && postac.Top < sciana4.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana5.Right + 3.3 && postac.Right > sciana5.Left + postac.Width / 2 && postac.Bottom > sciana5.Top && postac.Top < sciana5.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana6.Right + 2.8 && postac.Right > sciana6.Left + postac.Width / 2 && postac.Bottom > sciana6.Top && postac.Top < sciana6.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana7.Right + 4.15 && postac.Right > sciana7.Left + postac.Width / 2 && postac.Bottom > sciana7.Top && postac.Top < sciana7.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana8.Right + 1.5 && postac.Right > sciana8.Left + postac.Width / 2 && postac.Bottom > sciana8.Top && postac.Top < sciana8.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana9.Right + 2.8 && postac.Right > sciana9.Left + postac.Width / 2 && postac.Bottom > sciana9.Top && postac.Top < sciana9.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana10.Right + 4.15 && postac.Right > sciana10.Left + postac.Width / 2 && postac.Bottom > sciana10.Top && postac.Top < sciana10.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana11.Right + 1.5 && postac.Right > sciana11.Left + postac.Width / 2 && postac.Bottom > sciana11.Top && postac.Top < sciana11.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana12.Right + 1.5 && postac.Right > sciana12.Left + postac.Width / 2 && postac.Bottom > sciana12.Top && postac.Top < sciana12.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana13.Right + 2.5 && postac.Right > sciana13.Left + postac.Width / 2 && postac.Bottom > sciana13.Top && postac.Top < sciana13.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana14.Right + 4 && postac.Right > sciana14.Left + postac.Width / 2 && postac.Bottom > sciana14.Top && postac.Top < sciana14.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana15.Right + 2.5 && postac.Right > sciana15.Left + postac.Width / 2 && postac.Bottom > sciana15.Top && postac.Top < sciana15.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana16.Right + 4 && postac.Right > sciana16.Left + postac.Width / 2 && postac.Bottom > sciana16.Top && postac.Top < sciana16.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana17.Right + 4 && postac.Right > sciana17.Left + postac.Width / 2 && postac.Bottom > sciana17.Top && postac.Top < sciana17.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana18.Right + 1.5 && postac.Right > sciana18.Left + postac.Width / 2 && postac.Bottom > sciana18.Top && postac.Top < sciana18.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana19.Right +4 && postac.Right > sciana19.Left + postac.Width / 2 && postac.Bottom > sciana19.Top && postac.Top < sciana19.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana20.Right + 4.2 && postac.Right > sciana20.Left + postac.Width / 2 && postac.Bottom > sciana20.Top && postac.Top < sciana20.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana21.Right + 1.5 && postac.Right > sciana21.Left + postac.Width / 2 && postac.Bottom > sciana21.Top && postac.Top < sciana21.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana22.Right + 1.5 && postac.Right > sciana22.Left + postac.Width / 2 && postac.Bottom > sciana22.Top && postac.Top < sciana22.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana23.Right + 1.5 && postac.Right > sciana23.Left + postac.Width / 2 && postac.Bottom > sciana23.Top && postac.Top < sciana23.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana24.Right + 4 && postac.Right > sciana24.Left + postac.Width / 2 && postac.Bottom > sciana24.Top && postac.Top < sciana24.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana25.Right + 1.5 && postac.Right > sciana25.Left + postac.Width / 2 && postac.Bottom > sciana25.Top && postac.Top < sciana25.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana26.Right + 1.5 && postac.Right > sciana26.Left + postac.Width / 2 && postac.Bottom > sciana26.Top && postac.Top < sciana26.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana27.Right + 1.5 && postac.Right > sciana27.Left + postac.Width / 2 && postac.Bottom > sciana27.Top && postac.Top < sciana27.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana28.Right + 1.5 && postac.Right > sciana28.Left + postac.Width / 2 && postac.Bottom > sciana28.Top && postac.Top < sciana28.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana29.Right + 1.5 && postac.Right > sciana29.Left + postac.Width / 2 && postac.Bottom > sciana29.Top && postac.Top < sciana29.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana30.Right + 4 && postac.Right > sciana30.Left + postac.Width / 2 && postac.Bottom > sciana30.Top && postac.Top < sciana30.Bottom)
            {
                lewo = false;

            }
            if (postac.Left < sciana31.Right + 4.2 && postac.Right > sciana31.Left + postac.Width / 2 && postac.Bottom > sciana31.Top && postac.Top < sciana31.Bottom)
            {
                lewo = false;

            }

            #endregion

            //Kolizja z gora sciany
            #region

            if (postac.Bottom > (sciana1.Top -5) && postac.Right > sciana1.Left  && postac.Top < sciana1.Bottom && postac.Left < sciana1.Right) 
            {
               dol = false;

            }
            if (postac.Bottom > (sciana2.Top - 4) && postac.Right > sciana2.Left  && postac.Top < sciana2.Bottom && postac.Left < sciana2.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana3.Top - 4.3) && postac.Right > sciana3.Left  && postac.Top < sciana3.Bottom && postac.Left < sciana3.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana4.Top - 4) && postac.Right > sciana4.Left  && postac.Top < sciana4.Bottom && postac.Left < sciana4.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana5.Top - 4) && postac.Right > sciana5.Left  && postac.Top < sciana5.Bottom && postac.Left < sciana5.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana8.Top - 5) && postac.Right > sciana8.Left  && postac.Top < sciana8.Bottom && postac.Left < sciana8.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana9.Top - 5) && postac.Right > sciana9.Left  && postac.Top < sciana9.Bottom && postac.Left < sciana9.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana10.Top - 4) && postac.Right > sciana10.Left  && postac.Top < sciana10.Bottom && postac.Left < sciana10.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana11.Top - 4) && postac.Right > sciana11.Left  && postac.Top < sciana11.Bottom && postac.Left < sciana11.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana12.Top - 4) && postac.Right > sciana12.Left  && postac.Top < sciana12.Bottom && postac.Left < sciana12.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana14.Top - 5) && postac.Right > sciana14.Left  && postac.Top < sciana14.Bottom && postac.Left < sciana14.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana16.Top - 4.5) && postac.Right > sciana16.Left  && postac.Top < sciana16.Bottom && postac.Left < sciana16.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana18.Top - 4.3) && postac.Right > sciana18.Left  && postac.Top < sciana18.Bottom && postac.Left < sciana18.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana19.Top - 4.8) && postac.Right > sciana19.Left  && postac.Top < sciana19.Bottom && postac.Left < sciana19.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana20.Top - 4) && postac.Right > sciana20.Left  && postac.Top < sciana20.Bottom && postac.Left < sciana20.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana21.Top - 4) && postac.Right > sciana21.Left  && postac.Top < sciana21.Bottom && postac.Left < sciana21.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana22.Top - 5) && postac.Right > sciana22.Left  && postac.Top < sciana22.Bottom && postac.Left < sciana22.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana23.Top - 5) && postac.Right > sciana23.Left  && postac.Top < sciana23.Bottom && postac.Left < sciana23.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana25.Top - 4) && postac.Right > sciana25.Left  && postac.Top < sciana25.Bottom && postac.Left < sciana25.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana26.Top - 4) && postac.Right > sciana26.Left  && postac.Top < sciana26.Bottom && postac.Left < sciana26.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana27.Top - 4) && postac.Right > sciana27.Left  && postac.Top < sciana27.Bottom && postac.Left < sciana27.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana28.Top - 4) && postac.Right > sciana28.Left  && postac.Top < sciana28.Bottom && postac.Left < sciana28.Right)
            {
                dol = false;

            }
            if (postac.Bottom > (sciana29.Top - 4) && postac.Right > sciana29.Left  && postac.Top < sciana29.Bottom && postac.Left < sciana29.Right)
            {
                dol = false;

            }
            #endregion

            //Kolizja z dolem sciany
            #region
            if (postac.Top-4 < sciana1.Bottom && postac.Right > sciana1.Left  && postac.Bottom > sciana1.Top && postac.Left < sciana1.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana3.Bottom && postac.Right > sciana3.Left  && postac.Bottom > sciana3.Top && postac.Left < sciana3.Right)
            {
                gora = false;

            }
            if (postac.Top - 4.2 < sciana5.Bottom && postac.Right > sciana5.Left  && postac.Bottom > sciana5.Top && postac.Left < sciana5.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana6.Bottom && postac.Right > sciana6.Left  && postac.Bottom > sciana6.Top && postac.Left < sciana6.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana7.Bottom && postac.Right > sciana7.Left  && postac.Bottom > sciana7.Top && postac.Left < sciana7.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana8.Bottom && postac.Right > sciana8.Left  && postac.Bottom > sciana8.Top && postac.Left < sciana8.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana9.Bottom && postac.Right > sciana9.Left  && postac.Bottom > sciana9.Top && postac.Left < sciana9.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana11.Bottom && postac.Right > sciana11.Left && postac.Bottom > sciana11.Top && postac.Left < sciana11.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana12.Bottom && postac.Right > sciana12.Left  && postac.Bottom > sciana12.Top && postac.Left < sciana12.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana13.Bottom && postac.Right > sciana13.Left  && postac.Bottom > sciana13.Top && postac.Left < sciana13.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana14.Bottom && postac.Right > sciana14.Left  && postac.Bottom > sciana14.Top && postac.Left < sciana14.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana16.Bottom && postac.Right > sciana16.Left  && postac.Bottom > sciana16.Top && postac.Left < sciana16.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana17.Bottom && postac.Right > sciana17.Left  && postac.Bottom > sciana17.Top && postac.Left < sciana17.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana18.Bottom && postac.Right > sciana18.Left  && postac.Bottom > sciana18.Top && postac.Left < sciana18.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana19.Bottom && postac.Right > sciana19.Left  && postac.Bottom > sciana19.Top && postac.Left < sciana19.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana20.Bottom && postac.Right > sciana20.Left  && postac.Bottom > sciana20.Top && postac.Left < sciana20.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana21.Bottom && postac.Right > sciana21.Left  && postac.Bottom > sciana21.Top && postac.Left < sciana21.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana22.Bottom && postac.Right > sciana22.Left  && postac.Bottom > sciana22.Top && postac.Left < sciana22.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana23.Bottom && postac.Right > sciana23.Left  && postac.Bottom > sciana23.Top && postac.Left < sciana23.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana24.Bottom && postac.Right > sciana24.Left  && postac.Bottom > sciana24.Top && postac.Left < sciana24.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana25.Bottom && postac.Right > sciana25.Left  && postac.Bottom > sciana25.Top && postac.Left < sciana25.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana26.Bottom && postac.Right > sciana26.Left  && postac.Bottom > sciana26.Top && postac.Left < sciana26.Right)
            {
                gora = false;

            }
            if (postac.Top - 5 < sciana27.Bottom && postac.Right > sciana27.Left  && postac.Bottom > sciana27.Top && postac.Left < sciana27.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana30.Bottom && postac.Right > sciana30.Left  && postac.Bottom > sciana30.Top && postac.Left < sciana30.Right)
            {
                gora = false;

            }
            if (postac.Top - 4 < sciana31.Bottom && postac.Right > sciana31.Left  && postac.Bottom > sciana31.Top && postac.Left < sciana31.Right)
            {
                gora = false;

            }
            #endregion

            //Kolizja z obrecza planszy
            #region
            if (postac.Right > obrecz_prawo.Left - 1.5 && postac.Left < obrecz_prawo.Right - postac.Width / 2 && postac.Bottom > obrecz_prawo.Top && postac.Top < obrecz_prawo.Bottom)
            {
                prawo = false;

            }
            if (postac.Left < obrecz_lewo.Right + 1.5 && postac.Right > obrecz_lewo.Left + postac.Width / 2 && postac.Bottom > obrecz_lewo.Top && postac.Top < obrecz_lewo.Bottom)
            {
                lewo = false;

            }
            if (postac.Bottom > (obrecz_dol.Top - 4.5) && postac.Right > obrecz_dol.Left + postac.Width / 2 && postac.Top < obrecz_dol.Bottom && postac.Left < obrecz_dol.Right)
            {
                dol = false;

            }
            if (postac.Top - 4 < obrecz_gora.Bottom && postac.Right > obrecz_gora.Left + postac.Width / 2 && postac.Bottom > obrecz_gora.Top && postac.Left < obrecz_gora.Right)
            {
                gora = false;

            }
            #endregion


            if (prawo == true)
            {
               
                postac.Left += 5;
                postac.Image = Image.FromFile("D:\\grafiki\\prawo.png");
            }
            if (lewo == true)
            {
                postac.Left -= 5;
                postac.Image = Image.FromFile("D:\\grafiki\\lewo.png");
            }
            if (gora == true)
            {
                postac.Top -= 5;
                postac.Image = Image.FromFile("D:\\grafiki\\gora.png");               
            }
            if (dol == true)
            {
                postac.Top += 5;
                postac.Image = Image.FromFile("D:\\grafiki\\dol.png");             
            }

            graczek_pojemnik.DodajPunkty(postac, owoc1, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc2, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc3, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc4, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc5, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc6, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc7, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc8, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc9, kontener_wynik, pasek_zycia);
            graczek_pojemnik.DodajPunkty(postac, owoc10, kontener_wynik, pasek_zycia);

            graczek_pojemnik.OdejmijPktZycia(postac, owoc1, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc2, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc3, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc4, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc5, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc6, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc7, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc8, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc9, pasek_zycia);
            graczek_pojemnik.OdejmijPktZycia(postac, owoc10, pasek_zycia);

            graczek_pojemnik.Wygrana(kontener_wynik,kontener_czas,czas_gry,ruch,zepsute_owoce, postac, panel2, label2,label3);

            graczek_pojemnik.Przegrana(kontener_wynik, kontener_czas, czas_gry, ruch, zepsute_owoce, postac, panel2, label2, label3, pasek_zycia);
        }
        
        private void czas_gry_Tick(object sender, EventArgs e)
        {
            //int czasik;
            kontener_czas.Text = Convert.ToString(c);
            //c = Convert.ToInt32(kontener_czas.Text);
            c--;            
            //kontener_czas.Text = Convert.ToString(c);
            if(c<=0)
            {
                zepsute_owoce.Enabled = false;
                czas_gry.Enabled = false;
                ruch.Enabled = false;
                postac.Visible = false;
                panel2.Visible = true;
                panel2.Location = new Point(304,46);
                panel2.Size = new Size(336,240);
                owoc1.Visible = false;
                owoc10.Visible = false;
                owoc2.Visible = false;
                owoc6.Visible = false;
               
            }

        }

        private void powrot_do_menu_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.Visible = true;
            
        }

        private void zepsute_owoce_Tick(object sender, EventArgs e)
        {
            owoc_pojemnik.PoukladajOwoce(owoc1, owoc2, owoc3, owoc4, owoc5, owoc6, owoc7, owoc8, owoc9, owoc10);
            owoc_pojemnik.ZmienKolorNaZieliony();
            owoc_pojemnik.ZmienKolorNaCzerwony();
            
        }
    }
}
