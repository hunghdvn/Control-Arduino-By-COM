namespace DemoWinApp
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
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cbbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnOn1 = new System.Windows.Forms.Button();
            this.btnOn2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOff2 = new System.Windows.Forms.Button();
            this.btnOff1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 500;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn cổng";
            // 
            // cbbPort
            // 
            this.cbbPort.FormattingEnabled = true;
            this.cbbPort.Location = new System.Drawing.Point(193, 38);
            this.cbbPort.Name = "cbbPort";
            this.cbbPort.Size = new System.Drawing.Size(192, 26);
            this.cbbPort.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.LimeGreen;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(422, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(118, 36);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnOn1
            // 
            this.btnOn1.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOn1.FlatAppearance.BorderSize = 0;
            this.btnOn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn1.Location = new System.Drawing.Point(139, 16);
            this.btnOn1.Name = "btnOn1";
            this.btnOn1.Size = new System.Drawing.Size(118, 36);
            this.btnOn1.TabIndex = 2;
            this.btnOn1.Text = "Bật 1";
            this.btnOn1.UseVisualStyleBackColor = false;
            this.btnOn1.Click += new System.EventHandler(this.btnOn1_Click);
            // 
            // btnOn2
            // 
            this.btnOn2.BackColor = System.Drawing.Color.LimeGreen;
            this.btnOn2.FlatAppearance.BorderSize = 0;
            this.btnOn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOn2.Location = new System.Drawing.Point(367, 16);
            this.btnOn2.Name = "btnOn2";
            this.btnOn2.Size = new System.Drawing.Size(118, 36);
            this.btnOn2.TabIndex = 2;
            this.btnOn2.Text = "Bật 2";
            this.btnOn2.UseVisualStyleBackColor = false;
            this.btnOn2.Click += new System.EventHandler(this.btnOn2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbbPort);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kết nối";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOff2);
            this.groupBox2.Controls.Add(this.btnOn2);
            this.groupBox2.Controls.Add(this.btnOff1);
            this.groupBox2.Controls.Add(this.btnOn1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(0, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 127);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điều khiển";
            // 
            // btnOff2
            // 
            this.btnOff2.BackColor = System.Drawing.Color.Red;
            this.btnOff2.FlatAppearance.BorderSize = 0;
            this.btnOff2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff2.ForeColor = System.Drawing.Color.White;
            this.btnOff2.Location = new System.Drawing.Point(367, 74);
            this.btnOff2.Name = "btnOff2";
            this.btnOff2.Size = new System.Drawing.Size(118, 36);
            this.btnOff2.TabIndex = 2;
            this.btnOff2.Text = "Tắt 2";
            this.btnOff2.UseVisualStyleBackColor = false;
            this.btnOff2.Click += new System.EventHandler(this.btnOff2_Click);
            // 
            // btnOff1
            // 
            this.btnOff1.BackColor = System.Drawing.Color.Red;
            this.btnOff1.FlatAppearance.BorderSize = 0;
            this.btnOff1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOff1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOff1.ForeColor = System.Drawing.Color.White;
            this.btnOff1.Location = new System.Drawing.Point(139, 74);
            this.btnOff1.Name = "btnOff1";
            this.btnOff1.Size = new System.Drawing.Size(118, 36);
            this.btnOff1.TabIndex = 2;
            this.btnOff1.Text = "Tắt 1";
            this.btnOff1.UseVisualStyleBackColor = false;
            this.btnOff1.Click += new System.EventHandler(this.btnOff1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 233);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demo Control Arduino by COM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnOn1;
        private System.Windows.Forms.Button btnOn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOff2;
        private System.Windows.Forms.Button btnOff1;
    }
}

