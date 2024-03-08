namespace ComReadWirteApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            cBoxComPort = new ComboBox();
            cBoxDataBits = new ComboBox();
            label2 = new Label();
            cBoxBaudRate = new ComboBox();
            label3 = new Label();
            cBoxStopBits = new ComboBox();
            label4 = new Label();
            cBoxParityBits = new ComboBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            lblMsg = new Label();
            progressBar1 = new ProgressBar();
            btnClose = new Button();
            btnOpen = new Button();
            btnSendData = new Button();
            tBoxDataOut = new TextBox();
            tBoxRead = new TextBox();
            cBoxPort2 = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 23);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "COM Port 1";
            // 
            // cBoxComPort
            // 
            cBoxComPort.FormattingEnabled = true;
            cBoxComPort.Location = new Point(126, 20);
            cBoxComPort.Name = "cBoxComPort";
            cBoxComPort.Size = new Size(151, 28);
            cBoxComPort.TabIndex = 1;
            // 
            // cBoxDataBits
            // 
            cBoxDataBits.FormattingEnabled = true;
            cBoxDataBits.Items.AddRange(new object[] { "5", "7", "8" });
            cBoxDataBits.Location = new Point(126, 124);
            cBoxDataBits.Name = "cBoxDataBits";
            cBoxDataBits.Size = new Size(151, 28);
            cBoxDataBits.TabIndex = 3;
            cBoxDataBits.Text = "8";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 93);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 2;
            label2.Text = "BAUD Rate";
            // 
            // cBoxBaudRate
            // 
            cBoxBaudRate.FormattingEnabled = true;
            cBoxBaudRate.Items.AddRange(new object[] { "2400", "4800", "9600" });
            cBoxBaudRate.Location = new Point(126, 85);
            cBoxBaudRate.Name = "cBoxBaudRate";
            cBoxBaudRate.Size = new Size(151, 28);
            cBoxBaudRate.TabIndex = 5;
            cBoxBaudRate.Text = "9600";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 132);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 4;
            label3.Text = "Data Bits";
            // 
            // cBoxStopBits
            // 
            cBoxStopBits.FormattingEnabled = true;
            cBoxStopBits.Items.AddRange(new object[] { "One", "Two" });
            cBoxStopBits.Location = new Point(126, 165);
            cBoxStopBits.Name = "cBoxStopBits";
            cBoxStopBits.Size = new Size(151, 28);
            cBoxStopBits.TabIndex = 7;
            cBoxStopBits.Text = "One";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 173);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 6;
            label4.Text = "Stop Bits";
            // 
            // cBoxParityBits
            // 
            cBoxParityBits.FormattingEnabled = true;
            cBoxParityBits.Items.AddRange(new object[] { "None", "Odd", "Even" });
            cBoxParityBits.Location = new Point(126, 205);
            cBoxParityBits.Name = "cBoxParityBits";
            cBoxParityBits.Size = new Size(151, 28);
            cBoxParityBits.TabIndex = 9;
            cBoxParityBits.Text = "None";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 208);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 8;
            label5.Text = "Parity Bits";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblMsg);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(btnClose);
            groupBox1.Controls.Add(btnOpen);
            groupBox1.Location = new Point(27, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(308, 153);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // lblMsg
            // 
            lblMsg.AutoSize = true;
            lblMsg.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMsg.Location = new Point(32, 116);
            lblMsg.Name = "lblMsg";
            lblMsg.Size = new Size(36, 20);
            lblMsg.TabIndex = 12;
            lblMsg.Text = "OFF";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(15, 75);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(235, 29);
            progressBar1.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(156, 36);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 1;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnOpen
            // 
            btnOpen.Location = new Point(15, 36);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(94, 29);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSendData
            // 
            btnSendData.Location = new Point(341, 250);
            btnSendData.Name = "btnSendData";
            btnSendData.Size = new Size(300, 142);
            btnSendData.TabIndex = 3;
            btnSendData.Text = "Read / Write Data";
            btnSendData.UseVisualStyleBackColor = true;
            btnSendData.Click += btnSendData_Click;
            // 
            // tBoxDataOut
            // 
            tBoxDataOut.Location = new Point(341, 52);
            tBoxDataOut.Multiline = true;
            tBoxDataOut.Name = "tBoxDataOut";
            tBoxDataOut.Size = new Size(300, 167);
            tBoxDataOut.TabIndex = 11;
            // 
            // tBoxRead
            // 
            tBoxRead.Location = new Point(647, 52);
            tBoxRead.Multiline = true;
            tBoxRead.Name = "tBoxRead";
            tBoxRead.Size = new Size(362, 169);
            tBoxRead.TabIndex = 12;
            // 
            // cBoxPort2
            // 
            cBoxPort2.FormattingEnabled = true;
            cBoxPort2.Location = new Point(126, 52);
            cBoxPort2.Name = "cBoxPort2";
            cBoxPort2.Size = new Size(151, 28);
            cBoxPort2.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(28, 61);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 13;
            label6.Text = "COM Port 2";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(418, 23);
            label7.Name = "label7";
            label7.Size = new Size(81, 20);
            label7.TabIndex = 15;
            label7.Text = "Write Data";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(779, 29);
            label8.Name = "label8";
            label8.Size = new Size(79, 20);
            label8.TabIndex = 16;
            label8.Text = "Read Data";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1051, 617);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(cBoxPort2);
            Controls.Add(label6);
            Controls.Add(tBoxRead);
            Controls.Add(tBoxDataOut);
            Controls.Add(btnSendData);
            Controls.Add(groupBox1);
            Controls.Add(cBoxParityBits);
            Controls.Add(label5);
            Controls.Add(cBoxStopBits);
            Controls.Add(label4);
            Controls.Add(cBoxBaudRate);
            Controls.Add(label3);
            Controls.Add(cBoxDataBits);
            Controls.Add(label2);
            Controls.Add(cBoxComPort);
            Controls.Add(label1);
            Name = "Form1";
            Text = "C# COM App";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cBoxComPort;
        private ComboBox cBoxDataBits;
        private Label label2;
        private ComboBox cBoxBaudRate;
        private Label label3;
        private ComboBox cBoxStopBits;
        private Label label4;
        private ComboBox cBoxParityBits;
        private Label label5;
        private GroupBox groupBox1;
        private ProgressBar progressBar1;
        private Button btnClose;
        private Button btnOpen;
        private Button btnSendData;
        private TextBox tBoxDataOut;
        private Label lblMsg;
        private TextBox tBoxRead;
        private ComboBox cBoxPort2;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}
