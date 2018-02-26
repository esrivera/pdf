//-->NOMBRES: DIEGO HUERTA; SANTIAGO RIVERA
//-->FECHA: 22/02/2018
// GUIADOS EN EL CODIGO RECUPERADO DE: https://www.youtube.com/watch?v=aGWVEYrPEgI&t=200s DEL CANAL "Develoteca"

using System;
using System.Collections;
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
    class CNivel3
    {
        int TamanioColumnas = 5;
        int TamanioFilas = 2;
        int contador = 0;
        int CantidadDeCartasVolteadas = 0;
        List<string> CartasEnumeradas;
        List<string> CartasRevueltas;
        ArrayList CartasSeleccionadas;
        PictureBox[] CartaTemporal = new PictureBox[10];
        PictureBox CartaTemporal1;
        PictureBox CartaTemporal2;
        int CartaActual = 0;
        public ArrayList CartasSeleccionadas1 { get => CartasSeleccionadas; set => CartasSeleccionadas = value; }
        public List<string> CartasEnumeradas1 { get => CartasEnumeradas; set => CartasEnumeradas = value; }
        public PictureBox CartaTemporal11 { get => CartaTemporal1; set => CartaTemporal1 = value; }
        public PictureBox CartaTemporal21 { get => CartaTemporal2; set => CartaTemporal2 = value; }
        public PictureBox[] CartaTemporal7 { get => CartaTemporal; set => CartaTemporal = value; }

        public void memoria(Panel pnlNivel, Timer timer1, Timer timer2, PictureBox picCaraFeliz, PictureBox picCaraSorprendida, 
            frmNivel3 nivel3, PictureBox V1, PictureBox V2, PictureBox V3){

                //detiene el timer
                timer1.Enabled = false;
                timer1.Stop();
                CantidadDeCartasVolteadas = 0;
                //limpiar el panel
                pnlNivel.Controls.Clear();
                //inicializar las listas
                CartasEnumeradas = new List<string>();
                CartasRevueltas = new List<string>();
                CartasSeleccionadas = new ArrayList();
                //generar las cartas en forma de numeros
                for (int i = 0; i < 5; i++)
                {
                    CartasEnumeradas.Add(i.ToString());
                    CartasEnumeradas.Add(i.ToString());
                }
                //generar imagenes random y ordnar aleatoriamente
                var NumeroAleatorio = new Random();
                var Resultado = CartasEnumeradas.OrderBy(item => NumeroAleatorio.Next());
                foreach (string ValorCarta in Resultado)
                {
                    CartasRevueltas.Add(ValorCarta);
                }
                var tablaPanel = new TableLayoutPanel();
                tablaPanel.RowCount = TamanioFilas;
                tablaPanel.ColumnCount = TamanioColumnas;
                //conteo de columnas y filas
                for (int i = 0; i < TamanioColumnas; i++)
                {
                    var Porcenrtaje = 150f / (float)TamanioColumnas - 10;
                    tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcenrtaje));
                    tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcenrtaje));
                }
                int contadorFichas = 1;
                for (var i = 0; i < TamanioFilas; i++)
                {
                    for (var j = 0; j < TamanioColumnas; j++)
                    {
                        //agregamos las cartas
                        var CartasJuego = new PictureBox();
                        CartasJuego.Name = string.Format("{0}", contadorFichas);
                        CartasJuego.Dock = DockStyle.Fill;
                        CartasJuego.SizeMode = PictureBoxSizeMode.StretchImage;
                        CartasJuego.Image = Properties.Resources.interrogacion;
                        CartasJuego.Cursor = Cursors.Hand;
                        CartasJuego.VisibleChanged += Mostrar;
                        CartasJuego.Click += Seleccion;
                        tablaPanel.Controls.Add(CartasJuego, j, i);
                        contadorFichas++;
                    }
                }
                tablaPanel.Dock = DockStyle.Fill;
                pnlNivel.Controls.Add(tablaPanel);

                Bitmap RecuperarImagen(int NumeroImagen)
                {
                    Bitmap TmpImg = new Bitmap(200, 100);
                    switch (NumeroImagen)
                    {
                        case 0:
                            TmpImg = Properties.Resources.img6;
                            break;
                        default:
                            TmpImg = (Bitmap)Properties.Resources.ResourceManager.GetObject("img" + NumeroImagen);
                            break;
                    }
                    return TmpImg;
                }
                void Mostrar(object sender, EventArgs e)
                {
                    if (CartasSeleccionadas.Count < 10)
                    {
                        var CartasSeleccionadasUsuario = (PictureBox)sender;
                        //transformamos la carta seleccionada en un numero (-1)
                        CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                        CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                        CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                        CartaTemporal1.Enabled = false;
                        //recuperamos la imagen de la carta seleccionada
                        CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                        if (CartasSeleccionadas.Count == 10)
                        {
                            for (int k = 0; k < 10; k++)
                            {
                                CartaTemporal[k] = (PictureBox)CartasSeleccionadas[k];
                            }
                            //detenemos el tiempo mostramos las imagenes
                            timer2.Enabled = true;
                            timer2.Start();
                            for (int k = 0; k < 10; k++)
                            {
                                CartaTemporal[k].Enabled = true; ;
                            }
                        }
                    }
                }
                void Seleccion(object sender, EventArgs e)
                {
                    if (CartasSeleccionadas.Count < 2)
                    {
                        picCaraSorprendida.Hide();
                        picCaraFeliz.Hide();
                        var CartasSeleccionadasUsuario = (PictureBox)sender;
                        //transformamos la carta seleccionada en un numero (-1)
                        CartaActual = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartasSeleccionadasUsuario.Name) - 1]);
                        //recuperamos la imagen de la carta seleccionada
                        CartasSeleccionadasUsuario.Image = RecuperarImagen(CartaActual);
                        CartasSeleccionadas.Add(CartasSeleccionadasUsuario);
                        CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                        CartaTemporal1.Enabled = false;
                        if (CartasSeleccionadas.Count == 2)
                        {
                            CartaTemporal1 = (PictureBox)CartasSeleccionadas[0];
                            CartaTemporal2 = (PictureBox)CartasSeleccionadas[1];
                            int Carta1 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal1.Name) - 1]);
                            int Carta2 = Convert.ToInt32(CartasRevueltas[Convert.ToInt32(CartaTemporal2.Name) - 1]);
                            if (Carta1 != Carta2)
                            {
                                picCaraSorprendida.Show();
                                picCaraFeliz.Hide();
                            //detenemos el tiempo y volvemos a comenzar si no son iguales
                                SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.error);
                                sndPlayer1.Play();
                                timer1.Enabled = true;
                                timer1.Start();
                                CartaTemporal1.Enabled = true;
                                CartaTemporal2.Enabled = true;
                                contador++;
                                //controlador de vidas
                                if (contador == 1)
                                {
                                    V1.Hide();
                                    V2.Show();
                                    V3.Show();
                                }
                                if (contador == 2)
                                {
                                    V1.Hide();
                                    V2.Hide();
                                    V3.Show();
                                }
                                if (contador == 3)
                                {
                                    V1.Hide();
                                    V2.Hide();
                                    V3.Hide();
                                }
                                //si se equivoca 3 veces
                                if (contador == 3)
                                {
                                    DialogResult resultado = new DialogResult();
                                    Form mensaje = new frmOk();
                                    resultado = mensaje.ShowDialog();
                                    if (resultado == DialogResult.OK)
                                    {
                                        nivel3.Hide();
                                        contador = 0;
                                        CantidadDeCartasVolteadas = 0;
                                        SoundPlayer sndPlayer = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.InicioNivel3);
                                        sndPlayer.Play();
                                        System.Threading.Thread.Sleep(10);
                                        nivel3.Show();
                                        V1.Show();
                                        V2.Show();
                                        V3.Show();
                                        picCaraSorprendida.Hide();
                                    }
                                }
                            }
                            else
                            {
                                if (CartaActual.ToString().Equals("0"))
                                {
                                    SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Oreja);
                                    sndPlayer1.Play();
                                }
                                if (CartaActual.ToString().Equals("1"))
                                {
                                    SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.boca);
                                    sndPlayer1.Play();
                                }
                                if (CartaActual.ToString().Equals("2"))
                                {
                                    SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Brazo);
                                    sndPlayer1.Play();
                                }
                                if (CartaActual.ToString().Equals("3"))
                                {
                                    SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Mano);
                                    sndPlayer1.Play();
                                }
                                if (CartaActual.ToString().Equals("4"))
                                {
                                    SoundPlayer sndPlayer1 = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Nariz);
                                    sndPlayer1.Play();
                                }
                                CantidadDeCartasVolteadas++;
                                picCaraFeliz.Show();
                                picCaraSorprendida.Hide();
                                CartaTemporal1.Enabled = false;
                                CartaTemporal2.Enabled = false;
                                CartasSeleccionadas.Clear();
                                if (CantidadDeCartasVolteadas > 4)
                                {
                                    System.Threading.Thread.Sleep(1600);
                                    SoundPlayer sndPlayer = new SoundPlayer(WinAppParesCuerpo.Properties.Resources.Fin_del_juego);
                                    sndPlayer.Play();
                                    System.Threading.Thread.Sleep(3300);
                                    nivel3.Close();
                                    Application.Exit();
                                }
                            }
                        }
                    }
                } 
        }
    }
}

