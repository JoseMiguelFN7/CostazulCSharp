using System;

namespace Costazul
{
    partial class formRegistroUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formRegistroUsuarios));
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido = new System.Windows.Forms.TextBox();
            this.textBoxNDocumento = new System.Windows.Forms.TextBox();
            this.comboBoxTDocumento = new System.Windows.Forms.ComboBox();
            this.LabelPrimerNombre = new System.Windows.Forms.Label();
            this.LabelApellido = new System.Windows.Forms.Label();
            this.LabelDocumento = new System.Windows.Forms.Label();
            this.IndiqueHoraDeSalida = new System.Windows.Forms.Label();
            this.comboBoxHoraDeSalida = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutoDeSalida = new System.Windows.Forms.ComboBox();
            this.buttonValidacionRegistro = new System.Windows.Forms.Button();
            this.fondo = new System.Windows.Forms.PictureBox();
            this.checkBoxPVehiculo = new System.Windows.Forms.CheckBox();
            this.comboBoxTVehiculo = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.comboBoxColor = new System.Windows.Forms.ComboBox();
            this.textBoxPlaca = new System.Windows.Forms.TextBox();
            this.comboBoxNAcomp = new System.Windows.Forms.ComboBox();
            this.labelTVehiculo = new System.Windows.Forms.Label();
            this.labelCAcomp = new System.Windows.Forms.Label();
            this.labelMVehiculo = new System.Windows.Forms.Label();
            this.labelCVehiculo = new System.Windows.Forms.Label();
            this.labelPVehiculo = new System.Windows.Forms.Label();
            this.labelErrorPrimerNombre = new System.Windows.Forms.Label();
            this.labelErrorApellido = new System.Windows.Forms.Label();
            this.labelErrorPlaca = new System.Windows.Forms.Label();
            this.labelErrorDocumento = new System.Windows.Forms.Label();
            this.marcoPanelPregunta = new System.Windows.Forms.TableLayoutPanel();
            this.panelPregunta = new System.Windows.Forms.TableLayoutPanel();
            this.panelBotonesPregunta = new System.Windows.Forms.TableLayoutPanel();
            this.buttonSiCompra = new System.Windows.Forms.Button();
            this.buttonNoCompra = new System.Windows.Forms.Button();
            this.labelPregunta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            this.marcoPanelPregunta.SuspendLayout();
            this.panelPregunta.SuspendLayout();
            this.panelBotonesPregunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(41, 63);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(186, 30);
            this.textBoxNombre.TabIndex = 0;
            this.textBoxNombre.TabStop = false;
            // 
            // textBoxApellido
            // 
            this.textBoxApellido.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellido.Location = new System.Drawing.Point(41, 135);
            this.textBoxApellido.Name = "textBoxApellido";
            this.textBoxApellido.Size = new System.Drawing.Size(174, 30);
            this.textBoxApellido.TabIndex = 1;
            // 
            // textBoxNDocumento
            // 
            this.textBoxNDocumento.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNDocumento.Location = new System.Drawing.Point(94, 218);
            this.textBoxNDocumento.Name = "textBoxNDocumento";
            this.textBoxNDocumento.Size = new System.Drawing.Size(154, 30);
            this.textBoxNDocumento.TabIndex = 3;
            // 
            // comboBoxTDocumento
            // 
            this.comboBoxTDocumento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTDocumento.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxTDocumento.FormattingEnabled = true;
            this.comboBoxTDocumento.Items.AddRange(new object[] {
            "V",
            "E",
            "J",
            "G",
            "P"});
            this.comboBoxTDocumento.Location = new System.Drawing.Point(47, 218);
            this.comboBoxTDocumento.Name = "comboBoxTDocumento";
            this.comboBoxTDocumento.Size = new System.Drawing.Size(45, 30);
            this.comboBoxTDocumento.TabIndex = 2;
            // 
            // LabelPrimerNombre
            // 
            this.LabelPrimerNombre.BackColor = System.Drawing.Color.Transparent;
            this.LabelPrimerNombre.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrimerNombre.Location = new System.Drawing.Point(42, 31);
            this.LabelPrimerNombre.Name = "LabelPrimerNombre";
            this.LabelPrimerNombre.Size = new System.Drawing.Size(172, 29);
            this.LabelPrimerNombre.TabIndex = 0;
            this.LabelPrimerNombre.Text = "Primer Nombre:";
            // 
            // LabelApellido
            // 
            this.LabelApellido.BackColor = System.Drawing.Color.Transparent;
            this.LabelApellido.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelApellido.Location = new System.Drawing.Point(42, 102);
            this.LabelApellido.Name = "LabelApellido";
            this.LabelApellido.Size = new System.Drawing.Size(91, 29);
            this.LabelApellido.TabIndex = 8;
            this.LabelApellido.Text = "Apellido:";
            // 
            // LabelDocumento
            // 
            this.LabelDocumento.BackColor = System.Drawing.Color.Transparent;
            this.LabelDocumento.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDocumento.Location = new System.Drawing.Point(38, 178);
            this.LabelDocumento.Name = "LabelDocumento";
            this.LabelDocumento.Size = new System.Drawing.Size(129, 29);
            this.LabelDocumento.TabIndex = 9;
            this.LabelDocumento.Text = "Documento:";
            // 
            // IndiqueHoraDeSalida
            // 
            this.IndiqueHoraDeSalida.BackColor = System.Drawing.Color.Transparent;
            this.IndiqueHoraDeSalida.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IndiqueHoraDeSalida.Location = new System.Drawing.Point(90, 277);
            this.IndiqueHoraDeSalida.Name = "IndiqueHoraDeSalida";
            this.IndiqueHoraDeSalida.Size = new System.Drawing.Size(285, 29);
            this.IndiqueHoraDeSalida.TabIndex = 10;
            this.IndiqueHoraDeSalida.Text = "Indique su hora de salida:";
            // 
            // comboBoxHoraDeSalida
            // 
            this.comboBoxHoraDeSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxHoraDeSalida.FormattingEnabled = true;
            this.comboBoxHoraDeSalida.Location = new System.Drawing.Point(160, 319);
            this.comboBoxHoraDeSalida.Name = "comboBoxHoraDeSalida";
            this.comboBoxHoraDeSalida.Size = new System.Drawing.Size(43, 21);
            this.comboBoxHoraDeSalida.TabIndex = 11;
            this.comboBoxHoraDeSalida.SelectedIndexChanged += new System.EventHandler(this.comboBoxHora_SelectedIndexChanged);
            // 
            // comboBoxMinutoDeSalida
            // 
            this.comboBoxMinutoDeSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMinutoDeSalida.FormattingEnabled = true;
            this.comboBoxMinutoDeSalida.Location = new System.Drawing.Point(237, 319);
            this.comboBoxMinutoDeSalida.Name = "comboBoxMinutoDeSalida";
            this.comboBoxMinutoDeSalida.Size = new System.Drawing.Size(43, 21);
            this.comboBoxMinutoDeSalida.TabIndex = 12;
            // 
            // buttonValidacionRegistro
            // 
            this.buttonValidacionRegistro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidacionRegistro.Location = new System.Drawing.Point(200, 658);
            this.buttonValidacionRegistro.Margin = new System.Windows.Forms.Padding(2);
            this.buttonValidacionRegistro.Name = "buttonValidacionRegistro";
            this.buttonValidacionRegistro.Size = new System.Drawing.Size(106, 47);
            this.buttonValidacionRegistro.TabIndex = 13;
            this.buttonValidacionRegistro.Text = "Confirmar.";
            this.buttonValidacionRegistro.UseVisualStyleBackColor = true;
            this.buttonValidacionRegistro.Click += new System.EventHandler(this.ButtonValidacionRegistro_Click);
            // 
            // fondo
            // 
            this.fondo.Image = ((System.Drawing.Image)(resources.GetObject("fondo.Image")));
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Margin = new System.Windows.Forms.Padding(2);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(505, 731);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 14;
            this.fondo.TabStop = false;
            // 
            // checkBoxPVehiculo
            // 
            this.checkBoxPVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPVehiculo.Location = new System.Drawing.Point(47, 357);
            this.checkBoxPVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxPVehiculo.Name = "checkBoxPVehiculo";
            this.checkBoxPVehiculo.Size = new System.Drawing.Size(154, 31);
            this.checkBoxPVehiculo.TabIndex = 15;
            this.checkBoxPVehiculo.Text = "Posee vehículo";
            this.checkBoxPVehiculo.UseVisualStyleBackColor = false;
            this.checkBoxPVehiculo.CheckedChanged += new System.EventHandler(this.checkBoxPVehiculo_CheckedChanged);
            // 
            // comboBoxTVehiculo
            // 
            this.comboBoxTVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTVehiculo.FormattingEnabled = true;
            this.comboBoxTVehiculo.Items.AddRange(new object[] {
            "Camioneta (Pick-Up)",
            "Camioneta (Sport Wagon)",
            "Carro pequeño (2 puertas)",
            "Moto",
            "Sedan (4 puertas)"});
            this.comboBoxTVehiculo.Location = new System.Drawing.Point(287, 431);
            this.comboBoxTVehiculo.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxTVehiculo.Name = "comboBoxTVehiculo";
            this.comboBoxTVehiculo.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTVehiculo.TabIndex = 16;
            this.comboBoxTVehiculo.Visible = false;
            this.comboBoxTVehiculo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTVehiculo_SelectedIndexChanged);
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Items.AddRange(new object[] {
            "Mitsubishi",
            "Nissan",
            "Peugeot",
            "Renault",
            "Seat",
            "Skygo",
            "Subaru",
            "Suzuki",
            "Tesla",
            "Toyota",
            "Vespa",
            "Volkswagen",
            "Yamaha",
            "Otro..."});
            this.comboBoxMarca.Location = new System.Drawing.Point(287, 510);
            this.comboBoxMarca.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(92, 21);
            this.comboBoxMarca.TabIndex = 17;
            this.comboBoxMarca.Visible = false;
            // 
            // comboBoxColor
            // 
            this.comboBoxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxColor.FormattingEnabled = true;
            this.comboBoxColor.Items.AddRange(new object[] {
            "Amarillo",
            "Azul",
            "Blanco",
            "Gris",
            "Marrón",
            "Morado",
            "Naranja",
            "Negro",
            "Plateado",
            "Rojo",
            "Rosa",
            "Verde"});
            this.comboBoxColor.Location = new System.Drawing.Point(287, 548);
            this.comboBoxColor.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxColor.Name = "comboBoxColor";
            this.comboBoxColor.Size = new System.Drawing.Size(92, 21);
            this.comboBoxColor.TabIndex = 18;
            this.comboBoxColor.Visible = false;
            // 
            // textBoxPlaca
            // 
            this.textBoxPlaca.Location = new System.Drawing.Point(287, 583);
            this.textBoxPlaca.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxPlaca.Name = "textBoxPlaca";
            this.textBoxPlaca.Size = new System.Drawing.Size(76, 20);
            this.textBoxPlaca.TabIndex = 19;
            this.textBoxPlaca.Visible = false;
            // 
            // comboBoxNAcomp
            // 
            this.comboBoxNAcomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNAcomp.FormattingEnabled = true;
            this.comboBoxNAcomp.Location = new System.Drawing.Point(284, 468);
            this.comboBoxNAcomp.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxNAcomp.Name = "comboBoxNAcomp";
            this.comboBoxNAcomp.Size = new System.Drawing.Size(92, 21);
            this.comboBoxNAcomp.TabIndex = 20;
            this.comboBoxNAcomp.Visible = false;
            // 
            // labelTVehiculo
            // 
            this.labelTVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelTVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTVehiculo.Location = new System.Drawing.Point(128, 429);
            this.labelTVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTVehiculo.Name = "labelTVehiculo";
            this.labelTVehiculo.Size = new System.Drawing.Size(152, 28);
            this.labelTVehiculo.TabIndex = 21;
            this.labelTVehiculo.Text = "Tipo de vehículo:";
            this.labelTVehiculo.Visible = false;
            // 
            // labelCAcomp
            // 
            this.labelCAcomp.BackColor = System.Drawing.Color.Transparent;
            this.labelCAcomp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCAcomp.Location = new System.Drawing.Point(41, 468);
            this.labelCAcomp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCAcomp.Name = "labelCAcomp";
            this.labelCAcomp.Size = new System.Drawing.Size(239, 20);
            this.labelCAcomp.TabIndex = 22;
            this.labelCAcomp.Text = "Cantidad de acompañantes:";
            this.labelCAcomp.Visible = false;
            // 
            // labelMVehiculo
            // 
            this.labelMVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelMVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMVehiculo.Location = new System.Drawing.Point(105, 510);
            this.labelMVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMVehiculo.Name = "labelMVehiculo";
            this.labelMVehiculo.Size = new System.Drawing.Size(172, 20);
            this.labelMVehiculo.TabIndex = 23;
            this.labelMVehiculo.Text = "Marca del vehículo:";
            this.labelMVehiculo.Visible = false;
            // 
            // labelCVehiculo
            // 
            this.labelCVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelCVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCVehiculo.Location = new System.Drawing.Point(109, 549);
            this.labelCVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCVehiculo.Name = "labelCVehiculo";
            this.labelCVehiculo.Size = new System.Drawing.Size(168, 20);
            this.labelCVehiculo.TabIndex = 24;
            this.labelCVehiculo.Text = "Color del vehículo:";
            this.labelCVehiculo.Visible = false;
            // 
            // labelPVehiculo
            // 
            this.labelPVehiculo.BackColor = System.Drawing.Color.Transparent;
            this.labelPVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPVehiculo.Location = new System.Drawing.Point(112, 583);
            this.labelPVehiculo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPVehiculo.Name = "labelPVehiculo";
            this.labelPVehiculo.Size = new System.Drawing.Size(157, 35);
            this.labelPVehiculo.TabIndex = 25;
            this.labelPVehiculo.Text = "Placa del vehículo:";
            this.labelPVehiculo.Visible = false;
            // 
            // labelErrorPrimerNombre
            // 
            this.labelErrorPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPrimerNombre.Location = new System.Drawing.Point(233, 63);
            this.labelErrorPrimerNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorPrimerNombre.Name = "labelErrorPrimerNombre";
            this.labelErrorPrimerNombre.Size = new System.Drawing.Size(202, 19);
            this.labelErrorPrimerNombre.TabIndex = 26;
            this.labelErrorPrimerNombre.Text = "CARÁCTER NO VÁLIDO";
            this.labelErrorPrimerNombre.Visible = false;
            // 
            // labelErrorApellido
            // 
            this.labelErrorApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorApellido.Location = new System.Drawing.Point(233, 140);
            this.labelErrorApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorApellido.Name = "labelErrorApellido";
            this.labelErrorApellido.Size = new System.Drawing.Size(202, 24);
            this.labelErrorApellido.TabIndex = 27;
            this.labelErrorApellido.Text = "CARÁCTER NO VÁLIDO";
            this.labelErrorApellido.Visible = false;
            // 
            // labelErrorPlaca
            // 
            this.labelErrorPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorPlaca.Location = new System.Drawing.Point(230, 618);
            this.labelErrorPlaca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorPlaca.Name = "labelErrorPlaca";
            this.labelErrorPlaca.Size = new System.Drawing.Size(205, 20);
            this.labelErrorPlaca.TabIndex = 28;
            this.labelErrorPlaca.Text = "CARÁCTER NO VÁLIDO";
            this.labelErrorPlaca.Visible = false;
            // 
            // labelErrorDocumento
            // 
            this.labelErrorDocumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorDocumento.Location = new System.Drawing.Point(253, 223);
            this.labelErrorDocumento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelErrorDocumento.Name = "labelErrorDocumento";
            this.labelErrorDocumento.Size = new System.Drawing.Size(202, 20);
            this.labelErrorDocumento.TabIndex = 29;
            this.labelErrorDocumento.Text = "CARÁCTER NO VÁLIDO";
            this.labelErrorDocumento.Visible = false;
            // 
            // marcoPanelPregunta
            // 
            this.marcoPanelPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marcoPanelPregunta.ColumnCount = 1;
            this.marcoPanelPregunta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoPanelPregunta.Controls.Add(this.panelPregunta, 0, 0);
            this.marcoPanelPregunta.Location = new System.Drawing.Point(133, 296);
            this.marcoPanelPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.marcoPanelPregunta.Name = "marcoPanelPregunta";
            this.marcoPanelPregunta.Padding = new System.Windows.Forms.Padding(2);
            this.marcoPanelPregunta.RowCount = 1;
            this.marcoPanelPregunta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoPanelPregunta.Size = new System.Drawing.Size(240, 141);
            this.marcoPanelPregunta.TabIndex = 30;
            this.marcoPanelPregunta.Visible = false;
            // 
            // panelPregunta
            // 
            this.panelPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panelPregunta.ColumnCount = 1;
            this.panelPregunta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPregunta.Controls.Add(this.panelBotonesPregunta, 0, 1);
            this.panelPregunta.Controls.Add(this.labelPregunta, 0, 0);
            this.panelPregunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPregunta.Location = new System.Drawing.Point(4, 4);
            this.panelPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.panelPregunta.Name = "panelPregunta";
            this.panelPregunta.RowCount = 2;
            this.panelPregunta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPregunta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelPregunta.Size = new System.Drawing.Size(232, 133);
            this.panelPregunta.TabIndex = 0;
            // 
            // panelBotonesPregunta
            // 
            this.panelBotonesPregunta.ColumnCount = 2;
            this.panelBotonesPregunta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBotonesPregunta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBotonesPregunta.Controls.Add(this.buttonSiCompra, 0, 0);
            this.panelBotonesPregunta.Controls.Add(this.buttonNoCompra, 1, 0);
            this.panelBotonesPregunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBotonesPregunta.Location = new System.Drawing.Point(2, 68);
            this.panelBotonesPregunta.Margin = new System.Windows.Forms.Padding(2);
            this.panelBotonesPregunta.Name = "panelBotonesPregunta";
            this.panelBotonesPregunta.RowCount = 1;
            this.panelBotonesPregunta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.panelBotonesPregunta.Size = new System.Drawing.Size(228, 63);
            this.panelBotonesPregunta.TabIndex = 0;
            // 
            // buttonSiCompra
            // 
            this.buttonSiCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSiCompra.Location = new System.Drawing.Point(19, 11);
            this.buttonSiCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSiCompra.Name = "buttonSiCompra";
            this.buttonSiCompra.Size = new System.Drawing.Size(75, 41);
            this.buttonSiCompra.TabIndex = 0;
            this.buttonSiCompra.Text = "Sí";
            this.buttonSiCompra.UseVisualStyleBackColor = true;
            this.buttonSiCompra.Click += new System.EventHandler(this.buttonSiCompra_Click);
            // 
            // buttonNoCompra
            // 
            this.buttonNoCompra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonNoCompra.Location = new System.Drawing.Point(133, 11);
            this.buttonNoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.buttonNoCompra.Name = "buttonNoCompra";
            this.buttonNoCompra.Size = new System.Drawing.Size(75, 41);
            this.buttonNoCompra.TabIndex = 1;
            this.buttonNoCompra.Text = "No";
            this.buttonNoCompra.UseVisualStyleBackColor = true;
            this.buttonNoCompra.Click += new System.EventHandler(this.buttonNoCompra_Click);
            // 
            // labelPregunta
            // 
            this.labelPregunta.AutoSize = true;
            this.labelPregunta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPregunta.Location = new System.Drawing.Point(2, 0);
            this.labelPregunta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPregunta.Name = "labelPregunta";
            this.labelPregunta.Size = new System.Drawing.Size(228, 66);
            this.labelPregunta.TabIndex = 1;
            this.labelPregunta.Text = "¿Desea realizar una compra?";
            this.labelPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formRegistroUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 716);
            this.Controls.Add(this.marcoPanelPregunta);
            this.Controls.Add(this.labelErrorDocumento);
            this.Controls.Add(this.labelErrorPlaca);
            this.Controls.Add(this.labelErrorApellido);
            this.Controls.Add(this.labelErrorPrimerNombre);
            this.Controls.Add(this.labelPVehiculo);
            this.Controls.Add(this.labelCVehiculo);
            this.Controls.Add(this.labelMVehiculo);
            this.Controls.Add(this.labelCAcomp);
            this.Controls.Add(this.labelTVehiculo);
            this.Controls.Add(this.comboBoxNAcomp);
            this.Controls.Add(this.textBoxPlaca);
            this.Controls.Add(this.comboBoxColor);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxTVehiculo);
            this.Controls.Add(this.checkBoxPVehiculo);
            this.Controls.Add(this.buttonValidacionRegistro);
            this.Controls.Add(this.comboBoxMinutoDeSalida);
            this.Controls.Add(this.comboBoxHoraDeSalida);
            this.Controls.Add(this.IndiqueHoraDeSalida);
            this.Controls.Add(this.LabelDocumento);
            this.Controls.Add(this.LabelApellido);
            this.Controls.Add(this.LabelPrimerNombre);
            this.Controls.Add(this.comboBoxTDocumento);
            this.Controls.Add(this.textBoxNDocumento);
            this.Controls.Add(this.textBoxApellido);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formRegistroUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese sus datos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formRegistroUsuarios_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            this.marcoPanelPregunta.ResumeLayout(false);
            this.panelPregunta.ResumeLayout(false);
            this.panelPregunta.PerformLayout();
            this.panelBotonesPregunta.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido;
        private System.Windows.Forms.TextBox textBoxNDocumento;
        private System.Windows.Forms.ComboBox comboBoxTDocumento;
        private System.Windows.Forms.Label LabelPrimerNombre;
        private System.Windows.Forms.Label LabelApellido;
        private System.Windows.Forms.Label LabelDocumento;
        private System.Windows.Forms.Label IndiqueHoraDeSalida;
        private System.Windows.Forms.ComboBox comboBoxHoraDeSalida;
        private System.Windows.Forms.ComboBox comboBoxMinutoDeSalida;
        private System.Windows.Forms.Button buttonValidacionRegistro;
        private System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.CheckBox checkBoxPVehiculo;
        private System.Windows.Forms.ComboBox comboBoxTVehiculo;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.ComboBox comboBoxColor;
        private System.Windows.Forms.TextBox textBoxPlaca;
        private System.Windows.Forms.ComboBox comboBoxNAcomp;
        private System.Windows.Forms.Label labelTVehiculo;
        private System.Windows.Forms.Label labelCAcomp;
        private System.Windows.Forms.Label labelMVehiculo;
        private System.Windows.Forms.Label labelCVehiculo;
        private System.Windows.Forms.Label labelPVehiculo;
        private System.Windows.Forms.Label labelErrorPrimerNombre;
        private System.Windows.Forms.Label labelErrorApellido;
        private System.Windows.Forms.Label labelErrorPlaca;
        private System.Windows.Forms.Label labelErrorDocumento;
        private System.Windows.Forms.TableLayoutPanel marcoPanelPregunta;
        private System.Windows.Forms.TableLayoutPanel panelPregunta;
        private System.Windows.Forms.TableLayoutPanel panelBotonesPregunta;
        private System.Windows.Forms.Button buttonSiCompra;
        private System.Windows.Forms.Button buttonNoCompra;
        private System.Windows.Forms.Label labelPregunta;
    }
}