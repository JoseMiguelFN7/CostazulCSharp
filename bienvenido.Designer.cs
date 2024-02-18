namespace Costazul
{
    partial class bienvenido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(bienvenido));
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuto = new System.Windows.Forms.ComboBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.Enabled = false;
            this.buttonConfirmar.Location = new System.Drawing.Point(196, 554);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirmar.TabIndex = 2;
            this.buttonConfirmar.Text = "button2";
            this.buttonConfirmar.UseVisualStyleBackColor = true;
            this.buttonConfirmar.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboBoxDia.Location = new System.Drawing.Point(39, 456);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDia.TabIndex = 3;
            this.comboBoxDia.SelectedIndexChanged += new System.EventHandler(this.comboBoxDia_SelectedIndexChanged);
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.Location = new System.Drawing.Point(187, 456);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(121, 24);
            this.comboBoxHora.TabIndex = 4;
            this.comboBoxHora.Visible = false;
            this.comboBoxHora.SelectedIndexChanged += new System.EventHandler(this.comboBoxHora_SelectedIndexChanged);
            // 
            // comboBoxMinuto
            // 
            this.comboBoxMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinuto.FormattingEnabled = true;
            this.comboBoxMinuto.Location = new System.Drawing.Point(330, 456);
            this.comboBoxMinuto.Name = "comboBoxMinuto";
            this.comboBoxMinuto.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMinuto.TabIndex = 5;
            this.comboBoxMinuto.Visible = false;
            this.comboBoxMinuto.VisibleChanged += new System.EventHandler(this.comboBoxMinuto_VisibleChanged);
            // 
            // fondo
            // 
            this.fondo.Image = global::Costazul.Properties.Resources.Bienvenido;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(488, 625);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 6;
            this.fondo.TabStop = false;
            // 
            // bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(488, 625);
            this.Controls.Add(this.comboBoxMinuto);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.buttonConfirmar);
            this.Controls.Add(this.fondo);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "bienvenido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido al sistema Costazul";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bienvenido_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxMinuto;
        private System.Windows.Forms.PictureBox fondo;
    }
}

