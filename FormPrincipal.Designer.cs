namespace administradorTareas
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConcurrencia = new System.Windows.Forms.Button();
            this.btnSoftware = new System.Windows.Forms.Button();
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnRedes = new System.Windows.Forms.Button();
            this.btnMonitorear = new System.Windows.Forms.Button();
            this.btnHardware = new System.Windows.Forms.Button();
            this.btnWindows = new System.Windows.Forms.Button();
            this.panelBarraTitulo = new System.Windows.Forms.Panel();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.panelContenedor.SuspendLayout();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContenedor
            // 
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.panelFormularios);
            this.panelContenedor.Controls.Add(this.panelMenu);
            this.panelContenedor.Controls.Add(this.panelBarraTitulo);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(0, 0);
            this.panelContenedor.MinimumSize = new System.Drawing.Size(650, 650);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(934, 650);
            this.panelContenedor.TabIndex = 0;
            // 
            // panelFormularios
            // 
            this.panelFormularios.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelFormularios.Controls.Add(this.label2);
            this.panelFormularios.Controls.Add(this.label1);
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormularios.Location = new System.Drawing.Point(200, 39);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(734, 611);
            this.panelFormularios.TabIndex = 0;
            this.panelFormularios.Paint += new System.Windows.Forms.PaintEventHandler(this.panelFormularios_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Azonix", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(187, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "ADMINISTRADOR DE TAREAS";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Azonix", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(110, 68);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(462, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "SISTEMAS OPERATIVOS I";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(207, 121);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(41)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Controls.Add(this.btnConcurrencia);
            this.panelMenu.Controls.Add(this.btnSoftware);
            this.panelMenu.Controls.Add(this.btnProcesos);
            this.panelMenu.Controls.Add(this.btnRedes);
            this.panelMenu.Controls.Add(this.btnMonitorear);
            this.panelMenu.Controls.Add(this.btnHardware);
            this.panelMenu.Controls.Add(this.btnWindows);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 39);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 611);
            this.panelMenu.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Azonix", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 478);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 58);
            this.button1.TabIndex = 7;
            this.button1.Text = "INTERBLOQUEO";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConcurrencia
            // 
            this.btnConcurrencia.FlatAppearance.BorderSize = 0;
            this.btnConcurrencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnConcurrencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnConcurrencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConcurrencia.Font = new System.Drawing.Font("Azonix", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcurrencia.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnConcurrencia.Image = ((System.Drawing.Image)(resources.GetObject("btnConcurrencia.Image")));
            this.btnConcurrencia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcurrencia.Location = new System.Drawing.Point(0, 425);
            this.btnConcurrencia.Name = "btnConcurrencia";
            this.btnConcurrencia.Size = new System.Drawing.Size(200, 57);
            this.btnConcurrencia.TabIndex = 6;
            this.btnConcurrencia.Text = "Concurrencia";
            this.btnConcurrencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConcurrencia.UseVisualStyleBackColor = true;
            this.btnConcurrencia.Click += new System.EventHandler(this.btnConcurrencia_Click);
            // 
            // btnSoftware
            // 
            this.btnSoftware.FlatAppearance.BorderSize = 0;
            this.btnSoftware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnSoftware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftware.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSoftware.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSoftware.Image = ((System.Drawing.Image)(resources.GetObject("btnSoftware.Image")));
            this.btnSoftware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftware.Location = new System.Drawing.Point(0, 371);
            this.btnSoftware.Name = "btnSoftware";
            this.btnSoftware.Size = new System.Drawing.Size(200, 48);
            this.btnSoftware.TabIndex = 5;
            this.btnSoftware.Text = " Software";
            this.btnSoftware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSoftware.UseVisualStyleBackColor = true;
            this.btnSoftware.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnProcesos
            // 
            this.btnProcesos.FlatAppearance.BorderSize = 0;
            this.btnProcesos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnProcesos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcesos.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnProcesos.Image = ((System.Drawing.Image)(resources.GetObject("btnProcesos.Image")));
            this.btnProcesos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProcesos.Location = new System.Drawing.Point(0, 319);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(200, 48);
            this.btnProcesos.TabIndex = 4;
            this.btnProcesos.Text = " Procesos";
            this.btnProcesos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnRedes
            // 
            this.btnRedes.FlatAppearance.BorderSize = 0;
            this.btnRedes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnRedes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnRedes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedes.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRedes.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnRedes.Image = ((System.Drawing.Image)(resources.GetObject("btnRedes.Image")));
            this.btnRedes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRedes.Location = new System.Drawing.Point(0, 265);
            this.btnRedes.Name = "btnRedes";
            this.btnRedes.Size = new System.Drawing.Size(200, 48);
            this.btnRedes.TabIndex = 3;
            this.btnRedes.Text = " Redes ";
            this.btnRedes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRedes.UseVisualStyleBackColor = true;
            this.btnRedes.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnMonitorear
            // 
            this.btnMonitorear.FlatAppearance.BorderSize = 0;
            this.btnMonitorear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnMonitorear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnMonitorear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonitorear.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitorear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMonitorear.Image = ((System.Drawing.Image)(resources.GetObject("btnMonitorear.Image")));
            this.btnMonitorear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonitorear.Location = new System.Drawing.Point(0, 211);
            this.btnMonitorear.Name = "btnMonitorear";
            this.btnMonitorear.Size = new System.Drawing.Size(200, 48);
            this.btnMonitorear.TabIndex = 2;
            this.btnMonitorear.Text = "Monitorear Recursos";
            this.btnMonitorear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMonitorear.UseVisualStyleBackColor = true;
            this.btnMonitorear.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnHardware
            // 
            this.btnHardware.FlatAppearance.BorderSize = 0;
            this.btnHardware.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnHardware.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnHardware.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHardware.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHardware.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHardware.Image = ((System.Drawing.Image)(resources.GetObject("btnHardware.Image")));
            this.btnHardware.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHardware.Location = new System.Drawing.Point(0, 157);
            this.btnHardware.Name = "btnHardware";
            this.btnHardware.Size = new System.Drawing.Size(200, 48);
            this.btnHardware.TabIndex = 1;
            this.btnHardware.Text = " Hardware";
            this.btnHardware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHardware.UseVisualStyleBackColor = true;
            this.btnHardware.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnWindows
            // 
            this.btnWindows.FlatAppearance.BorderSize = 0;
            this.btnWindows.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(50)))), ((int)(((byte)(70)))));
            this.btnWindows.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.btnWindows.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWindows.Font = new System.Drawing.Font("Azonix", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWindows.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnWindows.Image = ((System.Drawing.Image)(resources.GetObject("btnWindows.Image")));
            this.btnWindows.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWindows.Location = new System.Drawing.Point(0, 103);
            this.btnWindows.Name = "btnWindows";
            this.btnWindows.Size = new System.Drawing.Size(200, 48);
            this.btnWindows.TabIndex = 0;
            this.btnWindows.Text = "Windows";
            this.btnWindows.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWindows.UseVisualStyleBackColor = true;
            this.btnWindows.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelBarraTitulo
            // 
            this.panelBarraTitulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panelBarraTitulo.Controls.Add(this.btnRestaurar);
            this.panelBarraTitulo.Controls.Add(this.btnMinimizar);
            this.panelBarraTitulo.Controls.Add(this.btnMaximizar);
            this.panelBarraTitulo.Controls.Add(this.btnCerrar);
            this.panelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelBarraTitulo.Name = "panelBarraTitulo";
            this.panelBarraTitulo.Size = new System.Drawing.Size(934, 39);
            this.panelBarraTitulo.TabIndex = 0;
            this.panelBarraTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelBarraTitulo_MouseMove);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = ((System.Drawing.Image)(resources.GetObject("btnRestaurar.Image")));
            this.btnRestaurar.Location = new System.Drawing.Point(857, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(32, 33);
            this.btnRestaurar.TabIndex = 3;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(820, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(32, 33);
            this.btnMinimizar.TabIndex = 2;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMaximizar.Image")));
            this.btnMaximizar.Location = new System.Drawing.Point(856, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(35, 34);
            this.btnMaximizar.TabIndex = 1;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(894, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(37, 34);
            this.btnCerrar.TabIndex = 0;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 587);
            this.Controls.Add(this.panelContenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.panelContenedor.ResumeLayout(false);
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelBarraTitulo;
        private System.Windows.Forms.Panel panelFormularios;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.Button btnMonitorear;
        private System.Windows.Forms.Button btnHardware;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRedes;
        private System.Windows.Forms.Button btnSoftware;
        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnConcurrencia;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnWindows;
    }
}

