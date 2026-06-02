namespace WindowsFormsApp1
{
    partial class Form1
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
            this.altLbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBoxPC = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnGestos = new System.Windows.Forms.Button();
            this.btnObjetos = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnCopiarLog = new System.Windows.Forms.Button();
            this.btnVoz = new System.Windows.Forms.Button();
            this.lblTituloApp = new System.Windows.Forms.Label();
            this.lblEstadoSistema = new System.Windows.Forms.Label();
            this.lblVideoTitulo = new System.Windows.Forms.Label();
            this.lblLogTitulo = new System.Windows.Forms.Label();
            this.lblAltitudTitulo = new System.Windows.Forms.Label();
            this.lblEstadoMqtt = new System.Windows.Forms.Label();
            this.lblEstadoVoz = new System.Windows.Forms.Label();
            this.lblEstadoModo = new System.Windows.Forms.Label();
            this.btnCaptura = new System.Windows.Forms.Button();
            this.btnGrabarVideo = new System.Windows.Forms.Button();
            this.lblSegundosVideo = new System.Windows.Forms.Label();
            this.numSegundosVideo = new System.Windows.Forms.NumericUpDown();
            this.panelLeyendaGestos = new System.Windows.Forms.Panel();
            this.lblUltimoGesto = new System.Windows.Forms.Label();
            this.lblLeyendaGestos = new System.Windows.Forms.Label();
            this.lblTituloLeyendaGestos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosVideo)).BeginInit();
            this.panelLeyendaGestos.SuspendLayout();
            this.SuspendLayout();
            // 
            // altLbl
            // 
            this.altLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.altLbl.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(230)))), ((int)(((byte)(180)))));
            this.altLbl.Location = new System.Drawing.Point(630, 83);
            this.altLbl.Name = "altLbl";
            this.altLbl.Size = new System.Drawing.Size(137, 47);
            this.altLbl.TabIndex = 1;
            this.altLbl.Text = "0";
            this.altLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(125)))), ((int)(((byte)(50)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(34, 150);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "Conectar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(34, 198);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "Despegar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(34, 245);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "Aterrizar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBoxPC
            // 
            this.pictureBoxPC.BackColor = System.Drawing.Color.Black;
            this.pictureBoxPC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPC.Location = new System.Drawing.Point(198, 131);
            this.pictureBoxPC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxPC.Name = "pictureBoxPC";
            this.pictureBoxPC.Size = new System.Drawing.Size(569, 400);
            this.pictureBoxPC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPC.TabIndex = 5;
            this.pictureBoxPC.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Consolas", 8.5F);
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(792, 131);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(542, 440);
            this.listBox1.TabIndex = 11;
            // 
            // btnGestos
            // 
            this.btnGestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnGestos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestos.FlatAppearance.BorderSize = 0;
            this.btnGestos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGestos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnGestos.ForeColor = System.Drawing.Color.White;
            this.btnGestos.Location = new System.Drawing.Point(34, 422);
            this.btnGestos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGestos.Name = "btnGestos";
            this.btnGestos.Size = new System.Drawing.Size(135, 40);
            this.btnGestos.TabIndex = 12;
            this.btnGestos.Text = "Gestos";
            this.btnGestos.UseVisualStyleBackColor = false;
            this.btnGestos.Click += new System.EventHandler(this.btnGestos_Click);
            // 
            // btnObjetos
            // 
            this.btnObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnObjetos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnObjetos.FlatAppearance.BorderSize = 0;
            this.btnObjetos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnObjetos.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnObjetos.ForeColor = System.Drawing.Color.White;
            this.btnObjetos.Location = new System.Drawing.Point(34, 472);
            this.btnObjetos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnObjetos.Name = "btnObjetos";
            this.btnObjetos.Size = new System.Drawing.Size(135, 40);
            this.btnObjetos.TabIndex = 13;
            this.btnObjetos.Text = "Objetos";
            this.btnObjetos.UseVisualStyleBackColor = false;
            this.btnObjetos.Click += new System.EventHandler(this.btnObjetos_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(81)))), ((int)(((byte)(0)))));
            this.btnDetener.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetener.FlatAppearance.BorderSize = 0;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnDetener.ForeColor = System.Drawing.Color.White;
            this.btnDetener.Location = new System.Drawing.Point(34, 522);
            this.btnDetener.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(135, 40);
            this.btnDetener.TabIndex = 14;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.btnDetener_Click);
            // 
            // btnCopiarLog
            // 
            this.btnCopiarLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(110)))), ((int)(((byte)(122)))));
            this.btnCopiarLog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCopiarLog.FlatAppearance.BorderSize = 0;
            this.btnCopiarLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopiarLog.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnCopiarLog.ForeColor = System.Drawing.Color.White;
            this.btnCopiarLog.Location = new System.Drawing.Point(1135, 96);
            this.btnCopiarLog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCopiarLog.Name = "btnCopiarLog";
            this.btnCopiarLog.Size = new System.Drawing.Size(101, 30);
            this.btnCopiarLog.TabIndex = 15;
            this.btnCopiarLog.Text = "Copiar log";
            this.btnCopiarLog.UseVisualStyleBackColor = false;
            this.btnCopiarLog.Click += new System.EventHandler(this.btnCopiarLog_Click);
            // 
            // btnVoz
            // 
            this.btnVoz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(73)))), ((int)(((byte)(171)))));
            this.btnVoz.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoz.FlatAppearance.BorderSize = 0;
            this.btnVoz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoz.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btnVoz.ForeColor = System.Drawing.Color.White;
            this.btnVoz.Location = new System.Drawing.Point(34, 376);
            this.btnVoz.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnVoz.Name = "btnVoz";
            this.btnVoz.Size = new System.Drawing.Size(135, 38);
            this.btnVoz.TabIndex = 24;
            this.btnVoz.Text = "Activar voz";
            this.btnVoz.UseVisualStyleBackColor = false;
            this.btnVoz.Click += new System.EventHandler(this.btnVoz_Click);
            // 
            // lblTituloApp
            // 
            this.lblTituloApp.AutoSize = true;
            this.lblTituloApp.BackColor = System.Drawing.Color.Transparent;
            this.lblTituloApp.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTituloApp.ForeColor = System.Drawing.Color.White;
            this.lblTituloApp.Location = new System.Drawing.Point(32, 22);
            this.lblTituloApp.Name = "lblTituloApp";
            this.lblTituloApp.Size = new System.Drawing.Size(760, 48);
            this.lblTituloApp.TabIndex = 16;
            this.lblTituloApp.Text = "Sistema de control i monitorització del dron";
            // 
            // lblEstadoSistema
            // 
            this.lblEstadoSistema.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoSistema.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEstadoSistema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(200)))), ((int)(((byte)(220)))));
            this.lblEstadoSistema.Location = new System.Drawing.Point(34, 80);
            this.lblEstadoSistema.Name = "lblEstadoSistema";
            this.lblEstadoSistema.Size = new System.Drawing.Size(495, 25);
            this.lblEstadoSistema.TabIndex = 17;
            this.lblEstadoSistema.Text = "Sistema: iniciant";
            // 
            // lblVideoTitulo
            // 
            this.lblVideoTitulo.AutoSize = true;
            this.lblVideoTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblVideoTitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblVideoTitulo.ForeColor = System.Drawing.Color.White;
            this.lblVideoTitulo.Location = new System.Drawing.Point(198, 100);
            this.lblVideoTitulo.Name = "lblVideoTitulo";
            this.lblVideoTitulo.Size = new System.Drawing.Size(208, 30);
            this.lblVideoTitulo.TabIndex = 18;
            this.lblVideoTitulo.Text = "Vídeo en temps real";
            // 
            // lblLogTitulo
            // 
            this.lblLogTitulo.AutoSize = true;
            this.lblLogTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblLogTitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblLogTitulo.ForeColor = System.Drawing.Color.White;
            this.lblLogTitulo.Location = new System.Drawing.Point(792, 100);
            this.lblLogTitulo.Name = "lblLogTitulo";
            this.lblLogTitulo.Size = new System.Drawing.Size(174, 30);
            this.lblLogTitulo.TabIndex = 19;
            this.lblLogTitulo.Text = "Logs del sistema";
            // 
            // lblAltitudTitulo
            // 
            this.lblAltitudTitulo.AutoSize = true;
            this.lblAltitudTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblAltitudTitulo.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Bold);
            this.lblAltitudTitulo.ForeColor = System.Drawing.Color.White;
            this.lblAltitudTitulo.Location = new System.Drawing.Point(542, 97);
            this.lblAltitudTitulo.Name = "lblAltitudTitulo";
            this.lblAltitudTitulo.Size = new System.Drawing.Size(82, 30);
            this.lblAltitudTitulo.TabIndex = 20;
            this.lblAltitudTitulo.Text = "Altitud";
            this.lblAltitudTitulo.Click += new System.EventHandler(this.lblAltitudTitulo_Click);
            // 
            // lblEstadoMqtt
            // 
            this.lblEstadoMqtt.AutoSize = true;
            this.lblEstadoMqtt.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoMqtt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoMqtt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.lblEstadoMqtt.Location = new System.Drawing.Point(363, 612);
            this.lblEstadoMqtt.Name = "lblEstadoMqtt";
            this.lblEstadoMqtt.Size = new System.Drawing.Size(145, 25);
            this.lblEstadoMqtt.TabIndex = 21;
            this.lblEstadoMqtt.Text = "MQTT: pendent";
            // 
            // lblEstadoVoz
            // 
            this.lblEstadoVoz.AutoSize = true;
            this.lblEstadoVoz.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoVoz.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoVoz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.lblEstadoVoz.Location = new System.Drawing.Point(598, 612);
            this.lblEstadoVoz.Name = "lblEstadoVoz";
            this.lblEstadoVoz.Size = new System.Drawing.Size(154, 25);
            this.lblEstadoVoz.TabIndex = 22;
            this.lblEstadoVoz.Text = "Voz: desactivada";
            // 
            // lblEstadoModo
            // 
            this.lblEstadoModo.BackColor = System.Drawing.Color.Transparent;
            this.lblEstadoModo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEstadoModo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.lblEstadoModo.Location = new System.Drawing.Point(820, 608);
            this.lblEstadoModo.Name = "lblEstadoModo";
            this.lblEstadoModo.Size = new System.Drawing.Size(208, 32);
            this.lblEstadoModo.TabIndex = 23;
            this.lblEstadoModo.Text = "Modo: preparado";
            this.lblEstadoModo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCaptura
            // 
            this.btnCaptura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(90)))), ((int)(((byte)(100)))));
            this.btnCaptura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaptura.FlatAppearance.BorderSize = 0;
            this.btnCaptura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaptura.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnCaptura.ForeColor = System.Drawing.Color.White;
            this.btnCaptura.Location = new System.Drawing.Point(198, 548);
            this.btnCaptura.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCaptura.Name = "btnCaptura";
            this.btnCaptura.Size = new System.Drawing.Size(112, 35);
            this.btnCaptura.TabIndex = 25;
            this.btnCaptura.Text = "Capturar JPG";
            this.btnCaptura.UseVisualStyleBackColor = false;
            this.btnCaptura.Click += new System.EventHandler(this.btnCaptura_Click);
            // 
            // btnGrabarVideo
            // 
            this.btnGrabarVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(121)))), ((int)(((byte)(107)))));
            this.btnGrabarVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrabarVideo.FlatAppearance.BorderSize = 0;
            this.btnGrabarVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrabarVideo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.btnGrabarVideo.ForeColor = System.Drawing.Color.White;
            this.btnGrabarVideo.Location = new System.Drawing.Point(322, 548);
            this.btnGrabarVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGrabarVideo.Name = "btnGrabarVideo";
            this.btnGrabarVideo.Size = new System.Drawing.Size(108, 35);
            this.btnGrabarVideo.TabIndex = 26;
            this.btnGrabarVideo.Text = "Grabar";
            this.btnGrabarVideo.UseVisualStyleBackColor = false;
            this.btnGrabarVideo.Click += new System.EventHandler(this.btnGrabarVideo_Click);
            // 
            // lblSegundosVideo
            // 
            this.lblSegundosVideo.AutoSize = true;
            this.lblSegundosVideo.BackColor = System.Drawing.Color.Transparent;
            this.lblSegundosVideo.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            this.lblSegundosVideo.ForeColor = System.Drawing.Color.White;
            this.lblSegundosVideo.Location = new System.Drawing.Point(447, 554);
            this.lblSegundosVideo.Name = "lblSegundosVideo";
            this.lblSegundosVideo.Size = new System.Drawing.Size(87, 23);
            this.lblSegundosVideo.TabIndex = 27;
            this.lblSegundosVideo.Text = "Duración:";
            // 
            // numSegundosVideo
            // 
            this.numSegundosVideo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.numSegundosVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numSegundosVideo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.numSegundosVideo.ForeColor = System.Drawing.Color.White;
            this.numSegundosVideo.Location = new System.Drawing.Point(538, 549);
            this.numSegundosVideo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numSegundosVideo.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numSegundosVideo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numSegundosVideo.Name = "numSegundosVideo";
            this.numSegundosVideo.Size = new System.Drawing.Size(54, 31);
            this.numSegundosVideo.TabIndex = 28;
            this.numSegundosVideo.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // panelLeyendaGestos
            // 
            this.panelLeyendaGestos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(15)))), ((int)(((byte)(25)))));
            this.panelLeyendaGestos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLeyendaGestos.Controls.Add(this.lblUltimoGesto);
            this.panelLeyendaGestos.Controls.Add(this.lblLeyendaGestos);
            this.panelLeyendaGestos.Controls.Add(this.lblTituloLeyendaGestos);
            this.panelLeyendaGestos.Location = new System.Drawing.Point(34, 599);
            this.panelLeyendaGestos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelLeyendaGestos.Name = "panelLeyendaGestos";
            this.panelLeyendaGestos.Size = new System.Drawing.Size(235, 223);
            this.panelLeyendaGestos.TabIndex = 29;
            // 
            // lblUltimoGesto
            // 
            this.lblUltimoGesto.AutoSize = true;
            this.lblUltimoGesto.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoGesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.lblUltimoGesto.Location = new System.Drawing.Point(8, 183);
            this.lblUltimoGesto.Name = "lblUltimoGesto";
            this.lblUltimoGesto.Size = new System.Drawing.Size(123, 21);
            this.lblUltimoGesto.TabIndex = 2;
            this.lblUltimoGesto.Text = "Último gesto: -";
            // 
            // lblLeyendaGestos
            // 
            this.lblLeyendaGestos.AutoSize = true;
            this.lblLeyendaGestos.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblLeyendaGestos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.lblLeyendaGestos.Location = new System.Drawing.Point(8, 44);
            this.lblLeyendaGestos.Name = "lblLeyendaGestos";
            this.lblLeyendaGestos.Size = new System.Drawing.Size(210, 158);
            this.lblLeyendaGestos.TabIndex = 1;
            this.lblLeyendaGestos.Text = "Palma → Despegar\r\nPuño → Aterrizar\r\nUno  → Avanzar\r\nDos  → Derecha\r\nTres → Izquie" +
    "rda";
            // 
            // lblTituloLeyendaGestos
            // 
            this.lblTituloLeyendaGestos.AutoSize = true;
            this.lblTituloLeyendaGestos.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.lblTituloLeyendaGestos.ForeColor = System.Drawing.Color.White;
            this.lblTituloLeyendaGestos.Location = new System.Drawing.Point(8, 8);
            this.lblTituloLeyendaGestos.Name = "lblTituloLeyendaGestos";
            this.lblTituloLeyendaGestos.Size = new System.Drawing.Size(150, 21);
            this.lblTituloLeyendaGestos.TabIndex = 0;
            this.lblTituloLeyendaGestos.Text = "Leyenda de gestos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(24)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1377, 860);
            this.Controls.Add(this.panelLeyendaGestos);
            this.Controls.Add(this.numSegundosVideo);
            this.Controls.Add(this.lblSegundosVideo);
            this.Controls.Add(this.btnGrabarVideo);
            this.Controls.Add(this.btnCaptura);
            this.Controls.Add(this.lblEstadoModo);
            this.Controls.Add(this.lblEstadoVoz);
            this.Controls.Add(this.lblEstadoMqtt);
            this.Controls.Add(this.lblAltitudTitulo);
            this.Controls.Add(this.btnVoz);
            this.Controls.Add(this.lblLogTitulo);
            this.Controls.Add(this.lblVideoTitulo);
            this.Controls.Add(this.lblEstadoSistema);
            this.Controls.Add(this.lblTituloApp);
            this.Controls.Add(this.btnCopiarLog);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnObjetos);
            this.Controls.Add(this.btnGestos);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pictureBoxPC);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.altLbl);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1216, 820);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de control i monitorització del dron";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSegundosVideo)).EndInit();
            this.panelLeyendaGestos.ResumeLayout(false);
            this.panelLeyendaGestos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label altLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBoxPC;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnGestos;
        private System.Windows.Forms.Button btnObjetos;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnCopiarLog;
        private System.Windows.Forms.Button btnVoz;
        private System.Windows.Forms.Label lblTituloApp;
        private System.Windows.Forms.Label lblEstadoSistema;
        private System.Windows.Forms.Label lblVideoTitulo;
        private System.Windows.Forms.Label lblLogTitulo;
        private System.Windows.Forms.Label lblAltitudTitulo;
        private System.Windows.Forms.Label lblEstadoMqtt;
        private System.Windows.Forms.Label lblEstadoVoz;
        private System.Windows.Forms.Label lblEstadoModo;
        private System.Windows.Forms.Button btnCaptura;
        private System.Windows.Forms.Button btnGrabarVideo;
        private System.Windows.Forms.Label lblSegundosVideo;
        private System.Windows.Forms.NumericUpDown numSegundosVideo;
        private System.Windows.Forms.Panel panelLeyendaGestos;
        private System.Windows.Forms.Label lblTituloLeyendaGestos;
        private System.Windows.Forms.Label lblLeyendaGestos;
        private System.Windows.Forms.Label lblUltimoGesto;
    }
}
