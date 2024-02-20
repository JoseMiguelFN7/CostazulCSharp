namespace Costazul
{
    partial class formCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCompra));
            this.fondo = new System.Windows.Forms.PictureBox();
            this.labelPdto = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelUnid = new System.Windows.Forms.Label();
            this.labelPTotal = new System.Windows.Forms.Label();
            this.labelTipoCompra = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonOnline = new System.Windows.Forms.RadioButton();
            this.radioButtonPresencial = new System.Windows.Forms.RadioButton();
            this.buttonCompra = new System.Windows.Forms.Button();
            this.comboBoxProductos = new System.Windows.Forms.ComboBox();
            this.BoxLogo2 = new System.Windows.Forms.PictureBox();
            this.labelNameTienda = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.numericUpDownUnidades = new System.Windows.Forms.NumericUpDown();
            this.groupBoxTCompra = new System.Windows.Forms.GroupBox();
            this.radioButtonPagoMovil = new System.Windows.Forms.RadioButton();
            this.radioButtonZelle = new System.Windows.Forms.RadioButton();
            this.radioButtonTransferencia = new System.Windows.Forms.RadioButton();
            this.radioButtonEfectivo = new System.Windows.Forms.RadioButton();
            this.radioButtonTDD = new System.Windows.Forms.RadioButton();
            this.radioButtonTDC = new System.Windows.Forms.RadioButton();
            this.groupBoxPOnline = new System.Windows.Forms.GroupBox();
            this.groupBoxPPresencial = new System.Windows.Forms.GroupBox();
            this.marcoMPOnline = new System.Windows.Forms.TableLayoutPanel();
            this.marcoMPPresencial = new System.Windows.Forms.TableLayoutPanel();
            this.labelAviso = new System.Windows.Forms.Label();
            this.labelErrorMP = new System.Windows.Forms.Label();
            this.labelErrorTC = new System.Windows.Forms.Label();
            this.marcoPregunta = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonOtraCompraNo = new System.Windows.Forms.Button();
            this.buttonOtraCompraSi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLogo2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnidades)).BeginInit();
            this.groupBoxTCompra.SuspendLayout();
            this.groupBoxPOnline.SuspendLayout();
            this.groupBoxPPresencial.SuspendLayout();
            this.marcoMPOnline.SuspendLayout();
            this.marcoMPPresencial.SuspendLayout();
            this.marcoPregunta.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // fondo
            // 
            this.fondo.Image = global::Costazul.Properties.Resources.fondo;
            this.fondo.Location = new System.Drawing.Point(0, 0);
            this.fondo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fondo.Name = "fondo";
            this.fondo.Size = new System.Drawing.Size(673, 900);
            this.fondo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fondo.TabIndex = 0;
            this.fondo.TabStop = false;
            // 
            // labelPdto
            // 
            this.labelPdto.AutoSize = true;
            this.labelPdto.BackColor = System.Drawing.Color.Transparent;
            this.labelPdto.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPdto.ForeColor = System.Drawing.Color.Black;
            this.labelPdto.Location = new System.Drawing.Point(40, 176);
            this.labelPdto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPdto.Name = "labelPdto";
            this.labelPdto.Size = new System.Drawing.Size(163, 36);
            this.labelPdto.TabIndex = 1;
            this.labelPdto.Text = "Producto:";
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.Location = new System.Drawing.Point(45, 437);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(121, 36);
            this.labelPrecio.TabIndex = 2;
            this.labelPrecio.Text = "Precio:";
            // 
            // labelUnid
            // 
            this.labelUnid.AutoSize = true;
            this.labelUnid.BackColor = System.Drawing.Color.Transparent;
            this.labelUnid.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUnid.Location = new System.Drawing.Point(359, 437);
            this.labelUnid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUnid.Name = "labelUnid";
            this.labelUnid.Size = new System.Drawing.Size(165, 36);
            this.labelUnid.TabIndex = 3;
            this.labelUnid.Text = "Unidades:";
            // 
            // labelPTotal
            // 
            this.labelPTotal.AutoSize = true;
            this.labelPTotal.BackColor = System.Drawing.Color.Transparent;
            this.labelPTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPTotal.Location = new System.Drawing.Point(45, 559);
            this.labelPTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPTotal.Name = "labelPTotal";
            this.labelPTotal.Size = new System.Drawing.Size(225, 36);
            this.labelPTotal.TabIndex = 4;
            this.labelPTotal.Text = "Total a pagar:";
            // 
            // labelTipoCompra
            // 
            this.labelTipoCompra.AutoSize = true;
            this.labelTipoCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoCompra.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoCompra.Location = new System.Drawing.Point(40, 661);
            this.labelTipoCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipoCompra.Name = "labelTipoCompra";
            this.labelTipoCompra.Size = new System.Drawing.Size(260, 36);
            this.labelTipoCompra.TabIndex = 5;
            this.labelTipoCompra.Text = "Tipo de compra:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 256);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.MaximumSize = new System.Drawing.Size(12, 4);
            this.textBox1.MinimumSize = new System.Drawing.Size(465, 100);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 100);
            this.textBox1.TabIndex = 7;
            // 
            // radioButtonOnline
            // 
            this.radioButtonOnline.AutoSize = true;
            this.radioButtonOnline.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOnline.Location = new System.Drawing.Point(20, 22);
            this.radioButtonOnline.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonOnline.Name = "radioButtonOnline";
            this.radioButtonOnline.Size = new System.Drawing.Size(98, 25);
            this.radioButtonOnline.TabIndex = 8;
            this.radioButtonOnline.TabStop = true;
            this.radioButtonOnline.Text = "ONLINE";
            this.radioButtonOnline.UseVisualStyleBackColor = true;
            this.radioButtonOnline.CheckedChanged += new System.EventHandler(this.radioButtonOnline_CheckedChanged);
            // 
            // radioButtonPresencial
            // 
            this.radioButtonPresencial.AutoSize = true;
            this.radioButtonPresencial.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPresencial.Location = new System.Drawing.Point(20, 58);
            this.radioButtonPresencial.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonPresencial.Name = "radioButtonPresencial";
            this.radioButtonPresencial.Size = new System.Drawing.Size(139, 25);
            this.radioButtonPresencial.TabIndex = 9;
            this.radioButtonPresencial.TabStop = true;
            this.radioButtonPresencial.Text = "PRESENCIAL";
            this.radioButtonPresencial.UseVisualStyleBackColor = true;
            this.radioButtonPresencial.CheckedChanged += new System.EventHandler(this.radioButtonPresencial_CheckedChanged);
            // 
            // buttonCompra
            // 
            this.buttonCompra.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCompra.Location = new System.Drawing.Point(177, 826);
            this.buttonCompra.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCompra.Name = "buttonCompra";
            this.buttonCompra.Size = new System.Drawing.Size(312, 49);
            this.buttonCompra.TabIndex = 10;
            this.buttonCompra.Text = "Confirmar compra.";
            this.buttonCompra.UseVisualStyleBackColor = true;
            this.buttonCompra.Click += new System.EventHandler(this.buttonCompra_Click);
            // 
            // comboBoxProductos
            // 
            this.comboBoxProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProductos.FormattingEnabled = true;
            this.comboBoxProductos.Location = new System.Drawing.Point(237, 186);
            this.comboBoxProductos.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxProductos.Name = "comboBoxProductos";
            this.comboBoxProductos.Size = new System.Drawing.Size(187, 24);
            this.comboBoxProductos.TabIndex = 11;
            this.comboBoxProductos.SelectedIndexChanged += new System.EventHandler(this.comboBoxProductos_SelectedIndexChanged);
            // 
            // BoxLogo2
            // 
            this.BoxLogo2.BackColor = System.Drawing.Color.Transparent;
            this.BoxLogo2.Location = new System.Drawing.Point(47, 28);
            this.BoxLogo2.Margin = new System.Windows.Forms.Padding(4);
            this.BoxLogo2.Name = "BoxLogo2";
            this.BoxLogo2.Size = new System.Drawing.Size(159, 118);
            this.BoxLogo2.TabIndex = 13;
            this.BoxLogo2.TabStop = false;
            // 
            // labelNameTienda
            // 
            this.labelNameTienda.AutoSize = true;
            this.labelNameTienda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNameTienda.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNameTienda.Location = new System.Drawing.Point(4, 0);
            this.labelNameTienda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNameTienda.Name = "labelNameTienda";
            this.labelNameTienda.Size = new System.Drawing.Size(243, 107);
            this.labelNameTienda.TabIndex = 15;
            this.labelNameTienda.Text = "Nombre de la tienda.";
            this.labelNameTienda.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.labelNameTienda, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 8);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(251, 107);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(268, 28);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(267, 123);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // numericUpDownUnidades
            // 
            this.numericUpDownUnidades.Location = new System.Drawing.Point(543, 442);
            this.numericUpDownUnidades.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnidades.Name = "numericUpDownUnidades";
            this.numericUpDownUnidades.Size = new System.Drawing.Size(99, 22);
            this.numericUpDownUnidades.TabIndex = 18;
            this.numericUpDownUnidades.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownUnidades.ValueChanged += new System.EventHandler(this.numericUpDownUnidades_ValueChanged);
            // 
            // groupBoxTCompra
            // 
            this.groupBoxTCompra.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxTCompra.Controls.Add(this.radioButtonOnline);
            this.groupBoxTCompra.Controls.Add(this.radioButtonPresencial);
            this.groupBoxTCompra.Location = new System.Drawing.Point(51, 700);
            this.groupBoxTCompra.Name = "groupBoxTCompra";
            this.groupBoxTCompra.Size = new System.Drawing.Size(200, 100);
            this.groupBoxTCompra.TabIndex = 19;
            this.groupBoxTCompra.TabStop = false;
            // 
            // radioButtonPagoMovil
            // 
            this.radioButtonPagoMovil.AutoSize = true;
            this.radioButtonPagoMovil.Location = new System.Drawing.Point(20, 21);
            this.radioButtonPagoMovil.Name = "radioButtonPagoMovil";
            this.radioButtonPagoMovil.Size = new System.Drawing.Size(96, 20);
            this.radioButtonPagoMovil.TabIndex = 20;
            this.radioButtonPagoMovil.TabStop = true;
            this.radioButtonPagoMovil.Text = "Pago Móvil";
            this.radioButtonPagoMovil.UseVisualStyleBackColor = true;
            this.radioButtonPagoMovil.CheckedChanged += new System.EventHandler(this.radioButtonPagoMovil_CheckedChanged);
            // 
            // radioButtonZelle
            // 
            this.radioButtonZelle.AutoSize = true;
            this.radioButtonZelle.Location = new System.Drawing.Point(20, 47);
            this.radioButtonZelle.Name = "radioButtonZelle";
            this.radioButtonZelle.Size = new System.Drawing.Size(58, 20);
            this.radioButtonZelle.TabIndex = 21;
            this.radioButtonZelle.TabStop = true;
            this.radioButtonZelle.Text = "Zelle";
            this.radioButtonZelle.UseVisualStyleBackColor = true;
            this.radioButtonZelle.CheckedChanged += new System.EventHandler(this.radioButtonZelle_CheckedChanged);
            // 
            // radioButtonTransferencia
            // 
            this.radioButtonTransferencia.AutoSize = true;
            this.radioButtonTransferencia.Location = new System.Drawing.Point(20, 73);
            this.radioButtonTransferencia.Name = "radioButtonTransferencia";
            this.radioButtonTransferencia.Size = new System.Drawing.Size(111, 20);
            this.radioButtonTransferencia.TabIndex = 22;
            this.radioButtonTransferencia.TabStop = true;
            this.radioButtonTransferencia.Text = "Transferencia";
            this.radioButtonTransferencia.UseVisualStyleBackColor = true;
            this.radioButtonTransferencia.CheckedChanged += new System.EventHandler(this.radioButtonTransferencia_CheckedChanged);
            // 
            // radioButtonEfectivo
            // 
            this.radioButtonEfectivo.AutoSize = true;
            this.radioButtonEfectivo.Location = new System.Drawing.Point(17, 21);
            this.radioButtonEfectivo.Name = "radioButtonEfectivo";
            this.radioButtonEfectivo.Size = new System.Drawing.Size(76, 20);
            this.radioButtonEfectivo.TabIndex = 23;
            this.radioButtonEfectivo.TabStop = true;
            this.radioButtonEfectivo.Text = "Efectivo";
            this.radioButtonEfectivo.UseVisualStyleBackColor = true;
            this.radioButtonEfectivo.CheckedChanged += new System.EventHandler(this.radioButtonEfectivo_CheckedChanged);
            // 
            // radioButtonTDD
            // 
            this.radioButtonTDD.AutoSize = true;
            this.radioButtonTDD.Location = new System.Drawing.Point(17, 47);
            this.radioButtonTDD.Name = "radioButtonTDD";
            this.radioButtonTDD.Size = new System.Drawing.Size(57, 20);
            this.radioButtonTDD.TabIndex = 24;
            this.radioButtonTDD.TabStop = true;
            this.radioButtonTDD.Text = "TDD";
            this.radioButtonTDD.UseVisualStyleBackColor = true;
            this.radioButtonTDD.CheckedChanged += new System.EventHandler(this.radioButtonTDD_CheckedChanged);
            // 
            // radioButtonTDC
            // 
            this.radioButtonTDC.AutoSize = true;
            this.radioButtonTDC.Location = new System.Drawing.Point(17, 73);
            this.radioButtonTDC.Name = "radioButtonTDC";
            this.radioButtonTDC.Size = new System.Drawing.Size(56, 20);
            this.radioButtonTDC.TabIndex = 25;
            this.radioButtonTDC.TabStop = true;
            this.radioButtonTDC.Text = "TDC";
            this.radioButtonTDC.UseVisualStyleBackColor = true;
            this.radioButtonTDC.CheckedChanged += new System.EventHandler(this.radioButtonTDC_CheckedChanged);
            // 
            // groupBoxPOnline
            // 
            this.groupBoxPOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxPOnline.Controls.Add(this.radioButtonPagoMovil);
            this.groupBoxPOnline.Controls.Add(this.radioButtonZelle);
            this.groupBoxPOnline.Controls.Add(this.radioButtonTransferencia);
            this.groupBoxPOnline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPOnline.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPOnline.Name = "groupBoxPOnline";
            this.groupBoxPOnline.Size = new System.Drawing.Size(202, 100);
            this.groupBoxPOnline.TabIndex = 26;
            this.groupBoxPOnline.TabStop = false;
            this.groupBoxPOnline.Text = "Método de pago:";
            // 
            // groupBoxPPresencial
            // 
            this.groupBoxPPresencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBoxPPresencial.Controls.Add(this.radioButtonEfectivo);
            this.groupBoxPPresencial.Controls.Add(this.radioButtonTDD);
            this.groupBoxPPresencial.Controls.Add(this.radioButtonTDC);
            this.groupBoxPPresencial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPPresencial.Location = new System.Drawing.Point(6, 6);
            this.groupBoxPPresencial.Name = "groupBoxPPresencial";
            this.groupBoxPPresencial.Size = new System.Drawing.Size(202, 100);
            this.groupBoxPPresencial.TabIndex = 27;
            this.groupBoxPPresencial.TabStop = false;
            this.groupBoxPPresencial.Text = "Método de pago:";
            // 
            // marcoMPOnline
            // 
            this.marcoMPOnline.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marcoMPOnline.ColumnCount = 1;
            this.marcoMPOnline.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoMPOnline.Controls.Add(this.groupBoxPOnline, 0, 0);
            this.marcoMPOnline.Location = new System.Drawing.Point(347, 688);
            this.marcoMPOnline.Name = "marcoMPOnline";
            this.marcoMPOnline.Padding = new System.Windows.Forms.Padding(3);
            this.marcoMPOnline.RowCount = 1;
            this.marcoMPOnline.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoMPOnline.Size = new System.Drawing.Size(214, 112);
            this.marcoMPOnline.TabIndex = 28;
            this.marcoMPOnline.Visible = false;
            // 
            // marcoMPPresencial
            // 
            this.marcoMPPresencial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marcoMPPresencial.ColumnCount = 1;
            this.marcoMPPresencial.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoMPPresencial.Controls.Add(this.groupBoxPPresencial, 0, 0);
            this.marcoMPPresencial.Location = new System.Drawing.Point(347, 688);
            this.marcoMPPresencial.Name = "marcoMPPresencial";
            this.marcoMPPresencial.Padding = new System.Windows.Forms.Padding(3);
            this.marcoMPPresencial.RowCount = 1;
            this.marcoMPPresencial.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoMPPresencial.Size = new System.Drawing.Size(214, 112);
            this.marcoMPPresencial.TabIndex = 29;
            this.marcoMPPresencial.Visible = false;
            // 
            // labelAviso
            // 
            this.labelAviso.AutoSize = true;
            this.labelAviso.BackColor = System.Drawing.Color.Transparent;
            this.labelAviso.Location = new System.Drawing.Point(344, 483);
            this.labelAviso.Name = "labelAviso";
            this.labelAviso.Size = new System.Drawing.Size(306, 16);
            this.labelAviso.TabIndex = 30;
            this.labelAviso.Text = "Presione \"Enter\" para confirmar número ingresado";
            // 
            // labelErrorMP
            // 
            this.labelErrorMP.AutoSize = true;
            this.labelErrorMP.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorMP.Location = new System.Drawing.Point(350, 661);
            this.labelErrorMP.Name = "labelErrorMP";
            this.labelErrorMP.Size = new System.Drawing.Size(217, 16);
            this.labelErrorMP.TabIndex = 31;
            this.labelErrorMP.Text = "No seleccionó un método de pago.";
            this.labelErrorMP.Visible = false;
            // 
            // labelErrorTC
            // 
            this.labelErrorTC.AutoSize = true;
            this.labelErrorTC.BackColor = System.Drawing.Color.Transparent;
            this.labelErrorTC.Location = new System.Drawing.Point(350, 634);
            this.labelErrorTC.Name = "labelErrorTC";
            this.labelErrorTC.Size = new System.Drawing.Size(204, 16);
            this.labelErrorTC.TabIndex = 32;
            this.labelErrorTC.Text = "No seleccionó el tipo de compra.\r\n";
            this.labelErrorTC.Visible = false;
            // 
            // marcoPregunta
            // 
            this.marcoPregunta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.marcoPregunta.ColumnCount = 1;
            this.marcoPregunta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoPregunta.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.marcoPregunta.Location = new System.Drawing.Point(220, 339);
            this.marcoPregunta.Name = "marcoPregunta";
            this.marcoPregunta.Padding = new System.Windows.Forms.Padding(3);
            this.marcoPregunta.RowCount = 1;
            this.marcoPregunta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.marcoPregunta.Size = new System.Drawing.Size(249, 141);
            this.marcoPregunta.TabIndex = 33;
            this.marcoPregunta.Visible = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(237, 129);
            this.tableLayoutPanel4.TabIndex = 34;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.buttonOtraCompraNo, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.buttonOtraCompraSi, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 67);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(231, 59);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // buttonOtraCompraNo
            // 
            this.buttonOtraCompraNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOtraCompraNo.Location = new System.Drawing.Point(135, 18);
            this.buttonOtraCompraNo.Name = "buttonOtraCompraNo";
            this.buttonOtraCompraNo.Size = new System.Drawing.Size(75, 23);
            this.buttonOtraCompraNo.TabIndex = 0;
            this.buttonOtraCompraNo.Text = "No";
            this.buttonOtraCompraNo.UseVisualStyleBackColor = true;
            this.buttonOtraCompraNo.Click += new System.EventHandler(this.buttonOtraCompraNo_Click);
            // 
            // buttonOtraCompraSi
            // 
            this.buttonOtraCompraSi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOtraCompraSi.Location = new System.Drawing.Point(20, 18);
            this.buttonOtraCompraSi.Name = "buttonOtraCompraSi";
            this.buttonOtraCompraSi.Size = new System.Drawing.Size(75, 23);
            this.buttonOtraCompraSi.TabIndex = 1;
            this.buttonOtraCompraSi.Text = "Sí";
            this.buttonOtraCompraSi.UseVisualStyleBackColor = true;
            this.buttonOtraCompraSi.Click += new System.EventHandler(this.buttonOtraCompraSi_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "¿Desea realizar otra compra?";
            // 
            // formCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 900);
            this.Controls.Add(this.marcoPregunta);
            this.Controls.Add(this.labelErrorTC);
            this.Controls.Add(this.labelErrorMP);
            this.Controls.Add(this.labelAviso);
            this.Controls.Add(this.marcoMPPresencial);
            this.Controls.Add(this.marcoMPOnline);
            this.Controls.Add(this.groupBoxTCompra);
            this.Controls.Add(this.numericUpDownUnidades);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.BoxLogo2);
            this.Controls.Add(this.comboBoxProductos);
            this.Controls.Add(this.buttonCompra);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelTipoCompra);
            this.Controls.Add(this.labelPTotal);
            this.Controls.Add(this.labelUnid);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelPdto);
            this.Controls.Add(this.fondo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "formCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingrese la informacion para la compra";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formCompra_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.fondo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BoxLogo2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownUnidades)).EndInit();
            this.groupBoxTCompra.ResumeLayout(false);
            this.groupBoxTCompra.PerformLayout();
            this.groupBoxPOnline.ResumeLayout(false);
            this.groupBoxPOnline.PerformLayout();
            this.groupBoxPPresencial.ResumeLayout(false);
            this.groupBoxPPresencial.PerformLayout();
            this.marcoMPOnline.ResumeLayout(false);
            this.marcoMPPresencial.ResumeLayout(false);
            this.marcoPregunta.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPdto;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelUnid;
        private System.Windows.Forms.Label labelPTotal;
        private System.Windows.Forms.Label labelTipoCompra;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RadioButton radioButtonOnline;
        private System.Windows.Forms.RadioButton radioButtonPresencial;
        private System.Windows.Forms.Button buttonCompra;
        private System.Windows.Forms.ComboBox comboBoxProductos;
        private System.Windows.Forms.PictureBox BoxLogo2;
        internal System.Windows.Forms.PictureBox fondo;
        private System.Windows.Forms.Label labelNameTienda;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.NumericUpDown numericUpDownUnidades;
        private System.Windows.Forms.GroupBox groupBoxTCompra;
        private System.Windows.Forms.RadioButton radioButtonPagoMovil;
        private System.Windows.Forms.RadioButton radioButtonZelle;
        private System.Windows.Forms.RadioButton radioButtonTransferencia;
        private System.Windows.Forms.RadioButton radioButtonEfectivo;
        private System.Windows.Forms.RadioButton radioButtonTDD;
        private System.Windows.Forms.RadioButton radioButtonTDC;
        private System.Windows.Forms.GroupBox groupBoxPOnline;
        private System.Windows.Forms.GroupBox groupBoxPPresencial;
        private System.Windows.Forms.TableLayoutPanel marcoMPOnline;
        private System.Windows.Forms.TableLayoutPanel marcoMPPresencial;
        private System.Windows.Forms.Label labelAviso;
        private System.Windows.Forms.Label labelErrorMP;
        private System.Windows.Forms.Label labelErrorTC;
        private System.Windows.Forms.TableLayoutPanel marcoPregunta;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button buttonOtraCompraNo;
        private System.Windows.Forms.Button buttonOtraCompraSi;
        private System.Windows.Forms.Label label1;
    }
}