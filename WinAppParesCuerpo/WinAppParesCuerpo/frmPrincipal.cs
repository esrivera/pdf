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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Menu_principal);
            sndPlayer1.Play();
            InitializeComponent();
            btnPlay.Show();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            
            frmNivel1 frmNivel1 = new frmNivel1();
            frmNivel1.Show();
            //this.Hide();
            btnPlay.Hide();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            btnPlay.Show();
        }

        private void sonidoMouse(object sender, EventArgs e)
        {
            //SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Para_texto);
            //sndPlayer1.Play();
        }
    }
}
