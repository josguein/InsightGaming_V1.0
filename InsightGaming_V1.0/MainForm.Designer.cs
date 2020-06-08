namespace InsightGaming_V1._0
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btLogin = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pbMinimizar = new System.Windows.Forms.PictureBox();
            this.pbCerrar = new System.Windows.Forms.PictureBox();
            this.pbRestaurar = new System.Windows.Forms.PictureBox();
            this.pbMaximizar = new System.Windows.Forms.PictureBox();
            this.laBienvenida = new System.Windows.Forms.Label();
            this.pnlOptions = new System.Windows.Forms.Panel();
            this.pnCarrito = new System.Windows.Forms.Panel();
            this.laCantidadCarrito = new System.Windows.Forms.Label();
            this.laCantidaddeProductos = new System.Windows.Forms.Label();
            this.btCarritoFinalizarCompra = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.laPuntos = new System.Windows.Forms.Label();
            this.laNombreUsuario = new System.Windows.Forms.Label();
            this.pbImagenUsuario = new System.Windows.Forms.PictureBox();
            this.laRegistradoComo = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btIniciarSesion = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btLogOut = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btOpcionesUsuario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btCarrito = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btProductos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btInicio = new System.Windows.Forms.Button();
            this.pbLetrero = new System.Windows.Forms.PictureBox();
            this.pnlContenido = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.rbtDescendente = new System.Windows.Forms.CheckBox();
            this.rbtLanzamiento = new System.Windows.Forms.RadioButton();
            this.rbtAñadido = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.rbtRating = new System.Windows.Forms.RadioButton();
            this.laOrdenarMainform = new System.Windows.Forms.Label();
            this.RbtIndie = new System.Windows.Forms.RadioButton();
            this.RbtEstrategia = new System.Windows.Forms.RadioButton();
            this.RbtSimulador = new System.Windows.Forms.RadioButton();
            this.RbtAventura = new System.Windows.Forms.RadioButton();
            this.RbtDeportes = new System.Windows.Forms.RadioButton();
            this.RbtShooter = new System.Windows.Forms.RadioButton();
            this.RbtRpg = new System.Windows.Forms.RadioButton();
            this.RbtAccion = new System.Windows.Forms.RadioButton();
            this.dgwProductosDestacados = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bd_gaminginsightDataSet1 = new InsightGaming_V1._0.bd_gaminginsightDataSet();
            this.bd_gaminginsightDataSet2 = new InsightGaming_V1._0.bd_gaminginsightDataSet();
            this.pnlButtons.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).BeginInit();
            this.pnlOptions.SuspendLayout();
            this.pnCarrito.SuspendLayout();
            this.panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrero)).BeginInit();
            this.pnlContenido.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductosDestacados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Location = new System.Drawing.Point(362, 314);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(75, 23);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pnlButtons
            // 
            this.pnlButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(150)))));
            this.pnlButtons.Controls.Add(this.panel7);
            this.pnlButtons.Controls.Add(this.laBienvenida);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1200, 26);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseDown);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.pbMinimizar);
            this.panel7.Controls.Add(this.pbCerrar);
            this.panel7.Controls.Add(this.pbRestaurar);
            this.panel7.Controls.Add(this.pbMaximizar);
            this.panel7.Location = new System.Drawing.Point(1105, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(95, 25);
            this.panel7.TabIndex = 0;
            // 
            // pbMinimizar
            // 
            this.pbMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimizar.Image")));
            this.pbMinimizar.Location = new System.Drawing.Point(8, 2);
            this.pbMinimizar.Name = "pbMinimizar";
            this.pbMinimizar.Size = new System.Drawing.Size(24, 20);
            this.pbMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMinimizar.TabIndex = 0;
            this.pbMinimizar.TabStop = false;
            this.pbMinimizar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pbCerrar
            // 
            this.pbCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCerrar.Image = ((System.Drawing.Image)(resources.GetObject("pbCerrar.Image")));
            this.pbCerrar.Location = new System.Drawing.Point(68, 2);
            this.pbCerrar.Name = "pbCerrar";
            this.pbCerrar.Size = new System.Drawing.Size(24, 20);
            this.pbCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbCerrar.TabIndex = 2;
            this.pbCerrar.TabStop = false;
            this.pbCerrar.Click += new System.EventHandler(this.pbCerrar_Click);
            // 
            // pbRestaurar
            // 
            this.pbRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("pbRestaurar.Image")));
            this.pbRestaurar.Location = new System.Drawing.Point(38, 2);
            this.pbRestaurar.Name = "pbRestaurar";
            this.pbRestaurar.Size = new System.Drawing.Size(24, 20);
            this.pbRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbRestaurar.TabIndex = 3;
            this.pbRestaurar.TabStop = false;
            this.pbRestaurar.Visible = false;
            this.pbRestaurar.Click += new System.EventHandler(this.pbRestaurar_Click);
            // 
            // pbMaximizar
            // 
            this.pbMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("pbMaximizar.Image")));
            this.pbMaximizar.Location = new System.Drawing.Point(38, 2);
            this.pbMaximizar.Name = "pbMaximizar";
            this.pbMaximizar.Size = new System.Drawing.Size(24, 20);
            this.pbMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMaximizar.TabIndex = 1;
            this.pbMaximizar.TabStop = false;
            this.pbMaximizar.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // laBienvenida
            // 
            this.laBienvenida.AutoSize = true;
            this.laBienvenida.Font = new System.Drawing.Font("Arial", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laBienvenida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.laBienvenida.Location = new System.Drawing.Point(277, 3);
            this.laBienvenida.Name = "laBienvenida";
            this.laBienvenida.Size = new System.Drawing.Size(0, 19);
            this.laBienvenida.TabIndex = 4;
            // 
            // pnlOptions
            // 
            this.pnlOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.pnlOptions.Controls.Add(this.pnCarrito);
            this.pnlOptions.Controls.Add(this.panel9);
            this.pnlOptions.Controls.Add(this.panel6);
            this.pnlOptions.Controls.Add(this.btIniciarSesion);
            this.pnlOptions.Controls.Add(this.panel5);
            this.pnlOptions.Controls.Add(this.btLogOut);
            this.pnlOptions.Controls.Add(this.panel4);
            this.pnlOptions.Controls.Add(this.btOpcionesUsuario);
            this.pnlOptions.Controls.Add(this.panel3);
            this.pnlOptions.Controls.Add(this.btCarrito);
            this.pnlOptions.Controls.Add(this.panel2);
            this.pnlOptions.Controls.Add(this.btProductos);
            this.pnlOptions.Controls.Add(this.panel1);
            this.pnlOptions.Controls.Add(this.btInicio);
            this.pnlOptions.Controls.Add(this.pbLetrero);
            this.pnlOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlOptions.Location = new System.Drawing.Point(0, 26);
            this.pnlOptions.Name = "pnlOptions";
            this.pnlOptions.Size = new System.Drawing.Size(330, 424);
            this.pnlOptions.TabIndex = 2;
            this.pnlOptions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseDown);
            // 
            // pnCarrito
            // 
            this.pnCarrito.Controls.Add(this.laCantidadCarrito);
            this.pnCarrito.Controls.Add(this.laCantidaddeProductos);
            this.pnCarrito.Controls.Add(this.btCarritoFinalizarCompra);
            this.pnCarrito.Location = new System.Drawing.Point(3, 193);
            this.pnCarrito.Name = "pnCarrito";
            this.pnCarrito.Size = new System.Drawing.Size(327, 32);
            this.pnCarrito.TabIndex = 14;
            // 
            // laCantidadCarrito
            // 
            this.laCantidadCarrito.AutoSize = true;
            this.laCantidadCarrito.Dock = System.Windows.Forms.DockStyle.Right;
            this.laCantidadCarrito.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laCantidadCarrito.Location = new System.Drawing.Point(327, 0);
            this.laCantidadCarrito.Name = "laCantidadCarrito";
            this.laCantidadCarrito.Size = new System.Drawing.Size(0, 29);
            this.laCantidadCarrito.TabIndex = 8;
            // 
            // laCantidaddeProductos
            // 
            this.laCantidaddeProductos.AutoSize = true;
            this.laCantidaddeProductos.Location = new System.Drawing.Point(202, 10);
            this.laCantidaddeProductos.Name = "laCantidaddeProductos";
            this.laCantidaddeProductos.Size = new System.Drawing.Size(0, 13);
            this.laCantidaddeProductos.TabIndex = 7;
            // 
            // btCarritoFinalizarCompra
            // 
            this.btCarritoFinalizarCompra.FlatAppearance.BorderSize = 0;
            this.btCarritoFinalizarCompra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btCarritoFinalizarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarritoFinalizarCompra.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarritoFinalizarCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.btCarritoFinalizarCompra.Location = new System.Drawing.Point(0, 0);
            this.btCarritoFinalizarCompra.Name = "btCarritoFinalizarCompra";
            this.btCarritoFinalizarCompra.Size = new System.Drawing.Size(285, 35);
            this.btCarritoFinalizarCompra.TabIndex = 6;
            this.btCarritoFinalizarCompra.Text = "Carrito";
            this.btCarritoFinalizarCompra.UseVisualStyleBackColor = true;
            this.btCarritoFinalizarCompra.Click += new System.EventHandler(this.btCarritoFinalizarCompra_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.laPuntos);
            this.panel9.Controls.Add(this.laNombreUsuario);
            this.panel9.Controls.Add(this.pbImagenUsuario);
            this.panel9.Controls.Add(this.laRegistradoComo);
            this.panel9.Location = new System.Drawing.Point(3, 310);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(327, 114);
            this.panel9.TabIndex = 13;
            // 
            // laPuntos
            // 
            this.laPuntos.AutoSize = true;
            this.laPuntos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laPuntos.ForeColor = System.Drawing.Color.DimGray;
            this.laPuntos.Location = new System.Drawing.Point(13, 48);
            this.laPuntos.Name = "laPuntos";
            this.laPuntos.Size = new System.Drawing.Size(0, 20);
            this.laPuntos.TabIndex = 3;
            // 
            // laNombreUsuario
            // 
            this.laNombreUsuario.AutoSize = true;
            this.laNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laNombreUsuario.ForeColor = System.Drawing.Color.DimGray;
            this.laNombreUsuario.Location = new System.Drawing.Point(9, 14);
            this.laNombreUsuario.Name = "laNombreUsuario";
            this.laNombreUsuario.Size = new System.Drawing.Size(0, 20);
            this.laNombreUsuario.TabIndex = 2;
            // 
            // pbImagenUsuario
            // 
            this.pbImagenUsuario.Location = new System.Drawing.Point(205, 3);
            this.pbImagenUsuario.Name = "pbImagenUsuario";
            this.pbImagenUsuario.Size = new System.Drawing.Size(122, 108);
            this.pbImagenUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenUsuario.TabIndex = 1;
            this.pbImagenUsuario.TabStop = false;
            // 
            // laRegistradoComo
            // 
            this.laRegistradoComo.AutoSize = true;
            this.laRegistradoComo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laRegistradoComo.ForeColor = System.Drawing.Color.DimGray;
            this.laRegistradoComo.Location = new System.Drawing.Point(3, 9);
            this.laRegistradoComo.Name = "laRegistradoComo";
            this.laRegistradoComo.Size = new System.Drawing.Size(0, 20);
            this.laRegistradoComo.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel6.Location = new System.Drawing.Point(0, 269);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 32);
            this.panel6.TabIndex = 12;
            // 
            // btIniciarSesion
            // 
            this.btIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btIniciarSesion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btIniciarSesion.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btIniciarSesion.ForeColor = System.Drawing.SystemColors.Control;
            this.btIniciarSesion.Location = new System.Drawing.Point(3, 269);
            this.btIniciarSesion.Name = "btIniciarSesion";
            this.btIniciarSesion.Size = new System.Drawing.Size(327, 32);
            this.btIniciarSesion.TabIndex = 11;
            this.btIniciarSesion.Text = "Iniciar Sesion";
            this.btIniciarSesion.UseVisualStyleBackColor = true;
            this.btIniciarSesion.Click += new System.EventHandler(this.btIniciarSesion_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel5.Location = new System.Drawing.Point(0, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 32);
            this.panel5.TabIndex = 10;
            // 
            // btLogOut
            // 
            this.btLogOut.FlatAppearance.BorderSize = 0;
            this.btLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogOut.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogOut.ForeColor = System.Drawing.SystemColors.Control;
            this.btLogOut.Location = new System.Drawing.Point(3, 272);
            this.btLogOut.Name = "btLogOut";
            this.btLogOut.Size = new System.Drawing.Size(327, 32);
            this.btLogOut.TabIndex = 9;
            this.btLogOut.Text = "LogOut";
            this.btLogOut.UseVisualStyleBackColor = true;
            this.btLogOut.Visible = false;
            this.btLogOut.Click += new System.EventHandler(this.btLogOut_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel4.Location = new System.Drawing.Point(0, 234);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 32);
            this.panel4.TabIndex = 8;
            // 
            // btOpcionesUsuario
            // 
            this.btOpcionesUsuario.FlatAppearance.BorderSize = 0;
            this.btOpcionesUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btOpcionesUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpcionesUsuario.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpcionesUsuario.ForeColor = System.Drawing.SystemColors.Control;
            this.btOpcionesUsuario.Location = new System.Drawing.Point(3, 234);
            this.btOpcionesUsuario.Name = "btOpcionesUsuario";
            this.btOpcionesUsuario.Size = new System.Drawing.Size(327, 32);
            this.btOpcionesUsuario.TabIndex = 7;
            this.btOpcionesUsuario.Text = "Opciones";
            this.btOpcionesUsuario.UseVisualStyleBackColor = true;
            this.btOpcionesUsuario.Click += new System.EventHandler(this.btOpcionesUsuario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(0, 196);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 32);
            this.panel3.TabIndex = 6;
            // 
            // btCarrito
            // 
            this.btCarrito.FlatAppearance.BorderSize = 0;
            this.btCarrito.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btCarrito.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCarrito.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCarrito.ForeColor = System.Drawing.SystemColors.Control;
            this.btCarrito.Location = new System.Drawing.Point(3, 196);
            this.btCarrito.Name = "btCarrito";
            this.btCarrito.Size = new System.Drawing.Size(327, 32);
            this.btCarrito.TabIndex = 5;
            this.btCarrito.Text = "Carrito";
            this.btCarrito.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel2.Location = new System.Drawing.Point(0, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(5, 32);
            this.panel2.TabIndex = 4;
            // 
            // btProductos
            // 
            this.btProductos.FlatAppearance.BorderSize = 0;
            this.btProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btProductos.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProductos.ForeColor = System.Drawing.SystemColors.Control;
            this.btProductos.Location = new System.Drawing.Point(3, 161);
            this.btProductos.Name = "btProductos";
            this.btProductos.Size = new System.Drawing.Size(327, 32);
            this.btProductos.TabIndex = 3;
            this.btProductos.Text = "Productos";
            this.btProductos.UseVisualStyleBackColor = true;
            this.btProductos.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 32);
            this.panel1.TabIndex = 2;
            // 
            // btInicio
            // 
            this.btInicio.FlatAppearance.BorderSize = 0;
            this.btInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(80)))), ((int)(((byte)(200)))));
            this.btInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInicio.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInicio.ForeColor = System.Drawing.SystemColors.Control;
            this.btInicio.Location = new System.Drawing.Point(3, 123);
            this.btInicio.Name = "btInicio";
            this.btInicio.Size = new System.Drawing.Size(327, 32);
            this.btInicio.TabIndex = 1;
            this.btInicio.Text = "Inicio";
            this.btInicio.UseVisualStyleBackColor = true;
            // 
            // pbLetrero
            // 
            this.pbLetrero.Location = new System.Drawing.Point(0, 0);
            this.pbLetrero.Name = "pbLetrero";
            this.pbLetrero.Size = new System.Drawing.Size(330, 117);
            this.pbLetrero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLetrero.TabIndex = 0;
            this.pbLetrero.TabStop = false;
            this.pbLetrero.Click += new System.EventHandler(this.pbLetrero_Click);
            this.pbLetrero.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseDown);
            // 
            // pnlContenido
            // 
            this.pnlContenido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(66)))), ((int)(((byte)(82)))));
            this.pnlContenido.Controls.Add(this.panel8);
            this.pnlContenido.Controls.Add(this.RbtIndie);
            this.pnlContenido.Controls.Add(this.RbtEstrategia);
            this.pnlContenido.Controls.Add(this.RbtSimulador);
            this.pnlContenido.Controls.Add(this.RbtAventura);
            this.pnlContenido.Controls.Add(this.RbtDeportes);
            this.pnlContenido.Controls.Add(this.RbtShooter);
            this.pnlContenido.Controls.Add(this.RbtRpg);
            this.pnlContenido.Controls.Add(this.RbtAccion);
            this.pnlContenido.Controls.Add(this.dgwProductosDestacados);
            this.pnlContenido.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContenido.Location = new System.Drawing.Point(330, 26);
            this.pnlContenido.Name = "pnlContenido";
            this.pnlContenido.Size = new System.Drawing.Size(870, 424);
            this.pnlContenido.TabIndex = 3;
            this.pnlContenido.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlButtons_MouseDown);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.rbtDescendente);
            this.panel8.Controls.Add(this.rbtLanzamiento);
            this.panel8.Controls.Add(this.rbtAñadido);
            this.panel8.Controls.Add(this.rbtNombre);
            this.panel8.Controls.Add(this.rbtRating);
            this.panel8.Controls.Add(this.laOrdenarMainform);
            this.panel8.Location = new System.Drawing.Point(452, 17);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(385, 89);
            this.panel8.TabIndex = 10;
            // 
            // rbtDescendente
            // 
            this.rbtDescendente.AutoSize = true;
            this.rbtDescendente.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtDescendente.Location = new System.Drawing.Point(254, 27);
            this.rbtDescendente.Name = "rbtDescendente";
            this.rbtDescendente.Size = new System.Drawing.Size(106, 21);
            this.rbtDescendente.TabIndex = 5;
            this.rbtDescendente.Text = "Descendente";
            this.rbtDescendente.UseVisualStyleBackColor = true;
            this.rbtDescendente.CheckedChanged += new System.EventHandler(this.rbtRating_CheckedChanged);
            // 
            // rbtLanzamiento
            // 
            this.rbtLanzamiento.AutoSize = true;
            this.rbtLanzamiento.Location = new System.Drawing.Point(110, 55);
            this.rbtLanzamiento.Name = "rbtLanzamiento";
            this.rbtLanzamiento.Size = new System.Drawing.Size(133, 17);
            this.rbtLanzamiento.TabIndex = 4;
            this.rbtLanzamiento.TabStop = true;
            this.rbtLanzamiento.Text = "Fecha de Lanzamiento";
            this.rbtLanzamiento.UseVisualStyleBackColor = true;
            this.rbtLanzamiento.CheckedChanged += new System.EventHandler(this.rbtRating_CheckedChanged);
            // 
            // rbtAñadido
            // 
            this.rbtAñadido.AutoSize = true;
            this.rbtAñadido.Location = new System.Drawing.Point(110, 27);
            this.rbtAñadido.Name = "rbtAñadido";
            this.rbtAñadido.Size = new System.Drawing.Size(68, 17);
            this.rbtAñadido.TabIndex = 3;
            this.rbtAñadido.TabStop = true;
            this.rbtAñadido.Text = "Duracion";
            this.rbtAñadido.UseVisualStyleBackColor = true;
            this.rbtAñadido.CheckedChanged += new System.EventHandler(this.rbtRating_CheckedChanged);
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Location = new System.Drawing.Point(19, 54);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(62, 17);
            this.rbtNombre.TabIndex = 2;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            this.rbtNombre.CheckedChanged += new System.EventHandler(this.rbtRating_CheckedChanged);
            // 
            // rbtRating
            // 
            this.rbtRating.AutoSize = true;
            this.rbtRating.Location = new System.Drawing.Point(19, 27);
            this.rbtRating.Name = "rbtRating";
            this.rbtRating.Size = new System.Drawing.Size(56, 17);
            this.rbtRating.TabIndex = 1;
            this.rbtRating.TabStop = true;
            this.rbtRating.Text = "Rating";
            this.rbtRating.UseVisualStyleBackColor = true;
            this.rbtRating.CheckedChanged += new System.EventHandler(this.rbtRating_CheckedChanged);
            // 
            // laOrdenarMainform
            // 
            this.laOrdenarMainform.AutoSize = true;
            this.laOrdenarMainform.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laOrdenarMainform.ForeColor = System.Drawing.Color.DimGray;
            this.laOrdenarMainform.Location = new System.Drawing.Point(158, 4);
            this.laOrdenarMainform.Name = "laOrdenarMainform";
            this.laOrdenarMainform.Size = new System.Drawing.Size(81, 17);
            this.laOrdenarMainform.TabIndex = 0;
            this.laOrdenarMainform.Text = "Ordenar Por";
            // 
            // RbtIndie
            // 
            this.RbtIndie.AutoSize = true;
            this.RbtIndie.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtIndie.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtIndie.Location = new System.Drawing.Point(283, 68);
            this.RbtIndie.Name = "RbtIndie";
            this.RbtIndie.Size = new System.Drawing.Size(57, 21);
            this.RbtIndie.TabIndex = 9;
            this.RbtIndie.TabStop = true;
            this.RbtIndie.Text = "Indie";
            this.RbtIndie.UseVisualStyleBackColor = true;
            this.RbtIndie.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtEstrategia
            // 
            this.RbtEstrategia.AutoSize = true;
            this.RbtEstrategia.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtEstrategia.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtEstrategia.Location = new System.Drawing.Point(283, 17);
            this.RbtEstrategia.Name = "RbtEstrategia";
            this.RbtEstrategia.Size = new System.Drawing.Size(87, 21);
            this.RbtEstrategia.TabIndex = 8;
            this.RbtEstrategia.TabStop = true;
            this.RbtEstrategia.Text = "Estrategia";
            this.RbtEstrategia.UseVisualStyleBackColor = true;
            this.RbtEstrategia.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtSimulador
            // 
            this.RbtSimulador.AutoSize = true;
            this.RbtSimulador.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtSimulador.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtSimulador.Location = new System.Drawing.Point(192, 68);
            this.RbtSimulador.Name = "RbtSimulador";
            this.RbtSimulador.Size = new System.Drawing.Size(94, 21);
            this.RbtSimulador.TabIndex = 7;
            this.RbtSimulador.TabStop = true;
            this.RbtSimulador.Text = "Simulacion";
            this.RbtSimulador.UseVisualStyleBackColor = true;
            this.RbtSimulador.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtAventura
            // 
            this.RbtAventura.AutoSize = true;
            this.RbtAventura.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtAventura.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtAventura.Location = new System.Drawing.Point(192, 17);
            this.RbtAventura.Name = "RbtAventura";
            this.RbtAventura.Size = new System.Drawing.Size(82, 21);
            this.RbtAventura.TabIndex = 6;
            this.RbtAventura.TabStop = true;
            this.RbtAventura.Text = "Aventura";
            this.RbtAventura.UseVisualStyleBackColor = true;
            this.RbtAventura.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtDeportes
            // 
            this.RbtDeportes.AutoSize = true;
            this.RbtDeportes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtDeportes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtDeportes.Location = new System.Drawing.Point(101, 68);
            this.RbtDeportes.Name = "RbtDeportes";
            this.RbtDeportes.Size = new System.Drawing.Size(82, 21);
            this.RbtDeportes.TabIndex = 5;
            this.RbtDeportes.TabStop = true;
            this.RbtDeportes.Text = "Deportes";
            this.RbtDeportes.UseVisualStyleBackColor = true;
            this.RbtDeportes.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtShooter
            // 
            this.RbtShooter.AutoSize = true;
            this.RbtShooter.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtShooter.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtShooter.Location = new System.Drawing.Point(101, 17);
            this.RbtShooter.Name = "RbtShooter";
            this.RbtShooter.Size = new System.Drawing.Size(74, 21);
            this.RbtShooter.TabIndex = 4;
            this.RbtShooter.TabStop = true;
            this.RbtShooter.Text = "Shooter";
            this.RbtShooter.UseVisualStyleBackColor = true;
            this.RbtShooter.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtRpg
            // 
            this.RbtRpg.AutoSize = true;
            this.RbtRpg.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtRpg.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtRpg.Location = new System.Drawing.Point(10, 68);
            this.RbtRpg.Name = "RbtRpg";
            this.RbtRpg.Size = new System.Drawing.Size(51, 21);
            this.RbtRpg.TabIndex = 3;
            this.RbtRpg.TabStop = true;
            this.RbtRpg.Text = "RPG";
            this.RbtRpg.UseVisualStyleBackColor = true;
            this.RbtRpg.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // RbtAccion
            // 
            this.RbtAccion.AutoSize = true;
            this.RbtAccion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtAccion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.RbtAccion.Location = new System.Drawing.Point(10, 17);
            this.RbtAccion.Name = "RbtAccion";
            this.RbtAccion.Size = new System.Drawing.Size(67, 21);
            this.RbtAccion.TabIndex = 2;
            this.RbtAccion.TabStop = true;
            this.RbtAccion.Text = "Acción";
            this.RbtAccion.UseVisualStyleBackColor = true;
            this.RbtAccion.CheckedChanged += new System.EventHandler(this.RbtAccion_CheckedChanged);
            // 
            // dgwProductosDestacados
            // 
            this.dgwProductosDestacados.AllowUserToOrderColumns = true;
            this.dgwProductosDestacados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProductosDestacados.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgwProductosDestacados.Location = new System.Drawing.Point(0, 110);
            this.dgwProductosDestacados.Name = "dgwProductosDestacados";
            this.dgwProductosDestacados.Size = new System.Drawing.Size(870, 314);
            this.dgwProductosDestacados.TabIndex = 0;
            this.dgwProductosDestacados.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgwProductosDestacados_ColumnHeaderMouseClick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bd_gaminginsightDataSet1
            // 
            this.bd_gaminginsightDataSet1.DataSetName = "bd_gaminginsightDataSet";
            this.bd_gaminginsightDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bd_gaminginsightDataSet2
            // 
            this.bd_gaminginsightDataSet2.DataSetName = "bd_gaminginsightDataSet";
            this.bd_gaminginsightDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.pnlContenido);
            this.Controls.Add(this.pnlOptions);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.btLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMaximizar)).EndInit();
            this.pnlOptions.ResumeLayout(false);
            this.pnCarrito.ResumeLayout(false);
            this.pnCarrito.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLetrero)).EndInit();
            this.pnlContenido.ResumeLayout(false);
            this.pnlContenido.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProductosDestacados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_gaminginsightDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlOptions;
        private System.Windows.Forms.Panel pnlContenido;
        private System.Windows.Forms.PictureBox pbCerrar;
        private System.Windows.Forms.PictureBox pbMaximizar;
        private System.Windows.Forms.PictureBox pbMinimizar;
        private System.Windows.Forms.PictureBox pbRestaurar;
        private System.Windows.Forms.PictureBox pbLetrero;
        private System.Windows.Forms.Label laBienvenida;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btLogOut;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btOpcionesUsuario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btCarrito;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btProductos;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btIniciarSesion;
        private bd_gaminginsightDataSet bd_gaminginsightDataSet1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dgwProductosDestacados;
        private System.Windows.Forms.RadioButton RbtIndie;
        private System.Windows.Forms.RadioButton RbtEstrategia;
        private System.Windows.Forms.RadioButton RbtSimulador;
        private System.Windows.Forms.RadioButton RbtAventura;
        private System.Windows.Forms.RadioButton RbtDeportes;
        private System.Windows.Forms.RadioButton RbtShooter;
        private System.Windows.Forms.RadioButton RbtRpg;
        private System.Windows.Forms.RadioButton RbtAccion;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label laOrdenarMainform;
        private bd_gaminginsightDataSet bd_gaminginsightDataSet2;
        private System.Windows.Forms.RadioButton rbtAñadido;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.RadioButton rbtRating;
        private System.Windows.Forms.RadioButton rbtLanzamiento;
        private System.Windows.Forms.CheckBox rbtDescendente;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.PictureBox pbImagenUsuario;
        private System.Windows.Forms.Label laRegistradoComo;
        private System.Windows.Forms.Label laNombreUsuario;
        private System.Windows.Forms.Label laPuntos;
        private System.Windows.Forms.Panel pnCarrito;
        private System.Windows.Forms.Label laCantidaddeProductos;
        private System.Windows.Forms.Button btCarritoFinalizarCompra;
        private System.Windows.Forms.Label laCantidadCarrito;
    }
}

