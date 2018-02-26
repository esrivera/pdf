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
    public partial class frmNivel1 : Form
    {
        CNivel1 Nivel1 = new CNivel1();
        
        public frmNivel1()
        {
            SoundPlayer sndPlayer = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.InicioNivel1);
            sndPlayer.Play();
            InitializeComponent();
            CenterToScreen();
            Nivel1.memoria(pnlNivel1, timer1, timer2,picCaraFeliz,picCaraSorprendida,this,picVida1,picVida2,picVida3);
        }

        private void frmNivel1_Load(object sender, EventArgs e)
        {
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                Nivel1.CartaTemporal11.Image = Properties.Resources.interrogacion;
                Nivel1.CartaTemporal21.Image = Properties.Resources.interrogacion;
                Nivel1.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer1.Stop();
            }
        }
        private void btnReplayN1_Click(object sender, EventArgs e)
        {
            frmNivel1 nivel1 = new frmNivel1();
            this.Close();
            nivel1.Show();
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            int TiempoVirarCarta = 1;
            if (TiempoVirarCarta == 1)
            {
                for(int k=0; k < 6; k++)
                {
                    Nivel1.CartaTemporal7[k].Image = Properties.Resources.interrogacion;
                }
                Nivel1.CartasSeleccionadas1.Clear();
                TiempoVirarCarta = 0;
                timer2.Stop();
            }
        }
    }
}
