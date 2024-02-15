namespace Costazul
{
    partial class menuEstacionamiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuEstacionamiento));
            this.fondo = new System.Windows.Forms.PictureBox();
            this.sectorMangle = new System.Windows.Forms.PictureBox();
            this.sectorPalma = new System.Windows.Forms.PictureBox();
            this.sectorSaman = new System.Windows.Forms.PictureBox();
            this.sectorRoble = new System.Windows.Forms.PictureBox();
            this.sectorGuayacan = new System.Windows.Forms.PictureBox();
            this.sectorBambu1 = new System.Windows.Forms.PictureBox();
            this.sectorBambu2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNPuestos = new System.Windows.Forms.ComboBox();
            this.personaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonContinuar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorMangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorPalma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSaman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorRoble)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGuayacan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBambu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBambu2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.Image = global::Costazul.Properties.Resources.MapaCostazul;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(1665, 642);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // sectorMangle
            // 
            this.sectorMangle.Location = new System.Drawing.Point(113, 289);
            this.sectorMangle.Name = "sectorMangle";
            this.sectorMangle.Size = new System.Drawing.Size(184, 144);
            this.sectorMangle.TabIndex = 2;
            this.sectorMangle.TabStop = false;
            this.sectorMangle.Click += new System.EventHandler(this.sectorMangle_Click);
            // 
            // sectorPalma
            // 
            this.sectorPalma.BackColor = System.Drawing.SystemColors.Control;
            this.sectorPalma.Location = new System.Drawing.Point(22, 138);
            this.sectorPalma.Name = "sectorPalma";
            this.sectorPalma.Size = new System.Drawing.Size(153, 110);
            this.sectorPalma.TabIndex = 1;
            this.sectorPalma.TabStop = false;
            this.sectorPalma.Click += new System.EventHandler(this.sectorPalma_Click);
            // 
            // sectorSaman
            // 
            this.sectorSaman.Location = new System.Drawing.Point(337, 393);
            this.sectorSaman.Name = "sectorSaman";
            this.sectorSaman.Size = new System.Drawing.Size(224, 119);
            this.sectorSaman.TabIndex = 3;
            this.sectorSaman.TabStop = false;
            this.sectorSaman.Click += new System.EventHandler(this.sectorSaman_Click);
            // 
            // sectorRoble
            // 
            this.sectorRoble.Location = new System.Drawing.Point(618, 529);
            this.sectorRoble.Name = "sectorRoble";
            this.sectorRoble.Size = new System.Drawing.Size(465, 50);
            this.sectorRoble.TabIndex = 4;
            this.sectorRoble.TabStop = false;
            this.sectorRoble.Click += new System.EventHandler(this.sectorRoble_Click);
            // 
            // sectorGuayacan
            // 
            this.sectorGuayacan.Location = new System.Drawing.Point(1283, 493);
            this.sectorGuayacan.Name = "sectorGuayacan";
            this.sectorGuayacan.Size = new System.Drawing.Size(227, 86);
            this.sectorGuayacan.TabIndex = 5;
            this.sectorGuayacan.TabStop = false;
            this.sectorGuayacan.Click += new System.EventHandler(this.sectorGuayacan_Click);
            // 
            // sectorBambu1
            // 
            this.sectorBambu1.Location = new System.Drawing.Point(1568, 261);
            this.sectorBambu1.Name = "sectorBambu1";
            this.sectorBambu1.Size = new System.Drawing.Size(72, 318);
            this.sectorBambu1.TabIndex = 6;
            this.sectorBambu1.TabStop = false;
            this.sectorBambu1.Click += new System.EventHandler(this.sectorBambu1_Click);
            // 
            // sectorBambu2
            // 
            this.sectorBambu2.Location = new System.Drawing.Point(1537, 86);
            this.sectorBambu2.Name = "sectorBambu2";
            this.sectorBambu2.Size = new System.Drawing.Size(73, 139);
            this.sectorBambu2.TabIndex = 7;
            this.sectorBambu2.TabStop = false;
            this.sectorBambu2.Click += new System.EventHandler(this.sectorBambu2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBoxNPuestos, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(577, 176);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(326, 119);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor, indique el numero de puesto:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxNPuestos
            // 
            this.comboBoxNPuestos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxNPuestos.DropDownHeight = 200;
            this.comboBoxNPuestos.FormattingEnabled = true;
            this.comboBoxNPuestos.IntegralHeight = false;
            this.comboBoxNPuestos.Location = new System.Drawing.Point(130, 77);
            this.comboBoxNPuestos.MaxDropDownItems = 10;
            this.comboBoxNPuestos.Name = "comboBoxNPuestos";
            this.comboBoxNPuestos.Size = new System.Drawing.Size(65, 24);
            this.comboBoxNPuestos.TabIndex = 1;
            // 
            // personaBindingSource
            // 
            this.personaBindingSource.DataSource = typeof(Costazul.persona);
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Location = new System.Drawing.Point(1008, 225);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(114, 52);
            this.buttonContinuar.TabIndex = 8;
            this.buttonContinuar.Text = "Continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // menuEstacionamiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1665, 642);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.sectorBambu2);
            this.Controls.Add(this.sectorBambu1);
            this.Controls.Add(this.sectorGuayacan);
            this.Controls.Add(this.sectorRoble);
            this.Controls.Add(this.sectorSaman);
            this.Controls.Add(this.sectorMangle);
            this.Controls.Add(this.sectorPalma);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "menuEstacionamiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione su puesto";
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorMangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorPalma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorSaman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorRoble)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorGuayacan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBambu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectorBambu2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.PictureBox sectorMangle;
        private System.Windows.Forms.PictureBox sectorPalma;
        private System.Windows.Forms.PictureBox sectorSaman;
        private System.Windows.Forms.PictureBox sectorRoble;
        private System.Windows.Forms.PictureBox sectorGuayacan;
        private System.Windows.Forms.PictureBox sectorBambu1;
        private System.Windows.Forms.PictureBox sectorBambu2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNPuestos;
        private System.Windows.Forms.BindingSource personaBindingSource;
        private System.Windows.Forms.Button buttonContinuar;
    }
}