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
using ParexasAnxo.RecursosLocalizables;
using System.IO;

namespace ParexasAnxo
{
    public partial class MeuFormulario : Form
    {
        private Partida partida;
        private TableLayoutPanel tablaPanel;
        private ResourceManager myManager;
        private PictureBox cartaSeleccionada, cartaSeleccionada1, cartaSeleccionada2;
        private string lenguaje;
        private int indPrimario =-1, indSecundario=-1;

        //Método principal
        public MeuFormulario()
        {
            InitializeComponent();
            lenguaje = Thread.CurrentThread.CurrentUICulture.Name;
            myManager = new ResourceManager("ParexasAnxo.Properties.Resources", this.GetType().Assembly);
            recuperarDatos();
            iniciarXogo();
        }

        //función novo xogo
        private void btnXogoNovo_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            recuperarDatos();
            iniciarXogo();
        }

        //Método para iniciar o xogo
        public void iniciarXogo()
        {
            partida = new Partida(4, 0, 0);
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
        
        //Configuración do panel de xogo
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

        //Método para baraxar as cartas
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

        //Función de clickar nunha carta
        private void btnCarta_Click(object sender, EventArgs e)
        {
            if (indPrimario == -1 | indSecundario == -1)
            {
                partida.contMovementos++;
                lblMovementosEdit.Text = partida.contMovementos.ToString();

                cartaSeleccionada = (PictureBox)sender;

                CartaLib.ucImaxe ucCartaSeleccionada = (CartaLib.ucImaxe)cartaSeleccionada.Parent;
                int col = tablaPanel.GetCellPosition(ucCartaSeleccionada).Column;
                int row = tablaPanel.GetCellPosition(ucCartaSeleccionada).Row;

                int contPosicion = 0;
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
                        foreach (CartaLib.ucImaxe item in tablaPanel.Controls)
                        {
                            item.Enabled = false;
                        }
                        tTempo.Enabled = true;
                        tTempo.Start();
                        foreach (CartaLib.ucImaxe item in tablaPanel.Controls)
                        {
                            item.Enabled = true;
                        }
                    }
                    else
                    {
                        partida.contCantidadCartasXiradas++;
                        partida.contCantidadCartasXiradas++;
                        cartaSeleccionada1.Enabled = false;
                        cartaSeleccionada2.Enabled = false;
                        indPrimario = -1;
                        indSecundario = -1;

                        if (partida.contCantidadCartasXiradas == 16)
                        {
                            string nomeUsu = Microsoft.VisualBasic.Interaction.InputBox(StringResources.tiganas + "\n\n" + StringResources.teunome, StringResources.tiganas, StringResources.anonimo);
                            if (nomeUsu.CompareTo("") != 0)
                            {
                                guardarMovementos(partida.contMovementos.ToString(), nomeUsu);
                            }

                            DialogResult result = MessageBox.Show(StringResources.desexas, StringResources.fin, MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);


                            if (result == DialogResult.Yes)
                            {
                                btnXogoNovo_Click(null, null);
                            }
                            else
                                Application.Exit();
                        }
                    }
                }
            }
        }

        //Método que da un tempo de espera na comprobación das cartas
        private void tTempo_Tick(object sender, EventArgs e)
        {
            cartaSeleccionada1.Image = (Image)myManager.GetObject(partida.listaCartas[indPrimario].rutaImagenReverso);
            cartaSeleccionada2.Image = (Image)myManager.GetObject(partida.listaCartas[indSecundario].rutaImagenReverso);
            indPrimario = -1;
            indSecundario = -1;
            tTempo.Stop();
        }

        //Opción de saída
        private void mItemSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Cambiar ó tema vermello
        private void mItemTemaVermello_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.IndianRed;
            panelFondo.BackColor = Color.AntiqueWhite;
            lblDatos.BackColor = Color.LightCoral;
        }

        //Cambiar ó tema azul
        private void mItemTemaAzul_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.RoyalBlue;
            panelFondo.BackColor = Color.SkyBlue;
            lblDatos.BackColor = Color.DodgerBlue;
        }

        //Cambiar ó tema Amarelo
        private void mItemAmarelo_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.Gold;
            panelFondo.BackColor = Color.LemonChiffon;
            lblDatos.BackColor = Color.Khaki;
        }

        //Cambiar ó tema Verde
        private void mItemTemaVerde_Click(object sender, EventArgs e)
        {
            lblEncabezado.BackColor = Color.Olive;
            panelFondo.BackColor = Color.YellowGreen;
            lblDatos.BackColor = Color.Olive;
        }

        
        //Mostrar información do autor
        private void mItemAutor_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(StringResources.feitopor + "\n\t" + StringResources.autor + "\n\n" + StringResources.proxecto + "\n" + StringResources.curso, StringResources.infor, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Cambiar o idioma a galego
        private void mItemGalego_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
            this.InitializeComponent();
            iniciarXogo();
        }

        //Cambiar o idioma a español
        private void mItemEspanol_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("es-Es");
            this.InitializeComponent();
            iniciarXogo();
        }

        //Cambiar o idioma a inglés
        private void mItemIngles_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
            this.InitializeComponent();
            iniciarXogo();
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

        //Guardar datos
        private void guardarMovementos(string puntos,string nome)
        {
            if (!File.Exists("Historial.txt"))
            {
                using (StreamWriter sw=new StreamWriter("Historial.txt"))
                {
                    sw.WriteLine(nome+" - "+puntos);
                }
            }else
            {
                using (StreamWriter sw = File.AppendText("Historial.txt"))
                {
                    sw.WriteLine(nome + " - " + puntos);
                }
            }
        }

        //Recuperar datos
        private void recuperarDatos()
        {
            if (File.Exists("Historial.txt"))
            {
                using (StreamReader sr = File.OpenText("Historial.txt"))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        lbPuntuacions.Items.Add(s);
                    }
                }
            }
        }


    }
}
