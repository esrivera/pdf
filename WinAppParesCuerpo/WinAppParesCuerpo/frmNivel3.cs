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
    public partial class frmNivel3 : Form
    {
        CNivel3 Nivel3 = new CNivel3();

        public frmNivel3()
        {
            InitializeComponent();
            CenterToScreen();
            SoundPlayer sndPlayer = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.InicioNivel3);
            sndPlayer.Play();
            Nivel3.memoria(pnlNivel3, timer1, timer2, picCaraFeliz, picCaraSorprendida, this, picVida1, picVida2, picVida3);
        }

        private void frmNivel3_Load(object sender, EventArgs e)
        {
        }
        private void btnReplayN1_Click(object sender, EventArgs e)
        {
            frmNivel3 nivel3 = new frmNivel3();
            this.Close();
            nivel3.Show();
        }
        private void BtnPrevN3_Click(object sender, EventArgs e)
        {
            frmNivel2 frmNivel2 = new frmNivel2();
            this.Close();
            frmNivel2.Show();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                Nivel3.CartaTemporal11.Image = Properties.Resources.interrogacion;
                Nivel3.CartaTemporal21.Image = Properties.Resources.interrogacion;
                Nivel3.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for (int k = 0; k < 10; k++)
                {
                    Nivel3.CartaTemporal7[k].Image = Properties.Resources.interrogacion;
                }
                Nivel3.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer2.Stop();
            }
        }
    }
}
