namespace HMI
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
            this.groupBoxLed = new System.Windows.Forms.GroupBox();
            this.buttonEncender = new System.Windows.Forms.Button();
            this.buttonApagar = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.groupBoxPort = new System.Windows.Forms.GroupBox();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaud = new System.Windows.Forms.Label();
            this.comboBoxPort = new System.Windows.Forms.ComboBox();
            this.comboBoxBaud = new System.Windows.Forms.ComboBox();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.pictureBoxLed = new System.Windows.Forms.PictureBox();
            this.progressBarConnection = new System.Windows.Forms.ProgressBar();
            this.groupBoxLed.SuspendLayout();
            this.groupBoxPort.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxLed
            // 
            this.groupBoxLed.Controls.Add(this.pictureBoxLed);
            this.groupBoxLed.Controls.Add(this.buttonApagar);
            this.groupBoxLed.Controls.Add(this.buttonEncender);
            this.groupBoxLed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxLed.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxLed.Location = new System.Drawing.Point(247, 27);
            this.groupBoxLed.Name = "groupBoxLed";
            this.groupBoxLed.Size = new System.Drawing.Size(218, 207);
            this.groupBoxLed.TabIndex = 0;
            this.groupBoxLed.TabStop = false;
            this.groupBoxLed.Text = " LED";
            this.groupBoxLed.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonEncender
            // 
            this.buttonEncender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonEncender.Location = new System.Drawing.Point(21, 144);
            this.buttonEncender.Name = "buttonEncender";
            this.buttonEncender.Size = new System.Drawing.Size(75, 34);
            this.buttonEncender.TabIndex = 1;
            this.buttonEncender.Text = "Encender";
            this.buttonEncender.UseVisualStyleBackColor = true;
            this.buttonEncender.Click += new System.EventHandler(this.buttonEncender_Click);
            // 
            // buttonApagar
            // 
            this.buttonApagar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonApagar.Location = new System.Drawing.Point(123, 144);
            this.buttonApagar.Name = "buttonApagar";
            this.buttonApagar.Size = new System.Drawing.Size(75, 34);
            this.buttonApagar.TabIndex = 2;
            this.buttonApagar.Text = "Apagar";
            this.buttonApagar.UseVisualStyleBackColor = true;
            this.buttonApagar.Click += new System.EventHandler(this.buttonApagar_Click);
            // 
            // groupBoxPort
            // 
            this.groupBoxPort.Controls.Add(this.buttonClose);
            this.groupBoxPort.Controls.Add(this.buttonOpen);
            this.groupBoxPort.Controls.Add(this.comboBoxBaud);
            this.groupBoxPort.Controls.Add(this.comboBoxPort);
            this.groupBoxPort.Controls.Add(this.labelBaud);
            this.groupBoxPort.Controls.Add(this.labelPort);
            this.groupBoxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBoxPort.Location = new System.Drawing.Point(12, 27);
            this.groupBoxPort.Name = "groupBoxPort";
            this.groupBoxPort.Size = new System.Drawing.Size(229, 178);
            this.groupBoxPort.TabIndex = 1;
            this.groupBoxPort.TabStop = false;
            this.groupBoxPort.Text = "COM PORT SETTINGS";
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(6, 33);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(76, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "COM PORT:";
            // 
            // labelBaud
            // 
            this.labelBaud.AutoSize = true;
            this.labelBaud.Location = new System.Drawing.Point(6, 84);
            this.labelBaud.Name = "labelBaud";
            this.labelBaud.Size = new System.Drawing.Size(82, 13);
            this.labelBaud.TabIndex = 1;
            this.labelBaud.Text = "BAUD RATE:";
            // 
            // comboBoxPort
            // 
            this.comboBoxPort.FormattingEnabled = true;
            this.comboBoxPort.Location = new System.Drawing.Point(88, 30);
            this.comboBoxPort.Name = "comboBoxPort";
            this.comboBoxPort.Size = new System.Drawing.Size(83, 21);
            this.comboBoxPort.TabIndex = 2;
            this.comboBoxPort.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxBaud
            // 
            this.comboBoxBaud.FormattingEnabled = true;
            this.comboBoxBaud.Location = new System.Drawing.Point(94, 81);
            this.comboBoxBaud.Name = "comboBoxBaud";
            this.comboBoxBaud.Size = new System.Drawing.Size(83, 21);
            this.comboBoxBaud.TabIndex = 3;
            // 
            // buttonOpen
            // 
            this.buttonOpen.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonOpen.Location = new System.Drawing.Point(9, 144);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(96, 23);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "OPEN";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose.Location = new System.Drawing.Point(111, 144);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(96, 23);
            this.buttonClose.TabIndex = 5;
            this.buttonClose.Text = "CLOSE";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // pictureBoxLed
            // 
            this.pictureBoxLed.Image = global::HMI.Properties.Resources.ButtonOff;
            this.pictureBoxLed.Location = new System.Drawing.Point(36, 19);
            this.pictureBoxLed.Name = "pictureBoxLed";
            this.pictureBoxLed.Size = new System.Drawing.Size(142, 63);
            this.pictureBoxLed.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLed.TabIndex = 4;
            this.pictureBoxLed.TabStop = false;
            // 
            // progressBarConnection
            // 
            this.progressBarConnection.Location = new System.Drawing.Point(12, 211);
            this.progressBarConnection.Name = "progressBarConnection";
            this.progressBarConnection.Size = new System.Drawing.Size(229, 23);
            this.progressBarConnection.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(486, 253);
            this.Controls.Add(this.progressBarConnection);
            this.Controls.Add(this.groupBoxPort);
            this.Controls.Add(this.groupBoxLed);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxLed.ResumeLayout(false);
            this.groupBoxPort.ResumeLayout(false);
            this.groupBoxPort.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLed;
        private System.Windows.Forms.Button buttonEncender;
        private System.Windows.Forms.Button buttonApagar;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox groupBoxPort;
        private System.Windows.Forms.Label labelBaud;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.ComboBox comboBoxPort;
        private System.Windows.Forms.ComboBox comboBoxBaud;
        private System.Windows.Forms.PictureBox pictureBoxLed;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.ProgressBar progressBarConnection;
    }
}

