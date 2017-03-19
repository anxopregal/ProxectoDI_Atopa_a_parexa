using ParexasAnxo.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Resources;
using System.Threading;
using System.Globalization;

namespace ParexasAnxo
{
    public partial class MeuFormulario : Form
    {
         Partida partida;
         TableLayoutPanel tablaPanel;
         ResourceManager myManager;
         int indPrimario=-1, indSecundario=-1;
         PictureBox cartaSeleccionada, cartaSeleccionada1, cartaSeleccionada2;

        //Método principal
        public MeuFormulario()
        {
            InitializeComponent();
            partida = new Partida(4, 0, 0);//tamañoTableiro,movementos,CartasXiradas
            myManager = new ResourceManager("ParexasAnxo.Properties.Resources", this.GetType().Assembly);
            iniciarXogo();
        }

        private void btnXogoNovo_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            lblMovementosEdit.Text = "0";
            partida = new Partida(4, 0, 0);
            iniciarXogo();
        }


        public void iniciarXogo()
        {
            cargarCartasMemoria();
            baraxarCartas();
            configPanelXogo();
            
            //Carga os meus user controls no taboleiro
            int contadorFichas = 0;
            for (var i = 0; i < partida.tamanoColFil; i++)
            {
                for (var j = 0; j < partida.tamanoColFil; j++)
                {
                    CartaLib.ucImaxe uc = new CartaLib.ucImaxe();
                    PictureBox pb= uc.getImaxe();
                    pb.Dock = DockStyle.Fill;
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = (Image)myManager.GetObject(partida.listaCartas[contadorFichas].rutaImagenReverso);
                    uc.getImaxe().Click+= new System.EventHandler(this.btnCarta_Click);
                    tablaPanel.Controls.Add(uc,j,i);
                    contadorFichas++;
                }
            }
           
            tablaPanel.Dock = DockStyle.Fill;
            PanelXogo.Controls.Add(tablaPanel);
        }

        ///Carga las cartas en memoria 
        private void cargarCartasMemoria()
        {
            for (int i = 0; i < partida.tamanoColFil+partida.tamanoColFil; i++)
            {
                partida.listaCartas.Add(new Carta(i, "reverso", "imagen" + (i + 1)));
                partida.listaCartas.Add(new Carta(i, "reverso", "imagen" + (i + 1)));
            }
        }
        
        private void configPanelXogo()
        {
            //Creo o panel de xogo
            tablaPanel = new TableLayoutPanel();
            tablaPanel.RowCount = partida.tamanoColFil;
            tablaPanel.ColumnCount = partida.tamanoColFil;
            //Ajusto o contido o panel
            for (int i = 0; i < partida.tamanoColFil; i++)
            {
                var Porcentaje = 150f / (float)partida.tamanoColFil - 10;
                tablaPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, Porcentaje));
                tablaPanel.RowStyles.Add(new RowStyle(SizeType.Percent, Porcentaje));
            }
        }        

        private void baraxarCartas()
        {
            Random NumeroAleatorio = new Random();
            IOrderedEnumerable<Carta> Resultado = partida.listaCartas.OrderBy(item => NumeroAleatorio.Next());
            List<Carta> cartasBaraxadas = new List<Carta>();
            foreach (var ValorCarta in Resultado)
            {
                cartasBaraxadas.Add(ValorCarta);
            }
            partida.listaCartas.Clear();
            partida.listaCartas.AddRange(cartasBaraxadas);
        }

        private void btnCarta_Click(object sender, EventArgs e)
        {
            partida.contMovementos++;
            lblMovementosEdit.Text = partida.contMovementos.ToString();

            cartaSeleccionada = (PictureBox)sender;

            CartaLib.ucImaxe ucCartaSeleccionada = (CartaLib.ucImaxe)cartaSeleccionada.Parent;
            int col = tablaPanel.GetCellPosition(ucCartaSeleccionada).Column;
            int row = tablaPanel.GetCellPosition(ucCartaSeleccionada).Row;

            int contPosicion=0;
            switch (row)
            {
                case 0:
                    row = row + 1;
                    break;
                case 1:
                    row = row + 4;
                    break;
                case 2:
                    row = row + 7;
                    break;
                case 3:
                    row = row + 10;
                    break;
                default:
                    break;
            }
            contPosicion = row + col;

            cartaSeleccionada.Image = (Image)myManager.GetObject(partida.listaCartas[contPosicion - 1].rutaImagen);

            //guardo el primer índice pulsado
            if (indPrimario == -1)
            {
                indPrimario = contPosicion - 1;
                cartaSeleccionada1 = cartaSeleccionada;
            }
            else
            {
                indSecundario = contPosicion - 1;
                cartaSeleccionada2 = cartaSeleccionada;
                if (indPrimario == indSecundario)
                {

                    cartaSeleccionada1.Image = (Image)myManager.GetObject(partida.listaCartas[indPrimario].rutaImagenReverso);
                    cartaSeleccionada2.Image = (Image)myManager.GetObject(partida.listaCartas[indSecundario].rutaImagenReverso);
                    indPrimario = -1;
                    indSecundario = -1;

                }
                else if (partida.listaCartas[indPrimario].idCarta != partida.listaCartas[indSecundario].idCarta)
                {
                    tTempo.Enabled = true;
                    tTempo.Start();
                }
                else
                {
                    partida.contCantidadCartasXiradas++;
                    partida.contCantidadCartasXiradas++;
                    indPrimario = -1;
                    indSecundario = -1;

                    if (partida.contCantidadCartasXiradas == 16)
                    {
                        DialogResult result= MessageBox.Show("Ti gañas\nDesexas xogar outra partida?", "FIN DO XOGO", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

                        if (result == DialogResult.Yes)
                        {
                            btnXogoNovo_Click(null, null);
                        }else
                            Application.Exit();
                    }
                }
            }
        }

        //Método que da un tiempo de espera en la comprobación de las cartas
        private void tTempo_Tick(object sender, EventArgs e)
        {
            cartaSeleccionada1.Image = (Image)myManager.GetObject(partida.listaCartas[indPrimario].rutaImagenReverso);
            cartaSeleccionada2.Image = (Image)myManager.GetObject(partida.listaCartas[indSecundario].rutaImagenReverso);
            indPrimario = -1;
            indSecundario = -1;
            tTempo.Stop();
        }

        //Opcións menú
        private void mItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mItemTemaVermello_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.IndianRed;
            panelFondo.BackColor = Color.AntiqueWhite;
            lblDatos.BackColor = Color.LightCoral;
        }

        private void mItemTemaAzul_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.RoyalBlue;
            panelFondo.BackColor = Color.SkyBlue;
            lblDatos.BackColor = Color.DodgerBlue;
        }

        private void mItemAmarelo_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.Gold;
            panelFondo.BackColor = Color.LemonChiffon;
            lblDatos.BackColor = Color.Khaki;
        }

        private void mItemTemaVerde_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.Olive;
            panelFondo.BackColor = Color.YellowGreen;
            lblDatos.BackColor = Color.Olive;
        }

        

        private void mItemAutor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Feito por: Anxo Pregal\nProxecto DI\nCurso 16/17", "Créditos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mItemGalego_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            this.InitializeComponent();
        }

        private void mItemEspanol_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-Es");
            this.InitializeComponent();
        }

        private void mItemIngles_Click(object sender, EventArgs e)
        {

        }

        //Drag&Drop
        private void panelFondo_DragDrop(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panelFondo_DragEnter(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            panelFondo.BackgroundImage = Image.FromFile(files[0]);
        }


    }
}
