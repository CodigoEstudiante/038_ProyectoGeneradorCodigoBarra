namespace ProyectoBarras
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.btnsalir = new FontAwesome.Sharp.IconButton();
            this.btngenerarmanualmente = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btngenerarmasivamente = new FontAwesome.Sharp.IconButton();
            this.btninformacionrapida = new FontAwesome.Sharp.IconButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalir.ForeColor = System.Drawing.Color.White;
            this.btnsalir.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnsalir.IconColor = System.Drawing.Color.White;
            this.btnsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnsalir.IconSize = 35;
            this.btnsalir.Location = new System.Drawing.Point(563, 21);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(53, 54);
            this.btnsalir.TabIndex = 16;
            this.btnsalir.Text = "Salir";
            this.btnsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnsalir.UseVisualStyleBackColor = false;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btngenerarmanualmente
            // 
            this.btngenerarmanualmente.BackColor = System.Drawing.SystemColors.Control;
            this.btngenerarmanualmente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarmanualmente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btngenerarmanualmente.FlatAppearance.BorderSize = 2;
            this.btngenerarmanualmente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarmanualmente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarmanualmente.ForeColor = System.Drawing.Color.Black;
            this.btngenerarmanualmente.IconChar = FontAwesome.Sharp.IconChar.Barcode;
            this.btngenerarmanualmente.IconColor = System.Drawing.Color.Black;
            this.btngenerarmanualmente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarmanualmente.IconSize = 100;
            this.btngenerarmanualmente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerarmanualmente.Location = new System.Drawing.Point(71, 109);
            this.btngenerarmanualmente.Name = "btngenerarmanualmente";
            this.btngenerarmanualmente.Size = new System.Drawing.Size(143, 134);
            this.btngenerarmanualmente.TabIndex = 15;
            this.btngenerarmanualmente.Text = "Generar Manualmente";
            this.btngenerarmanualmente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarmanualmente.UseVisualStyleBackColor = false;
            this.btngenerarmanualmente.Click += new System.EventHandler(this.btngenerarmanualmente_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(626, 87);
            this.label1.TabIndex = 14;
            this.label1.Text = "CE GENERADOR DE CODIGO BARRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btngenerarmasivamente
            // 
            this.btngenerarmasivamente.BackColor = System.Drawing.SystemColors.Control;
            this.btngenerarmasivamente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btngenerarmasivamente.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btngenerarmasivamente.FlatAppearance.BorderSize = 2;
            this.btngenerarmasivamente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btngenerarmasivamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngenerarmasivamente.ForeColor = System.Drawing.Color.Black;
            this.btngenerarmasivamente.IconChar = FontAwesome.Sharp.IconChar.Boxes;
            this.btngenerarmasivamente.IconColor = System.Drawing.Color.Black;
            this.btngenerarmasivamente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btngenerarmasivamente.IconSize = 100;
            this.btngenerarmasivamente.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btngenerarmasivamente.Location = new System.Drawing.Point(237, 109);
            this.btngenerarmasivamente.Name = "btngenerarmasivamente";
            this.btngenerarmasivamente.Size = new System.Drawing.Size(143, 134);
            this.btngenerarmasivamente.TabIndex = 13;
            this.btngenerarmasivamente.Text = "Generar Masivamente";
            this.btngenerarmasivamente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btngenerarmasivamente.UseVisualStyleBackColor = false;
            this.btngenerarmasivamente.Click += new System.EventHandler(this.btngenerarmasivamente_Click);
            // 
            // btninformacionrapida
            // 
            this.btninformacionrapida.BackColor = System.Drawing.SystemColors.Control;
            this.btninformacionrapida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninformacionrapida.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btninformacionrapida.FlatAppearance.BorderSize = 2;
            this.btninformacionrapida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninformacionrapida.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninformacionrapida.ForeColor = System.Drawing.Color.Black;
            this.btninformacionrapida.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.btninformacionrapida.IconColor = System.Drawing.Color.Black;
            this.btninformacionrapida.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninformacionrapida.IconSize = 100;
            this.btninformacionrapida.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btninformacionrapida.Location = new System.Drawing.Point(404, 109);
            this.btninformacionrapida.Name = "btninformacionrapida";
            this.btninformacionrapida.Size = new System.Drawing.Size(143, 134);
            this.btninformacionrapida.TabIndex = 18;
            this.btninformacionrapida.Text = "Informacion Rápida";
            this.btninformacionrapida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btninformacionrapida.UseVisualStyleBackColor = false;
            this.btninformacionrapida.Click += new System.EventHandler(this.btninformacionrapida_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 265);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(626, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(104, 17);
            this.toolStripStatusLabel1.Text = "Codigo Estudiante";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(292, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 13);
            this.label4.TabIndex = 47;
            this.label4.Text = "Todos los derechos reservados Ⓒ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.linkLabel1.Location = new System.Drawing.Point(460, 270);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(147, 13);
            this.linkLabel1.TabIndex = 55;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Open Source - CLICK AQUI !!";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "(Prohibido su venta)";
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(626, 287);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btninformacionrapida);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btngenerarmanualmente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btngenerarmasivamente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.frmInicio_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnsalir;
        private FontAwesome.Sharp.IconButton btngenerarmanualmente;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btngenerarmasivamente;
        private FontAwesome.Sharp.IconButton btninformacionrapida;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label label2;
    }
}