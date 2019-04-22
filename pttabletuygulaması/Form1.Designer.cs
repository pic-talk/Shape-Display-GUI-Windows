namespace pttabletuygulaması
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label_seridurum = new System.Windows.Forms.Label();
            this.label_seri_durum = new System.Windows.Forms.Label();
            this.button_yenile = new System.Windows.Forms.Button();
            this.button_baglan = new System.Windows.Forms.Button();
            this.label_seriport = new System.Windows.Forms.Label();
            this.comboBox_seriport = new System.Windows.Forms.ComboBox();
            this.buttonSendCommand = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label_aygit = new System.Windows.Forms.Label();
            this.textBox_aygit_adi = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(319, 20);
            this.textBox1.TabIndex = 64;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_aygit_adi);
            this.groupBox2.Controls.Add(this.label_seridurum);
            this.groupBox2.Controls.Add(this.label_seri_durum);
            this.groupBox2.Controls.Add(this.label_aygit);
            this.groupBox2.Controls.Add(this.button_yenile);
            this.groupBox2.Controls.Add(this.button_baglan);
            this.groupBox2.Controls.Add(this.label_seriport);
            this.groupBox2.Controls.Add(this.comboBox_seriport);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 137);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Shape Display Port Settings";
            // 
            // label_seridurum
            // 
            this.label_seridurum.AutoSize = true;
            this.label_seridurum.Location = new System.Drawing.Point(113, 83);
            this.label_seridurum.Name = "label_seridurum";
            this.label_seridurum.Size = new System.Drawing.Size(79, 13);
            this.label_seridurum.TabIndex = 4;
            this.label_seridurum.Text = "Not Connected";
            this.label_seridurum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_seri_durum
            // 
            this.label_seri_durum.AutoSize = true;
            this.label_seri_durum.Location = new System.Drawing.Point(7, 83);
            this.label_seri_durum.Name = "label_seri_durum";
            this.label_seri_durum.Size = new System.Drawing.Size(77, 13);
            this.label_seri_durum.TabIndex = 8;
            this.label_seri_durum.Text = "Device Status:";
            // 
            // button_yenile
            // 
            this.button_yenile.Location = new System.Drawing.Point(105, 52);
            this.button_yenile.Name = "button_yenile";
            this.button_yenile.Size = new System.Drawing.Size(87, 23);
            this.button_yenile.TabIndex = 3;
            this.button_yenile.Text = "Refresh";
            this.button_yenile.UseVisualStyleBackColor = true;
            this.button_yenile.Click += new System.EventHandler(this.button_yenile_Click);
            // 
            // button_baglan
            // 
            this.button_baglan.Location = new System.Drawing.Point(6, 52);
            this.button_baglan.Name = "button_baglan";
            this.button_baglan.Size = new System.Drawing.Size(87, 23);
            this.button_baglan.TabIndex = 2;
            this.button_baglan.Text = "Connect";
            this.button_baglan.UseVisualStyleBackColor = true;
            this.button_baglan.Click += new System.EventHandler(this.button_baglan_Click);
            // 
            // label_seriport
            // 
            this.label_seriport.AutoSize = true;
            this.label_seriport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_seriport.Location = new System.Drawing.Point(8, 27);
            this.label_seriport.Name = "label_seriport";
            this.label_seriport.Size = new System.Drawing.Size(53, 13);
            this.label_seriport.TabIndex = 1;
            this.label_seriport.Text = "Com Port:";
            // 
            // comboBox_seriport
            // 
            this.comboBox_seriport.FormattingEnabled = true;
            this.comboBox_seriport.Location = new System.Drawing.Point(72, 22);
            this.comboBox_seriport.Name = "comboBox_seriport";
            this.comboBox_seriport.Size = new System.Drawing.Size(120, 21);
            this.comboBox_seriport.TabIndex = 0;
            // 
            // buttonSendCommand
            // 
            this.buttonSendCommand.Location = new System.Drawing.Point(337, 239);
            this.buttonSendCommand.Name = "buttonSendCommand";
            this.buttonSendCommand.Size = new System.Drawing.Size(94, 23);
            this.buttonSendCommand.TabIndex = 63;
            this.buttonSendCommand.Text = "Send";
            this.buttonSendCommand.UseVisualStyleBackColor = true;
            this.buttonSendCommand.Click += new System.EventHandler(this.buttonSendCommand_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 155);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(419, 78);
            this.richTextBox1.TabIndex = 62;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(330, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 66;
            this.button1.Text = "Send Model";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(218, 95);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 68;
            this.button2.Text = "Add New Models";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(218, 68);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(213, 21);
            this.comboBox2.TabIndex = 67;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(218, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 38);
            this.label1.TabIndex = 69;
            this.label1.Text = "PIC-TALK Shape Display Program";
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label_aygit
            // 
            this.label_aygit.AutoSize = true;
            this.label_aygit.Location = new System.Drawing.Point(6, 109);
            this.label_aygit.Name = "label_aygit";
            this.label_aygit.Size = new System.Drawing.Size(44, 13);
            this.label_aygit.TabIndex = 6;
            this.label_aygit.Text = "Device:";
            // 
            // textBox_aygit_adi
            // 
            this.textBox_aygit_adi.Location = new System.Drawing.Point(84, 106);
            this.textBox_aygit_adi.Name = "textBox_aygit_adi";
            this.textBox_aygit_adi.Size = new System.Drawing.Size(107, 20);
            this.textBox_aygit_adi.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonSendCommand);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Shape Display GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label_seridurum;
        private System.Windows.Forms.Label label_seri_durum;
        private System.Windows.Forms.Button button_yenile;
        private System.Windows.Forms.Button button_baglan;
        private System.Windows.Forms.Label label_seriport;
        private System.Windows.Forms.ComboBox comboBox_seriport;
        private System.Windows.Forms.Button buttonSendCommand;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox_aygit_adi;
        private System.Windows.Forms.Label label_aygit;
    }
}

