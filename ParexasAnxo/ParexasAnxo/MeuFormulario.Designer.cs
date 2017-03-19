namespace ParexasAnxo
{
    partial class MeuFormulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeuFormulario));
            this.PanelXogo = new System.Windows.Forms.Panel();
            this.PanelAdicional = new System.Windows.Forms.Panel();
            this.panelBtns = new System.Windows.Forms.Panel();
            this.btnXogoNovo = new System.Windows.Forms.Button();
            this.lblMovementosEdit = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.lblMovementos = new System.Windows.Forms.Label();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tlbVermello = new System.Windows.Forms.ToolStripButton();
            this.tlbAzul = new System.Windows.Forms.ToolStripButton();
            this.tlbAmarelo = new System.Windows.Forms.ToolStripButton();
            this.tlbVerde = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tTempo = new System.Windows.Forms.Timer(this.components);
            this.menu = new System.Windows.Forms.MenuStrip();
            this.mItemXogo = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemNovoXogo = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemIdioma = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemGalego = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemEspanol = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemIngles = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemCambiarTema = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTemaVermello = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTemaAzul = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTemaAmarelo = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemTemaVerde = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemDetalles = new System.Windows.Forms.ToolStripMenuItem();
            this.mItemAutor = new System.Windows.Forms.ToolStripMenuItem();
            this.miToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.PanelAdicional.SuspendLayout();
            this.panelBtns.SuspendLayout();
            this.panelFondo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelXogo
            // 
            resources.ApplyResources(this.PanelXogo, "PanelXogo");
            this.PanelXogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelXogo.Name = "PanelXogo";
            this.miToolTip.SetToolTip(this.PanelXogo, resources.GetString("PanelXogo.ToolTip"));
            // 
            // PanelAdicional
            // 
            resources.ApplyResources(this.PanelAdicional, "PanelAdicional");
            this.PanelAdicional.BackColor = System.Drawing.Color.Transparent;
            this.PanelAdicional.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PanelAdicional.Controls.Add(this.panelBtns);
            this.PanelAdicional.Controls.Add(this.lblMovementosEdit);
            this.PanelAdicional.Controls.Add(this.lblDatos);
            this.PanelAdicional.Controls.Add(this.lblMovementos);
            this.PanelAdicional.Name = "PanelAdicional";
            this.miToolTip.SetToolTip(this.PanelAdicional, resources.GetString("PanelAdicional.ToolTip"));
            // 
            // panelBtns
            // 
            resources.ApplyResources(this.panelBtns, "panelBtns");
            this.panelBtns.Controls.Add(this.btnXogoNovo);
            this.panelBtns.Name = "panelBtns";
            this.miToolTip.SetToolTip(this.panelBtns, resources.GetString("panelBtns.ToolTip"));
            // 
            // btnXogoNovo
            // 
            resources.ApplyResources(this.btnXogoNovo, "btnXogoNovo");
            this.btnXogoNovo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXogoNovo.Name = "btnXogoNovo";
            this.miToolTip.SetToolTip(this.btnXogoNovo, resources.GetString("btnXogoNovo.ToolTip"));
            this.btnXogoNovo.UseVisualStyleBackColor = true;
            this.btnXogoNovo.Click += new System.EventHandler(this.btnXogoNovo_Click);
            // 
            // lblMovementosEdit
            // 
            resources.ApplyResources(this.lblMovementosEdit, "lblMovementosEdit");
            this.lblMovementosEdit.BackColor = System.Drawing.Color.Transparent;
            this.lblMovementosEdit.Name = "lblMovementosEdit";
            this.miToolTip.SetToolTip(this.lblMovementosEdit, resources.GetString("lblMovementosEdit.ToolTip"));
            // 
            // lblDatos
            // 
            resources.ApplyResources(this.lblDatos, "lblDatos");
            this.lblDatos.BackColor = System.Drawing.Color.LightCoral;
            this.lblDatos.Name = "lblDatos";
            this.miToolTip.SetToolTip(this.lblDatos, resources.GetString("lblDatos.ToolTip"));
            // 
            // lblMovementos
            // 
            resources.ApplyResources(this.lblMovementos, "lblMovementos");
            this.lblMovementos.BackColor = System.Drawing.Color.Transparent;
            this.lblMovementos.Name = "lblMovementos";
            this.miToolTip.SetToolTip(this.lblMovementos, resources.GetString("lblMovementos.ToolTip"));
            // 
            // lblEncabezado
            // 
            resources.ApplyResources(this.lblEncabezado, "lblEncabezado");
            this.lblEncabezado.BackColor = System.Drawing.Color.IndianRed;
            this.lblEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEncabezado.Name = "lblEncabezado";
            this.miToolTip.SetToolTip(this.lblEncabezado, resources.GetString("lblEncabezado.ToolTip"));
            // 
            // panelFondo
            // 
            resources.ApplyResources(this.panelFondo, "panelFondo");
            this.panelFondo.AllowDrop = true;
            this.panelFondo.Controls.Add(this.toolStrip1);
            this.panelFondo.Controls.Add(this.PanelXogo);
            this.panelFondo.Controls.Add(this.PanelAdicional);
            this.panelFondo.Name = "panelFondo";
            this.miToolTip.SetToolTip(this.panelFondo, resources.GetString("panelFondo.ToolTip"));
            this.panelFondo.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelFondo_DragDrop);
            this.panelFondo.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelFondo_DragEnter);
            // 
            // toolStrip1
            // 
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator7,
            this.toolStripSeparator5,
            this.toolStripButton1,
            this.toolStripButton3,
            this.toolStripSeparator4,
            this.toolStripSeparator1,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripSeparator2,
            this.tlbVermello,
            this.tlbAzul,
            this.tlbAmarelo,
            this.tlbVerde,
            this.toolStripSeparator6,
            this.toolStripSeparator8});
            this.toolStrip1.Name = "toolStrip1";
            this.miToolTip.SetToolTip(this.toolStrip1, resources.GetString("toolStrip1.ToolTip"));
            // 
            // toolStripSeparator7
            // 
            resources.ApplyResources(this.toolStripSeparator7, "toolStripSeparator7");
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            // 
            // toolStripSeparator5
            // 
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            // 
            // toolStripButton1
            // 
            resources.ApplyResources(this.toolStripButton1, "toolStripButton1");
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::ParexasAnxo.Properties.Resources.novo;
            this.toolStripButton1.Name = "toolStripButton1";
            // 
            // toolStripButton3
            // 
            resources.ApplyResources(this.toolStripButton3, "toolStripButton3");
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::ParexasAnxo.Properties.Resources.sair;
            this.toolStripButton3.Name = "toolStripButton3";
            // 
            // toolStripSeparator4
            // 
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            // 
            // toolStripSeparator1
            // 
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            // 
            // toolStripButton4
            // 
            resources.ApplyResources(this.toolStripButton4, "toolStripButton4");
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = global::ParexasAnxo.Properties.Resources.gl;
            this.toolStripButton4.Name = "toolStripButton4";
            // 
            // toolStripButton5
            // 
            resources.ApplyResources(this.toolStripButton5, "toolStripButton5");
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = global::ParexasAnxo.Properties.Resources.es;
            this.toolStripButton5.Name = "toolStripButton5";
            // 
            // toolStripButton6
            // 
            resources.ApplyResources(this.toolStripButton6, "toolStripButton6");
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = global::ParexasAnxo.Properties.Resources.en;
            this.toolStripButton6.Name = "toolStripButton6";
            // 
            // toolStripSeparator3
            // 
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            // 
            // toolStripSeparator2
            // 
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            // 
            // tlbVermello
            // 
            resources.ApplyResources(this.tlbVermello, "tlbVermello");
            this.tlbVermello.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbVermello.Image = global::ParexasAnxo.Properties.Resources.rojo;
            this.tlbVermello.Name = "tlbVermello";
            this.tlbVermello.Click += new System.EventHandler(this.mItemTemaVermello_Click);
            // 
            // tlbAzul
            // 
            resources.ApplyResources(this.tlbAzul, "tlbAzul");
            this.tlbAzul.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbAzul.Image = global::ParexasAnxo.Properties.Resources.azul;
            this.tlbAzul.Name = "tlbAzul";
            this.tlbAzul.Click += new System.EventHandler(this.mItemTemaAzul_Click);
            // 
            // tlbAmarelo
            // 
            resources.ApplyResources(this.tlbAmarelo, "tlbAmarelo");
            this.tlbAmarelo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbAmarelo.Image = global::ParexasAnxo.Properties.Resources.amarillo;
            this.tlbAmarelo.Name = "tlbAmarelo";
            this.tlbAmarelo.Click += new System.EventHandler(this.mItemAmarelo_Click);
            // 
            // tlbVerde
            // 
            resources.ApplyResources(this.tlbVerde, "tlbVerde");
            this.tlbVerde.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tlbVerde.Image = global::ParexasAnxo.Properties.Resources.verde;
            this.tlbVerde.Name = "tlbVerde";
            this.tlbVerde.Click += new System.EventHandler(this.mItemTemaVerde_Click);
            // 
            // toolStripSeparator6
            // 
            resources.ApplyResources(this.toolStripSeparator6, "toolStripSeparator6");
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            // 
            // toolStripSeparator8
            // 
            resources.ApplyResources(this.toolStripSeparator8, "toolStripSeparator8");
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            // 
            // tTempo
            // 
            this.tTempo.Interval = 500;
            this.tTempo.Tick += new System.EventHandler(this.tTempo_Tick);
            // 
            // menu
            // 
            resources.ApplyResources(this.menu, "menu");
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemXogo,
            this.mItemIdioma,
            this.mItemEditar,
            this.mItemDetalles});
            this.menu.Name = "menu";
            this.miToolTip.SetToolTip(this.menu, resources.GetString("menu.ToolTip"));
            // 
            // mItemXogo
            // 
            resources.ApplyResources(this.mItemXogo, "mItemXogo");
            this.mItemXogo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemNovoXogo,
            this.mItemSair});
            this.mItemXogo.Name = "mItemXogo";
            // 
            // mItemNovoXogo
            // 
            resources.ApplyResources(this.mItemNovoXogo, "mItemNovoXogo");
            this.mItemNovoXogo.Name = "mItemNovoXogo";
            this.mItemNovoXogo.Click += new System.EventHandler(this.btnXogoNovo_Click);
            // 
            // mItemSair
            // 
            resources.ApplyResources(this.mItemSair, "mItemSair");
            this.mItemSair.Name = "mItemSair";
            this.mItemSair.Click += new System.EventHandler(this.mItemSair_Click);
            // 
            // mItemIdioma
            // 
            resources.ApplyResources(this.mItemIdioma, "mItemIdioma");
            this.mItemIdioma.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemGalego,
            this.mItemEspanol,
            this.mItemIngles});
            this.mItemIdioma.Name = "mItemIdioma";
            // 
            // mItemGalego
            // 
            resources.ApplyResources(this.mItemGalego, "mItemGalego");
            this.mItemGalego.Name = "mItemGalego";
            this.mItemGalego.Click += new System.EventHandler(this.mItemGalego_Click);
            // 
            // mItemEspanol
            // 
            resources.ApplyResources(this.mItemEspanol, "mItemEspanol");
            this.mItemEspanol.Name = "mItemEspanol";
            this.mItemEspanol.Click += new System.EventHandler(this.mItemEspanol_Click);
            // 
            // mItemIngles
            // 
            resources.ApplyResources(this.mItemIngles, "mItemIngles");
            this.mItemIngles.Name = "mItemIngles";
            this.mItemIngles.Click += new System.EventHandler(this.mItemIngles_Click);
            // 
            // mItemEditar
            // 
            resources.ApplyResources(this.mItemEditar, "mItemEditar");
            this.mItemEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemCambiarTema});
            this.mItemEditar.Name = "mItemEditar";
            // 
            // mItemCambiarTema
            // 
            resources.ApplyResources(this.mItemCambiarTema, "mItemCambiarTema");
            this.mItemCambiarTema.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemTemaVermello,
            this.mItemTemaAzul,
            this.mItemTemaAmarelo,
            this.mItemTemaVerde});
            this.mItemCambiarTema.Name = "mItemCambiarTema";
            // 
            // mItemTemaVermello
            // 
            resources.ApplyResources(this.mItemTemaVermello, "mItemTemaVermello");
            this.mItemTemaVermello.Name = "mItemTemaVermello";
            this.mItemTemaVermello.Click += new System.EventHandler(this.mItemTemaVermello_Click);
            // 
            // mItemTemaAzul
            // 
            resources.ApplyResources(this.mItemTemaAzul, "mItemTemaAzul");
            this.mItemTemaAzul.Name = "mItemTemaAzul";
            this.mItemTemaAzul.Click += new System.EventHandler(this.mItemTemaAzul_Click);
            // 
            // mItemTemaAmarelo
            // 
            resources.ApplyResources(this.mItemTemaAmarelo, "mItemTemaAmarelo");
            this.mItemTemaAmarelo.Name = "mItemTemaAmarelo";
            this.mItemTemaAmarelo.Click += new System.EventHandler(this.mItemAmarelo_Click);
            // 
            // mItemTemaVerde
            // 
            resources.ApplyResources(this.mItemTemaVerde, "mItemTemaVerde");
            this.mItemTemaVerde.Name = "mItemTemaVerde";
            this.mItemTemaVerde.Click += new System.EventHandler(this.mItemTemaVerde_Click);
            // 
            // mItemDetalles
            // 
            resources.ApplyResources(this.mItemDetalles, "mItemDetalles");
            this.mItemDetalles.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mItemAutor});
            this.mItemDetalles.Name = "mItemDetalles";
            // 
            // mItemAutor
            // 
            resources.ApplyResources(this.mItemAutor, "mItemAutor");
            this.mItemAutor.Name = "mItemAutor";
            this.mItemAutor.Click += new System.EventHandler(this.mItemAutor_Click);
            // 
            // MeuFormulario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.lblEncabezado);
            this.Controls.Add(this.menu);
            this.MainMenuStrip = this.menu;
            this.Name = "MeuFormulario";
            this.miToolTip.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.PanelAdicional.ResumeLayout(false);
            this.panelBtns.ResumeLayout(false);
            this.panelFondo.ResumeLayout(false);
            this.panelFondo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelXogo;
        private System.Windows.Forms.Panel PanelAdicional;
        private System.Windows.Forms.Label lblEncabezado;
        private System.Windows.Forms.Panel panelFondo;
        private System.Windows.Forms.Label lblMovementos;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.Label lblMovementosEdit;
        private System.Windows.Forms.Button btnXogoNovo;
        private System.Windows.Forms.Panel panelBtns;
        private System.Windows.Forms.Timer tTempo;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem mItemXogo;
        private System.Windows.Forms.ToolStripMenuItem mItemNovoXogo;
        private System.Windows.Forms.ToolStripMenuItem mItemSair;
        private System.Windows.Forms.ToolStripMenuItem mItemIdioma;
        private System.Windows.Forms.ToolStripMenuItem mItemGalego;
        private System.Windows.Forms.ToolStripMenuItem mItemEspanol;
        private System.Windows.Forms.ToolStripMenuItem mItemIngles;
        private System.Windows.Forms.ToolStripMenuItem mItemEditar;
        private System.Windows.Forms.ToolStripMenuItem mItemCambiarTema;
        private System.Windows.Forms.ToolStripMenuItem mItemTemaVermello;
        private System.Windows.Forms.ToolStripMenuItem mItemTemaAzul;
        private System.Windows.Forms.ToolStripMenuItem mItemTemaAmarelo;
        private System.Windows.Forms.ToolStripMenuItem mItemTemaVerde;
        private System.Windows.Forms.ToolStripMenuItem mItemDetalles;
        private System.Windows.Forms.ToolStripMenuItem mItemAutor;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tlbVermello;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tlbAzul;
        private System.Windows.Forms.ToolStripButton tlbAmarelo;
        private System.Windows.Forms.ToolStripButton tlbVerde;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolTip miToolTip;
    }
}

