//-->NOMBRES: DIEGO HUERTA; SANTIAGO RIVERA
//-->FECHA: 22/02/2018
// GUIADOS EN EL CODIGO RECUPERADO DE: https://www.youtube.com/watch?v=aGWVEYrPEgI&t=200s DEL CANAL "Develoteca"

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace WinAppParesCuerpo
{
    public partial class frmNivel2 : Form
    {
        CNivel2 Nivel2 = new CNivel2();

        public frmNivel2()
        {
            InitializeComponent();
            CenterToScreen();
            SoundPlayer snd2Player = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.InicioNivel2);
            snd2Player.Play();
            Nivel2.memoria(pnlNivel2, timer1, timer2, picCaraFeliz, picCaraSorprendida, this, picVida1, picVida2, picVida3);
        }

        private void frmNivel2_Load(object sender, EventArgs e)
        {
        }
        private void BtnPrevN2_Click(object sender, EventArgs e)
        {
            frmNivel1 frmNivel1 = new frmNivel1();
            this.Close();
            frmNivel1.Show();
        }
        private void btnReplayN1_Click(object sender, EventArgs e)
        {
            frmNivel2 nivel2 = new frmNivel2();
            this.Close();
            nivel2.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                Nivel2.CartaTemporal11.Image = Properties.Resources.interrogacion;
                Nivel2.CartaTemporal21.Image = Properties.Resources.interrogacion;
                Nivel2.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for (int k = 0; k < 8; k++)
                {
                    Nivel2.CartaTemporal7[k].Image = Properties.Resources.interrogacion;
                }
                Nivel2.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer2.Stop();
            }
        }
    }
}
