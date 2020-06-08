namespace InsightGaming_V1._0
{
    partial class formOpciones
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSalirAdmin = new System.Windows.Forms.Button();
            this.btAdmin = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btInformar = new System.Windows.Forms.Button();
            this.btOrdenes = new System.Windows.Forms.Button();
            this.btDatosPersonales = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape4 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.pnDatosPersonales = new System.Windows.Forms.Panel();
            this.pnInformar = new System.Windows.Forms.Panel();
            this.btEnviarIncidencia = new System.Windows.Forms.Button();
            this.cbOpcionesEnvioEmail = new System.Windows.Forms.ComboBox();
            this.laApoyoIntroducción = new System.Windows.Forms.Label();
            this.pbImagenApoyo = new System.Windows.Forms.PictureBox();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laFechaNacimiento = new System.Windows.Forms.Label();
            this.laDireccion = new System.Windows.Forms.Label();
            this.laApellidos = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.laNombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btSeleccionarAvatar = new System.Windows.Forms.Button();
            this.pnTickets = new System.Windows.Forms.Panel();
            this.lvListaCompra = new System.Windows.Forms.ListView();
            this.col_FechaCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_precio = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDetallesCompra = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.btGuardarCambios = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape9 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape8 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape7 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape6 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape5 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.dlgImagen = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.pnDatosPersonales.SuspendLayout();
            this.pnInformar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenApoyo)).BeginInit();
            this.pnTickets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.btSalirAdmin);
            this.panel1.Controls.Add(this.btAdmin);
            this.panel1.Controls.Add(this.btSalir);
            this.panel1.Controls.Add(this.btInformar);
            this.panel1.Controls.Add(this.btOrdenes);
            this.panel1.Controls.Add(this.btDatosPersonales);
            this.panel1.Controls.Add(this.shapeContainer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 450);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDatosPersonales_MouseDown);
            // 
            // btSalirAdmin
            // 
            this.btSalirAdmin.FlatAppearance.BorderSize = 0;
            this.btSalirAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalirAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalirAdmin.ForeColor = System.Drawing.SystemColors.Control;
            this.btSalirAdmin.Location = new System.Drawing.Point(1, 128);
            this.btSalirAdmin.Name = "btSalirAdmin";
            this.btSalirAdmin.Size = new System.Drawing.Size(199, 23);
            this.btSalirAdmin.TabIndex = 5;
            this.btSalirAdmin.Text = "Salir";
            this.btSalirAdmin.UseVisualStyleBackColor = true;
            this.btSalirAdmin.Visible = false;
            this.btSalirAdmin.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btAdmin
            // 
            this.btAdmin.FlatAppearance.BorderSize = 0;
            this.btAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdmin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdmin.ForeColor = System.Drawing.Color.White;
            this.btAdmin.Location = new System.Drawing.Point(1, 99);
            this.btAdmin.Name = "btAdmin";
            this.btAdmin.Size = new System.Drawing.Size(201, 23);
            this.btAdmin.TabIndex = 4;
            this.btAdmin.Text = "Administración";
            this.btAdmin.UseVisualStyleBackColor = true;
            this.btAdmin.Click += new System.EventHandler(this.btAdmin_Click);
            // 
            // btSalir
            // 
            this.btSalir.FlatAppearance.BorderSize = 0;
            this.btSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalir.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.ForeColor = System.Drawing.SystemColors.Control;
            this.btSalir.Location = new System.Drawing.Point(1, 99);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(199, 23);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btInformar
            // 
            this.btInformar.FlatAppearance.BorderSize = 0;
            this.btInformar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInformar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInformar.ForeColor = System.Drawing.SystemColors.Control;
            this.btInformar.Location = new System.Drawing.Point(0, 70);
            this.btInformar.Name = "btInformar";
            this.btInformar.Size = new System.Drawing.Size(200, 23);
            this.btInformar.TabIndex = 3;
            this.btInformar.Text = "Informar ";
            this.btInformar.UseVisualStyleBackColor = true;
            this.btInformar.Click += new System.EventHandler(this.btInformar_Click);
            // 
            // btOrdenes
            // 
            this.btOrdenes.FlatAppearance.BorderSize = 0;
            this.btOrdenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOrdenes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOrdenes.ForeColor = System.Drawing.SystemColors.Control;
            this.btOrdenes.Location = new System.Drawing.Point(0, 41);
            this.btOrdenes.Name = "btOrdenes";
            this.btOrdenes.Size = new System.Drawing.Size(200, 23);
            this.btOrdenes.TabIndex = 2;
            this.btOrdenes.Text = "Tickets";
            this.btOrdenes.UseVisualStyleBackColor = true;
            this.btOrdenes.Click += new System.EventHandler(this.btOrdenes_Click);
            // 
            // btDatosPersonales
            // 
            this.btDatosPersonales.FlatAppearance.BorderSize = 0;
            this.btDatosPersonales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btDatosPersonales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDatosPersonales.ForeColor = System.Drawing.SystemColors.Control;
            this.btDatosPersonales.Location = new System.Drawing.Point(0, 12);
            this.btDatosPersonales.Name = "btDatosPersonales";
            this.btDatosPersonales.Size = new System.Drawing.Size(200, 23);
            this.btDatosPersonales.TabIndex = 1;
            this.btDatosPersonales.Text = "Datos Personales";
            this.btDatosPersonales.UseVisualStyleBackColor = true;
            this.btDatosPersonales.Click += new System.EventHandler(this.btDatosPersonales_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape4,
            this.lineShape3,
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(200, 450);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape4
            // 
            this.lineShape4.Name = "lineShape4";
            this.lineShape4.X1 = 1;
            this.lineShape4.X2 = 201;
            this.lineShape4.Y1 = 125;
            this.lineShape4.Y2 = 125;
            // 
            // lineShape3
            // 
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 0;
            this.lineShape3.X2 = 200;
            this.lineShape3.Y1 = 67;
            this.lineShape3.Y2 = 67;
            // 
            // lineShape2
            // 
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 0;
            this.lineShape2.X2 = 200;
            this.lineShape2.Y1 = 38;
            this.lineShape2.Y2 = 38;
            // 
            // lineShape1
            // 
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 1;
            this.lineShape1.X2 = 201;
            this.lineShape1.Y1 = 95;
            this.lineShape1.Y2 = 95;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // pnDatosPersonales
            // 
            this.pnDatosPersonales.BackColor = System.Drawing.Color.DimGray;
            this.pnDatosPersonales.Controls.Add(this.pnInformar);
            this.pnDatosPersonales.Controls.Add(this.laTelefono);
            this.pnDatosPersonales.Controls.Add(this.laFechaNacimiento);
            this.pnDatosPersonales.Controls.Add(this.laDireccion);
            this.pnDatosPersonales.Controls.Add(this.laApellidos);
            this.pnDatosPersonales.Controls.Add(this.label3);
            this.pnDatosPersonales.Controls.Add(this.laNombre);
            this.pnDatosPersonales.Controls.Add(this.label1);
            this.pnDatosPersonales.Controls.Add(this.btSeleccionarAvatar);
            this.pnDatosPersonales.Controls.Add(this.pnTickets);
            this.pnDatosPersonales.Controls.Add(this.tbTelefono);
            this.pnDatosPersonales.Controls.Add(this.btGuardarCambios);
            this.pnDatosPersonales.Controls.Add(this.dateTimePicker1);
            this.pnDatosPersonales.Controls.Add(this.tbDireccion);
            this.pnDatosPersonales.Controls.Add(this.tbApellidos);
            this.pnDatosPersonales.Controls.Add(this.pictureBox1);
            this.pnDatosPersonales.Controls.Add(this.tbNombre);
            this.pnDatosPersonales.Controls.Add(this.tbNombreUsuario);
            this.pnDatosPersonales.Controls.Add(this.shapeContainer2);
            this.pnDatosPersonales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDatosPersonales.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnDatosPersonales.Location = new System.Drawing.Point(200, 0);
            this.pnDatosPersonales.Name = "pnDatosPersonales";
            this.pnDatosPersonales.Size = new System.Drawing.Size(600, 450);
            this.pnDatosPersonales.TabIndex = 1;
            this.pnDatosPersonales.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDatosPersonales_MouseDown);
            // 
            // pnInformar
            // 
            this.pnInformar.Controls.Add(this.btEnviarIncidencia);
            this.pnInformar.Controls.Add(this.cbOpcionesEnvioEmail);
            this.pnInformar.Controls.Add(this.laApoyoIntroducción);
            this.pnInformar.Controls.Add(this.pbImagenApoyo);
            this.pnInformar.Location = new System.Drawing.Point(58, 70);
            this.pnInformar.Name = "pnInformar";
            this.pnInformar.Size = new System.Drawing.Size(471, 371);
            this.pnInformar.TabIndex = 20;
            this.pnInformar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDatosPersonales_MouseDown);
            // 
            // btEnviarIncidencia
            // 
            this.btEnviarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEnviarIncidencia.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btEnviarIncidencia.Location = new System.Drawing.Point(31, 321);
            this.btEnviarIncidencia.Name = "btEnviarIncidencia";
            this.btEnviarIncidencia.Size = new System.Drawing.Size(369, 36);
            this.btEnviarIncidencia.TabIndex = 3;
            this.btEnviarIncidencia.Text = "ENVIAR INCIDENCIA";
            this.btEnviarIncidencia.UseVisualStyleBackColor = true;
            this.btEnviarIncidencia.Click += new System.EventHandler(this.btEnviarIncidencia_Click);
            // 
            // cbOpcionesEnvioEmail
            // 
            this.cbOpcionesEnvioEmail.FormattingEnabled = true;
            this.cbOpcionesEnvioEmail.Items.AddRange(new object[] {
            "Quiero cambiar mi contraseña",
            "Quiero recuperar mis puntos",
            "Quiero formar parte del staff",
            "Quiero recuperar una cuenta"});
            this.cbOpcionesEnvioEmail.Location = new System.Drawing.Point(31, 279);
            this.cbOpcionesEnvioEmail.Name = "cbOpcionesEnvioEmail";
            this.cbOpcionesEnvioEmail.Size = new System.Drawing.Size(369, 29);
            this.cbOpcionesEnvioEmail.TabIndex = 2;
            // 
            // laApoyoIntroducción
            // 
            this.laApoyoIntroducción.AutoSize = true;
            this.laApoyoIntroducción.Location = new System.Drawing.Point(27, 209);
            this.laApoyoIntroducción.Name = "laApoyoIntroducción";
            this.laApoyoIntroducción.Size = new System.Drawing.Size(384, 63);
            this.laApoyoIntroducción.TabIndex = 1;
            this.laApoyoIntroducción.Text = "¿Tienes problemas navegando por nuestra aplicacion?\r\n\r\nSelecciona la incidencia\r\n" +
    "";
            // 
            // pbImagenApoyo
            // 
            this.pbImagenApoyo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbImagenApoyo.Image = global::InsightGaming_V1._0.Properties.Resources.support_email;
            this.pbImagenApoyo.Location = new System.Drawing.Point(0, 0);
            this.pbImagenApoyo.Name = "pbImagenApoyo";
            this.pbImagenApoyo.Size = new System.Drawing.Size(471, 188);
            this.pbImagenApoyo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagenApoyo.TabIndex = 0;
            this.pbImagenApoyo.TabStop = false;
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Location = new System.Drawing.Point(488, 199);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(68, 21);
            this.laTelefono.TabIndex = 19;
            this.laTelefono.Text = "Teléfono";
            // 
            // laFechaNacimiento
            // 
            this.laFechaNacimiento.AutoSize = true;
            this.laFechaNacimiento.Location = new System.Drawing.Point(327, 326);
            this.laFechaNacimiento.Name = "laFechaNacimiento";
            this.laFechaNacimiento.Size = new System.Drawing.Size(152, 21);
            this.laFechaNacimiento.TabIndex = 18;
            this.laFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Location = new System.Drawing.Point(327, 285);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(75, 21);
            this.laDireccion.TabIndex = 17;
            this.laDireccion.Text = "Dirección";
            // 
            // laApellidos
            // 
            this.laApellidos.AutoSize = true;
            this.laApellidos.Location = new System.Drawing.Point(327, 245);
            this.laApellidos.Name = "laApellidos";
            this.laApellidos.Size = new System.Drawing.Size(74, 21);
            this.laApellidos.TabIndex = 16;
            this.laApellidos.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(503, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 21);
            this.label3.TabIndex = 15;
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Location = new System.Drawing.Point(221, 200);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(68, 21);
            this.laNombre.TabIndex = 14;
            this.laNombre.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre de usuario";
            // 
            // btSeleccionarAvatar
            // 
            this.btSeleccionarAvatar.Location = new System.Drawing.Point(353, 103);
            this.btSeleccionarAvatar.Name = "btSeleccionarAvatar";
            this.btSeleccionarAvatar.Size = new System.Drawing.Size(247, 28);
            this.btSeleccionarAvatar.TabIndex = 12;
            this.btSeleccionarAvatar.Text = "Examinar....";
            this.btSeleccionarAvatar.UseVisualStyleBackColor = true;
            this.btSeleccionarAvatar.Click += new System.EventHandler(this.btSeleccionarAvatar_Click);
            // 
            // pnTickets
            // 
            this.pnTickets.Controls.Add(this.lvListaCompra);
            this.pnTickets.Location = new System.Drawing.Point(191, 285);
            this.pnTickets.Name = "pnTickets";
            this.pnTickets.Size = new System.Drawing.Size(594, 447);
            this.pnTickets.TabIndex = 11;
            this.pnTickets.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnDatosPersonales_MouseDown);
            // 
            // lvListaCompra
            // 
            this.lvListaCompra.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_FechaCompra,
            this.col_precio,
            this.colDetallesCompra});
            this.lvListaCompra.HideSelection = false;
            this.lvListaCompra.Location = new System.Drawing.Point(14, 67);
            this.lvListaCompra.Name = "lvListaCompra";
            this.lvListaCompra.Size = new System.Drawing.Size(569, 371);
            this.lvListaCompra.TabIndex = 0;
            this.lvListaCompra.UseCompatibleStateImageBehavior = false;
            this.lvListaCompra.View = System.Windows.Forms.View.Details;
            // 
            // col_FechaCompra
            // 
            this.col_FechaCompra.Text = "Fecha_Compra";
            // 
            // col_precio
            // 
            this.col_precio.Text = "Precio";
            // 
            // colDetallesCompra
            // 
            this.colDetallesCompra.Text = "Detalles_Compra";
            // 
            // tbTelefono
            // 
            this.tbTelefono.BackColor = System.Drawing.Color.DimGray;
            this.tbTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTelefono.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefono.Location = new System.Drawing.Point(331, 198);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(134, 22);
            this.tbTelefono.TabIndex = 10;
            this.tbTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefono_KeyPress);
            // 
            // btGuardarCambios
            // 
            this.btGuardarCambios.BackColor = System.Drawing.Color.DimGray;
            this.btGuardarCambios.FlatAppearance.BorderSize = 0;
            this.btGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.btGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarCambios.ForeColor = System.Drawing.SystemColors.Control;
            this.btGuardarCambios.Location = new System.Drawing.Point(46, 384);
            this.btGuardarCambios.Name = "btGuardarCambios";
            this.btGuardarCambios.Size = new System.Drawing.Size(229, 41);
            this.btGuardarCambios.TabIndex = 9;
            this.btGuardarCambios.Text = "GUARDAR CAMBIOS";
            this.btGuardarCambios.UseVisualStyleBackColor = false;
            this.btGuardarCambios.Click += new System.EventHandler(this.btGuardarCambios_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(46, 326);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 29);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // tbDireccion
            // 
            this.tbDireccion.BackColor = System.Drawing.Color.DimGray;
            this.tbDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDireccion.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDireccion.Location = new System.Drawing.Point(44, 285);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(277, 22);
            this.tbDireccion.TabIndex = 5;
            // 
            // tbApellidos
            // 
            this.tbApellidos.BackColor = System.Drawing.Color.DimGray;
            this.tbApellidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbApellidos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidos.Location = new System.Drawing.Point(44, 245);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(277, 22);
            this.tbApellidos.TabIndex = 4;
            this.tbApellidos.TextChanged += new System.EventHandler(this.tbApellidos_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(353, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 131);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tbNombre
            // 
            this.tbNombre.BackColor = System.Drawing.Color.DimGray;
            this.tbNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombre.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(44, 199);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(277, 22);
            this.tbNombre.TabIndex = 2;
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.BackColor = System.Drawing.Color.DimGray;
            this.tbNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.Location = new System.Drawing.Point(38, 48);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(283, 22);
            this.tbNombreUsuario.TabIndex = 1;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape9,
            this.lineShape8,
            this.lineShape7,
            this.lineShape6,
            this.lineShape5});
            this.shapeContainer2.Size = new System.Drawing.Size(600, 450);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape9
            // 
            this.lineShape9.Name = "lineShape9";
            this.lineShape9.X1 = 46;
            this.lineShape9.X2 = 581;
            this.lineShape9.Y1 = 314;
            this.lineShape9.Y2 = 314;
            // 
            // lineShape8
            // 
            this.lineShape8.Name = "lineShape8";
            this.lineShape8.X1 = 45;
            this.lineShape8.X2 = 580;
            this.lineShape8.Y1 = 273;
            this.lineShape8.Y2 = 273;
            // 
            // lineShape7
            // 
            this.lineShape7.Name = "lineShape7";
            this.lineShape7.X1 = 44;
            this.lineShape7.X2 = 579;
            this.lineShape7.Y1 = 228;
            this.lineShape7.Y2 = 228;
            // 
            // lineShape6
            // 
            this.lineShape6.Name = "lineShape6";
            this.lineShape6.X1 = 46;
            this.lineShape6.X2 = 581;
            this.lineShape6.Y1 = 356;
            this.lineShape6.Y2 = 356;
            // 
            // lineShape5
            // 
            this.lineShape5.Name = "lineShape5";
            this.lineShape5.X1 = 38;
            this.lineShape5.X2 = 320;
            this.lineShape5.Y1 = 76;
            this.lineShape5.Y2 = 76;
            // 
            // dlgImagen
            // 
            this.dlgImagen.FileName = "openFileDialog1";
            this.dlgImagen.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // formOpciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnDatosPersonales);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formOpciones";
            this.Text = "formOpciones";
            this.Load += new System.EventHandler(this.formOpciones_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.pnDatosPersonales.ResumeLayout(false);
            this.pnDatosPersonales.PerformLayout();
            this.pnInformar.ResumeLayout(false);
            this.pnInformar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagenApoyo)).EndInit();
            this.pnTickets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btInformar;
        private System.Windows.Forms.Button btOrdenes;
        private System.Windows.Forms.Button btDatosPersonales;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape4;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Panel pnDatosPersonales;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape9;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape8;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape7;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape6;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.OpenFileDialog dlgImagen;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Button btGuardarCambios;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Panel pnTickets;
        private System.Windows.Forms.ListView lvListaCompra;
        private System.Windows.Forms.ColumnHeader col_FechaCompra;
        private System.Windows.Forms.ColumnHeader col_precio;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button btSeleccionarAvatar;
        private System.Windows.Forms.Label laFechaNacimiento;
        private System.Windows.Forms.Label laDireccion;
        private System.Windows.Forms.Label laApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label laNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label laTelefono;
        private System.Windows.Forms.Panel pnInformar;
        private System.Windows.Forms.PictureBox pbImagenApoyo;
        private System.Windows.Forms.Button btEnviarIncidencia;
        private System.Windows.Forms.ComboBox cbOpcionesEnvioEmail;
        private System.Windows.Forms.Label laApoyoIntroducción;
        private System.Windows.Forms.Button btAdmin;
        private System.Windows.Forms.Button btSalirAdmin;
        private System.Windows.Forms.ColumnHeader colDetallesCompra;
    }
}