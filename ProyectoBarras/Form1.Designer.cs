namespace ProyectoBarras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.txtnumeroetiquetas = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkmostrardescripcion = new System.Windows.Forms.CheckBox();
            this.chkmostrarcodigo = new System.Windows.Forms.CheckBox();
            this.cboorientacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbotipocodigo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btngenerardocumento = new FontAwesome.Sharp.IconButton();
            this.btngenerarimagen = new FontAwesome.Sharp.IconButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroetiquetas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(123, 19);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(219, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Número de Etiquetas:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(123, 46);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(219, 20);
            this.txtdescripcion.TabIndex = 6;
            // 
            // txtnumeroetiquetas
            // 
            this.txtnumeroetiquetas.Location = new System.Drawing.Point(123, 75);
            this.txtnumeroetiquetas.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.txtnumeroetiquetas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtnumeroetiquetas.Name = "txtnumeroetiquetas";
            this.txtnumeroetiquetas.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnumeroetiquetas.Size = new System.Drawing.Size(219, 20);
            this.txtnumeroetiquetas.TabIndex = 7;
            this.txtnumeroetiquetas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.txtnumeroetiquetas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 125);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Etiqueta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cboorientacion);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cbotipocodigo);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(378, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(305, 125);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuracion";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkmostrardescripcion);
            this.groupBox3.Controls.Add(this.chkmostrarcodigo);
            this.groupBox3.Location = new System.Drawing.Point(10, 73);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 46);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "En Etiqueta";
            // 
            // chkmostrardescripcion
            // 
            this.chkmostrardescripcion.AutoSize = true;
            this.chkmostrardescripcion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkmostrardescripcion.Location = new System.Drawing.Point(130, 20);
            this.chkmostrardescripcion.Name = "chkmostrardescripcion";
            this.chkmostrardescripcion.Size = new System.Drawing.Size(120, 17);
            this.chkmostrardescripcion.TabIndex = 1;
            this.chkmostrardescripcion.Text = "Mostrar Descripción";
            this.chkmostrardescripcion.UseVisualStyleBackColor = true;
            // 
            // chkmostrarcodigo
            // 
            this.chkmostrarcodigo.AutoSize = true;
            this.chkmostrarcodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chkmostrarcodigo.Location = new System.Drawing.Point(11, 20);
            this.chkmostrarcodigo.Name = "chkmostrarcodigo";
            this.chkmostrarcodigo.Size = new System.Drawing.Size(97, 17);
            this.chkmostrarcodigo.TabIndex = 0;
            this.chkmostrarcodigo.Text = "Mostrar Codigo";
            this.chkmostrarcodigo.UseVisualStyleBackColor = true;
            // 
            // cboorientacion
            // 
            this.cboorientacion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboorientacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboorientacion.FormattingEnabled = true;
            this.cboorientacion.Location = new System.Drawing.Point(135, 46);
            this.cboorientacion.Name = "cboorientacion";
            this.cboorientacion.Size = new System.Drawing.Size(164, 21);
            this.cboorientacion.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Orientación Documento:";
            // 
            // cbotipocodigo
            // 
            this.cbotipocodigo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbotipocodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotipocodigo.FormattingEnabled = true;
            this.cbotipocodigo.Location = new System.Drawing.Point(135, 19);
            this.cbotipocodigo.Name = "cbotipocodigo";
            this.cbotipocodigo.Size = new System.Drawing.Size(164, 21);
            this.cbotipocodigo.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tipo Codigo:";
            // 
            // btngenerardocumento
            // 
            this.btngenerardocumento.BackColor = System.Drawing.Color.LightGreen;
            this.btngenerardocumento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerardocumento.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerardocumento.ForeColor = System.Drawing.Color.Black;
            this.btngenerardocumento.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btngenerardocumento.IconColor = System.Drawing.Color.Black;
            this.btngenerardocumento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerardocumento.IconSize = 40;
            this.btngenerardocumento.Location = new System.Drawing.Point(691, 17);
            this.btngenerardocumento.Name = "btngenerardocumento";
            this.btngenerardocumento.Size = new System.Drawing.Size(125, 52);
            this.btngenerardocumento.TabIndex = 10;
            this.btngenerardocumento.Text = "Generar Documento";
            this.btngenerardocumento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerardocumento.UseVisualStyleBackColor = false;
            this.btngenerardocumento.Click += new System.EventHandler(this.btngenerardocumento_Click);
            // 
            // btngenerarimagen
            // 
            this.btngenerarimagen.BackColor = System.Drawing.Color.Gold;
            this.btngenerarimagen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarimagen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btngenerarimagen.ForeColor = System.Drawing.Color.Black;
            this.btngenerarimagen.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.btngenerarimagen.IconColor = System.Drawing.Color.Black;
            this.btngenerarimagen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarimagen.IconSize = 40;
            this.btngenerarimagen.Location = new System.Drawing.Point(690, 79);
            this.btngenerarimagen.Name = "btngenerarimagen";
            this.btngenerarimagen.Size = new System.Drawing.Size(125, 52);
            this.btngenerarimagen.TabIndex = 11;
            this.btngenerarimagen.Text = "Generar Imagen";
            this.btngenerarimagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarimagen.UseVisualStyleBackColor = false;
            this.btngenerarimagen.Click += new System.EventHandler(this.btngenerarimagen_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 158);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(671, 34);
            this.progressBar1.TabIndex = 12;
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsalir.ForeColor = System.Drawing.Color.Black;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.btnsalir.IconColor = System.Drawing.Color.Black;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 40;
            this.btnsalir.Location = new System.Drawing.Point(691, 140);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(125, 52);
            this.btnsalir.TabIndex = 13;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(827, 206);
            this.ControlBox = false;
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btngenerarimagen);
            this.Controls.Add(this.btngenerardocumento);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(843, 245);
            this.MinimumSize = new System.Drawing.Size(843, 245);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma Manual";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtnumeroetiquetas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.NumericUpDown txtnumeroetiquetas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkmostrardescripcion;
        private System.Windows.Forms.CheckBox chkmostrarcodigo;
        private System.Windows.Forms.ComboBox cboorientacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbotipocodigo;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btngenerardocumento;
        private FontAwesome.Sharp.IconButton btngenerarimagen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private FontAwesome.Sharp.IconButton btnsalir;
    }
}

