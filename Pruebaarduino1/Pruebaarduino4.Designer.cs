namespace Pruebaarduino1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progressBarConeccion = new System.Windows.Forms.ProgressBar();
            this.butConectar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboSerial = new System.Windows.Forms.ComboBox();
            this.comboPuerto = new System.Windows.Forms.ComboBox();
            this.butRefrescar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.butOff = new System.Windows.Forms.Button();
            this.butOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBoxG1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Pot3 = new CircularProgressBar.CircularProgressBar();
            this.Pot2 = new CircularProgressBar.CircularProgressBar();
            this.Pot1 = new CircularProgressBar.CircularProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxG3 = new System.Windows.Forms.TextBox();
            this.textBoxG2 = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.labelGrad1 = new System.Windows.Forms.Label();
            this.labelGrad2 = new System.Windows.Forms.Label();
            this.labelGrad3 = new System.Windows.Forms.Label();
            this.labelEjeX = new System.Windows.Forms.Label();
            this.labelEjeY = new System.Windows.Forms.Label();
            this.labelEjeZ = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboIP = new System.Windows.Forms.ComboBox();
            this.textBoxPuerto = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.progressBarConeccion);
            this.groupBox1.Controls.Add(this.butConectar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboSerial);
            this.groupBox1.Controls.Add(this.comboPuerto);
            this.groupBox1.Controls.Add(this.butRefrescar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(292, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puerto Arduino";
            // 
            // progressBarConeccion
            // 
            this.progressBarConeccion.Location = new System.Drawing.Point(240, 21);
            this.progressBarConeccion.Name = "progressBarConeccion";
            this.progressBarConeccion.Size = new System.Drawing.Size(18, 20);
            this.progressBarConeccion.TabIndex = 7;
            // 
            // butConectar
            // 
            this.butConectar.BackColor = System.Drawing.Color.White;
            this.butConectar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butConectar.Location = new System.Drawing.Point(150, 20);
            this.butConectar.Name = "butConectar";
            this.butConectar.Size = new System.Drawing.Size(75, 23);
            this.butConectar.TabIndex = 5;
            this.butConectar.Text = "Conectar";
            this.butConectar.UseVisualStyleBackColor = false;
            this.butConectar.Click += new System.EventHandler(this.butConectar_Click_1);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puerto";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Serial";
            // 
            // comboSerial
            // 
            this.comboSerial.FormattingEnabled = true;
            this.comboSerial.Items.AddRange(new object[] {
            "9600",
            "38400",
            "57600",
            "115200"});
            this.comboSerial.Location = new System.Drawing.Point(58, 47);
            this.comboSerial.Name = "comboSerial";
            this.comboSerial.Size = new System.Drawing.Size(76, 21);
            this.comboSerial.TabIndex = 1;
            // 
            // comboPuerto
            // 
            this.comboPuerto.FormattingEnabled = true;
            this.comboPuerto.Location = new System.Drawing.Point(55, 20);
            this.comboPuerto.Name = "comboPuerto";
            this.comboPuerto.Size = new System.Drawing.Size(79, 21);
            this.comboPuerto.TabIndex = 0;
            // 
            // butRefrescar
            // 
            this.butRefrescar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.butRefrescar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butRefrescar.Location = new System.Drawing.Point(150, 47);
            this.butRefrescar.Name = "butRefrescar";
            this.butRefrescar.Size = new System.Drawing.Size(75, 23);
            this.butRefrescar.TabIndex = 6;
            this.butRefrescar.Text = "Refrescar";
            this.butRefrescar.UseVisualStyleBackColor = false;
            this.butRefrescar.Click += new System.EventHandler(this.butRefrescar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Controls.Add(this.butOff);
            this.groupBox2.Controls.Add(this.butOn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(641, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 60);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Led";
            // 
            // butOff
            // 
            this.butOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butOff.Location = new System.Drawing.Point(89, 19);
            this.butOff.Name = "butOff";
            this.butOff.Size = new System.Drawing.Size(75, 23);
            this.butOff.TabIndex = 2;
            this.butOff.Text = "Apagar";
            this.butOff.UseVisualStyleBackColor = true;
            this.butOff.Click += new System.EventHandler(this.butOff_Click_1);
            // 
            // butOn
            // 
            this.butOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butOn.Location = new System.Drawing.Point(170, 19);
            this.butOn.Name = "butOn";
            this.butOn.Size = new System.Drawing.Size(75, 23);
            this.butOn.TabIndex = 1;
            this.butOn.Text = "Prender";
            this.butOn.UseVisualStyleBackColor = true;
            this.butOn.Click += new System.EventHandler(this.butOn_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "LED";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBoxG1
            // 
            this.textBoxG1.Location = new System.Drawing.Point(83, 17);
            this.textBoxG1.Name = "textBoxG1";
            this.textBoxG1.Size = new System.Drawing.Size(49, 20);
            this.textBoxG1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Pot3);
            this.groupBox3.Controls.Add(this.Pot2);
            this.groupBox3.Controls.Add(this.Pot1);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.textBoxG3);
            this.groupBox3.Controls.Add(this.textBoxG2);
            this.groupBox3.Controls.Add(this.textBoxX);
            this.groupBox3.Controls.Add(this.textBoxY);
            this.groupBox3.Controls.Add(this.textBoxZ);
            this.groupBox3.Controls.Add(this.labelGrad1);
            this.groupBox3.Controls.Add(this.labelGrad2);
            this.groupBox3.Controls.Add(this.labelGrad3);
            this.groupBox3.Controls.Add(this.labelEjeX);
            this.groupBox3.Controls.Add(this.labelEjeY);
            this.groupBox3.Controls.Add(this.labelEjeZ);
            this.groupBox3.Controls.Add(this.textBoxG1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(12, 101);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(874, 164);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos";
            // 
            // Pot3
            // 
            this.Pot3.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;
            this.Pot3.AnimationSpeed = 500;
            this.Pot3.BackColor = System.Drawing.Color.Transparent;
            this.Pot3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Pot3.ForeColor = System.Drawing.Color.Black;
            this.Pot3.InnerColor = System.Drawing.Color.White;
            this.Pot3.InnerMargin = 2;
            this.Pot3.InnerWidth = -1;
            this.Pot3.Location = new System.Drawing.Point(718, 17);
            this.Pot3.MarqueeAnimationSpeed = 2000;
            this.Pot3.Maximum = 360;
            this.Pot3.Name = "Pot3";
            this.Pot3.OuterColor = System.Drawing.Color.Red;
            this.Pot3.OuterMargin = -25;
            this.Pot3.OuterWidth = 26;
            this.Pot3.ProgressColor = System.Drawing.Color.Gray;
            this.Pot3.ProgressWidth = 25;
            this.Pot3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pot3.RightToLeftLayout = true;
            this.Pot3.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Pot3.Size = new System.Drawing.Size(140, 140);
            this.Pot3.StartAngle = 270;
            this.Pot3.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pot3.SubscriptColor = System.Drawing.Color.Black;
            this.Pot3.SubscriptMargin = new System.Windows.Forms.Padding(4, -35, 0, 0);
            this.Pot3.SubscriptText = "º";
            this.Pot3.SuperscriptColor = System.Drawing.Color.Black;
            this.Pot3.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Pot3.SuperscriptText = "";
            this.Pot3.TabIndex = 17;
            this.Pot3.Text = "0";
            this.Pot3.TextMargin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.Pot3.UseWaitCursor = true;
            this.Pot3.Value = 360;
            // 
            // Pot2
            // 
            this.Pot2.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;
            this.Pot2.AnimationSpeed = 500;
            this.Pot2.BackColor = System.Drawing.Color.Transparent;
            this.Pot2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Pot2.ForeColor = System.Drawing.Color.Black;
            this.Pot2.InnerColor = System.Drawing.Color.White;
            this.Pot2.InnerMargin = 2;
            this.Pot2.InnerWidth = -1;
            this.Pot2.Location = new System.Drawing.Point(521, 16);
            this.Pot2.MarqueeAnimationSpeed = 2000;
            this.Pot2.Maximum = 360;
            this.Pot2.Name = "Pot2";
            this.Pot2.OuterColor = System.Drawing.Color.Blue;
            this.Pot2.OuterMargin = -25;
            this.Pot2.OuterWidth = 26;
            this.Pot2.ProgressColor = System.Drawing.Color.Gray;
            this.Pot2.ProgressWidth = 25;
            this.Pot2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pot2.RightToLeftLayout = true;
            this.Pot2.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Pot2.Size = new System.Drawing.Size(140, 140);
            this.Pot2.StartAngle = 270;
            this.Pot2.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pot2.SubscriptColor = System.Drawing.Color.Black;
            this.Pot2.SubscriptMargin = new System.Windows.Forms.Padding(4, -35, 0, 0);
            this.Pot2.SubscriptText = "º";
            this.Pot2.SuperscriptColor = System.Drawing.Color.Black;
            this.Pot2.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Pot2.SuperscriptText = "";
            this.Pot2.TabIndex = 18;
            this.Pot2.Text = "0";
            this.Pot2.TextMargin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.Pot2.UseWaitCursor = true;
            this.Pot2.Value = 360;
            // 
            // Pot1
            // 
            this.Pot1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.QuinticEaseOut;
            this.Pot1.AnimationSpeed = 500;
            this.Pot1.BackColor = System.Drawing.Color.Transparent;
            this.Pot1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.Pot1.ForeColor = System.Drawing.Color.Black;
            this.Pot1.InnerColor = System.Drawing.Color.White;
            this.Pot1.InnerMargin = 2;
            this.Pot1.InnerWidth = -1;
            this.Pot1.Location = new System.Drawing.Point(312, 15);
            this.Pot1.MarqueeAnimationSpeed = 2000;
            this.Pot1.Maximum = 360;
            this.Pot1.Name = "Pot1";
            this.Pot1.OuterColor = System.Drawing.Color.Lime;
            this.Pot1.OuterMargin = -25;
            this.Pot1.OuterWidth = 26;
            this.Pot1.ProgressColor = System.Drawing.Color.Gray;
            this.Pot1.ProgressWidth = 25;
            this.Pot1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Pot1.RightToLeftLayout = true;
            this.Pot1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Pot1.Size = new System.Drawing.Size(140, 140);
            this.Pot1.StartAngle = 270;
            this.Pot1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pot1.SubscriptColor = System.Drawing.Color.Black;
            this.Pot1.SubscriptMargin = new System.Windows.Forms.Padding(4, -35, 0, 0);
            this.Pot1.SubscriptText = "º";
            this.Pot1.SuperscriptColor = System.Drawing.Color.Black;
            this.Pot1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Pot1.SuperscriptText = "";
            this.Pot1.TabIndex = 17;
            this.Pot1.Text = "0";
            this.Pot1.TextMargin = new System.Windows.Forms.Padding(4, 3, 0, 0);
            this.Pot1.UseWaitCursor = true;
            this.Pot1.Value = 360;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(7, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(279, 20);
            this.textBox1.TabIndex = 16;
            // 
            // textBoxG3
            // 
            this.textBoxG3.Location = new System.Drawing.Point(83, 99);
            this.textBoxG3.Name = "textBoxG3";
            this.textBoxG3.Size = new System.Drawing.Size(49, 20);
            this.textBoxG3.TabIndex = 15;
            // 
            // textBoxG2
            // 
            this.textBoxG2.Location = new System.Drawing.Point(83, 58);
            this.textBoxG2.Name = "textBoxG2";
            this.textBoxG2.Size = new System.Drawing.Size(49, 20);
            this.textBoxG2.TabIndex = 14;
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(219, 15);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(49, 20);
            this.textBoxX.TabIndex = 13;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(219, 58);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(49, 20);
            this.textBoxY.TabIndex = 12;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(219, 97);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.Size = new System.Drawing.Size(49, 20);
            this.textBoxZ.TabIndex = 11;
            // 
            // labelGrad1
            // 
            this.labelGrad1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrad1.Location = new System.Drawing.Point(6, 16);
            this.labelGrad1.Name = "labelGrad1";
            this.labelGrad1.Size = new System.Drawing.Size(71, 21);
            this.labelGrad1.TabIndex = 10;
            this.labelGrad1.Text = "Grados 1";
            // 
            // labelGrad2
            // 
            this.labelGrad2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrad2.Location = new System.Drawing.Point(6, 57);
            this.labelGrad2.Name = "labelGrad2";
            this.labelGrad2.Size = new System.Drawing.Size(80, 21);
            this.labelGrad2.TabIndex = 9;
            this.labelGrad2.Text = "Grados 2";
            // 
            // labelGrad3
            // 
            this.labelGrad3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGrad3.Location = new System.Drawing.Point(6, 98);
            this.labelGrad3.Name = "labelGrad3";
            this.labelGrad3.Size = new System.Drawing.Size(71, 21);
            this.labelGrad3.TabIndex = 8;
            this.labelGrad3.Text = "Grados 3";
            // 
            // labelEjeX
            // 
            this.labelEjeX.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjeX.Location = new System.Drawing.Point(166, 16);
            this.labelEjeX.Name = "labelEjeX";
            this.labelEjeX.Size = new System.Drawing.Size(59, 21);
            this.labelEjeX.TabIndex = 7;
            this.labelEjeX.Text = "Eje X";
            // 
            // labelEjeY
            // 
            this.labelEjeY.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjeY.Location = new System.Drawing.Point(166, 57);
            this.labelEjeY.Name = "labelEjeY";
            this.labelEjeY.Size = new System.Drawing.Size(59, 21);
            this.labelEjeY.TabIndex = 6;
            this.labelEjeY.Text = "Eje Y";
            // 
            // labelEjeZ
            // 
            this.labelEjeZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEjeZ.Location = new System.Drawing.Point(166, 98);
            this.labelEjeZ.Name = "labelEjeZ";
            this.labelEjeZ.Size = new System.Drawing.Size(59, 21);
            this.labelEjeZ.TabIndex = 5;
            this.labelEjeZ.Text = "Eje Z";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox4.Controls.Add(this.comboIP);
            this.groupBox4.Controls.Add(this.textBoxPuerto);
            this.groupBox4.Controls.Add(this.progressBar1);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox4.Location = new System.Drawing.Point(330, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(292, 83);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Puerto Rasberry";
            // 
            // comboIP
            // 
            this.comboIP.FormattingEnabled = true;
            this.comboIP.Items.AddRange(new object[] {
            "192.168.1.195",
            "192.168.0.16"});
            this.comboIP.Location = new System.Drawing.Point(34, 21);
            this.comboIP.Name = "comboIP";
            this.comboIP.Size = new System.Drawing.Size(100, 21);
            this.comboIP.TabIndex = 10;
            // 
            // textBoxPuerto
            // 
            this.textBoxPuerto.Location = new System.Drawing.Point(209, 23);
            this.textBoxPuerto.Name = "textBoxPuerto";
            this.textBoxPuerto.Size = new System.Drawing.Size(48, 20);
            this.textBoxPuerto.TabIndex = 9;
            this.textBoxPuerto.Text = "40001";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(268, 24);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(18, 20);
            this.progressBar1.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(137, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Envisr";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "IP";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "Puerto";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chart1);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(461, 276);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(435, 289);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Grafico Vista Superior";
            // 
            // chart1
            // 
            chartArea1.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.IsMarksNextToAxis = false;
            chartArea1.AxisX.LabelAutoFitStyle = System.Windows.Forms.DataVisualization.Charting.LabelAutoFitStyles.None;
            chartArea1.CursorX.AutoScroll = false;
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 85.39228F;
            chartArea1.InnerPlotPosition.Width = 83.76591F;
            chartArea1.InnerPlotPosition.X = 13.91905F;
            chartArea1.InnerPlotPosition.Y = 3.90957F;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 16);
            this.chart1.Name = "chart1";
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Blue;
            series1.LabelBorderWidth = 5;
            series1.Legend = "Legend1";
            series1.Name = "Seccion2";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.LabelBorderWidth = 5;
            series2.Legend = "Legend1";
            series2.Name = "Seccion3";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Transparent;
            series3.Legend = "Legend1";
            series3.Name = "punto";
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series4.Color = System.Drawing.Color.Lime;
            series4.LabelBorderWidth = 5;
            series4.Legend = "Legend1";
            series4.Name = "Seccion1";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(419, 262);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chart2);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Location = new System.Drawing.Point(6, 271);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(449, 294);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Grafico Vista Lateral";
            // 
            // chart2
            // 
            chartArea2.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.IsMarginVisible = false;
            chartArea2.AxisX.IsStartedFromZero = false;
            chartArea2.AxisX.LabelAutoFitMaxFontSize = 5;
            chartArea2.AxisX.LabelAutoFitMinFontSize = 8;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.True;
            chartArea2.AxisY.Title = "Altura";
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(0, 19);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Light;
            series5.BorderWidth = 5;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Color = System.Drawing.Color.Blue;
            series5.LabelBorderWidth = 5;
            series5.Legend = "Legend1";
            series5.Name = "Seccion2";
            series6.BorderWidth = 5;
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Color = System.Drawing.Color.Red;
            series6.LabelBorderWidth = 5;
            series6.Legend = "Legend1";
            series6.Name = "Seccion3";
            series7.BorderWidth = 5;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Color = System.Drawing.Color.Lime;
            series7.LabelBorderWidth = 5;
            series7.Legend = "Legend1";
            series7.Name = "Seccion1";
            series8.BorderWidth = 0;
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series8.Color = System.Drawing.Color.White;
            series8.LabelForeColor = System.Drawing.Color.BlanchedAlmond;
            series8.Legend = "Legend1";
            series8.Name = "punto";
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Size = new System.Drawing.Size(424, 264);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(938, 577);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button butRefrescar;
        private System.Windows.Forms.Button butConectar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboSerial;
        private System.Windows.Forms.ComboBox comboPuerto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button butOff;
        private System.Windows.Forms.Button butOn;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBoxG1;
        private System.Windows.Forms.ProgressBar progressBarConeccion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelGrad1;
        private System.Windows.Forms.Label labelGrad2;
        private System.Windows.Forms.Label labelGrad3;
        private System.Windows.Forms.Label labelEjeX;
        private System.Windows.Forms.Label labelEjeY;
        private System.Windows.Forms.Label labelEjeZ;
        private System.Windows.Forms.TextBox textBoxG3;
        private System.Windows.Forms.TextBox textBoxG2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private CircularProgressBar.CircularProgressBar Pot1;
        private CircularProgressBar.CircularProgressBar Pot3;
        private CircularProgressBar.CircularProgressBar Pot2;
        private System.Windows.Forms.TextBox textBoxPuerto;
        private System.Windows.Forms.ComboBox comboIP;
    }
}

