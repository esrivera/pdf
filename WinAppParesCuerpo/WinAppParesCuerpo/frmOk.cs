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
    public partial class frmOk : Form
    {
        public frmOk()
        {
            InitializeComponent();
            CenterToScreen();
            SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Fallaste);
            sndPlayer1.Play();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void sonidoMouse(object sender, EventArgs e)
        {
            //SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Para_texto);
            //sndPlayer1.Play();
        }
    }
}
