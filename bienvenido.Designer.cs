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
            this.ButtonConfirmar = new System.Windows.Forms.Button();
            this.comboBoxDia = new System.Windows.Forms.ComboBox();
            this.comboBoxHora = new System.Windows.Forms.ComboBox();
            this.comboBoxMinuto = new System.Windows.Forms.ComboBox();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonConfirmar
            // 
            this.ButtonConfirmar.Enabled = false;
            this.ButtonConfirmar.Location = new System.Drawing.Point(187, 550);
            this.ButtonConfirmar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonConfirmar.Name = "ButtonConfirmar";
            this.ButtonConfirmar.Size = new System.Drawing.Size(123, 38);
            this.ButtonConfirmar.TabIndex = 2;
            this.ButtonConfirmar.Text = "CONFIRMAR";
            this.ButtonConfirmar.UseVisualStyleBackColor = true;
            this.ButtonConfirmar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // comboBoxDia
            // 
            this.comboBoxDia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDia.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDia.FormattingEnabled = true;
            this.comboBoxDia.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes",
            "Sábado",
            "Domingo"});
            this.comboBoxDia.Location = new System.Drawing.Point(39, 455);
            this.comboBoxDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDia.Name = "comboBoxDia";
            this.comboBoxDia.Size = new System.Drawing.Size(128, 32);
            this.comboBoxDia.TabIndex = 3;
            this.comboBoxDia.SelectedIndexChanged += new System.EventHandler(this.comboBoxDia_SelectedIndexChanged);
            // 
            // comboBoxHora
            // 
            this.comboBoxHora.DropDownHeight = 90;
            this.comboBoxHora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHora.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxHora.FormattingEnabled = true;
            this.comboBoxHora.IntegralHeight = false;
            this.comboBoxHora.Location = new System.Drawing.Point(239, 455);
            this.comboBoxHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxHora.Name = "comboBoxHora";
            this.comboBoxHora.Size = new System.Drawing.Size(84, 32);
            this.comboBoxHora.TabIndex = 4;
            this.comboBoxHora.Visible = false;
            this.comboBoxHora.SelectedIndexChanged += new System.EventHandler(this.comboBoxHora_SelectedIndexChanged);
            // 
            // comboBoxMinuto
            // 
            this.comboBoxMinuto.DropDownHeight = 90;
            this.comboBoxMinuto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinuto.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMinuto.FormattingEnabled = true;
            this.comboBoxMinuto.IntegralHeight = false;
            this.comboBoxMinuto.Location = new System.Drawing.Point(352, 455);
            this.comboBoxMinuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMinuto.Name = "comboBoxMinuto";
            this.comboBoxMinuto.Size = new System.Drawing.Size(78, 32);
            this.comboBoxMinuto.TabIndex = 5;
            this.comboBoxMinuto.Visible = false;
            this.comboBoxMinuto.SelectedIndexChanged += new System.EventHandler(this.comboBoxMinuto_SelectedIndexChanged);
            this.comboBoxMinuto.VisibleChanged += new System.EventHandler(this.comboBoxMinuto_VisibleChanged);
            // 
            // fondo
            // 
            this.fondo.Image = global::Costazul.Properties.Resources.Bienvenido;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(488, 625);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 6;
            this.fondo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese el dia y hora actual.";
            // 
            // bienvenido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(488, 625);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMinuto);
            this.Controls.Add(this.comboBoxHora);
            this.Controls.Add(this.comboBoxDia);
            this.Controls.Add(this.ButtonConfirmar);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonConfirmar;
        private System.Windows.Forms.ComboBox comboBoxDia;
        private System.Windows.Forms.ComboBox comboBoxHora;
        private System.Windows.Forms.ComboBox comboBoxMinuto;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Label label1;
    }
}

