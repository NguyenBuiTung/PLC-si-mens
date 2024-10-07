namespace S7_1200_with_CSharp
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
            this.txtIpAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWriteData = new System.Windows.Forms.TextBox();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnReadFloat = new System.Windows.Forms.Button();
            this.btnWriteFloat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIpAddress
            // 
            this.txtIpAddress.Location = new System.Drawing.Point(92, 82);
            this.txtIpAddress.Name = "txtIpAddress";
            this.txtIpAddress.Size = new System.Drawing.Size(194, 20);
            this.txtIpAddress.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập IP kết nối";
            // 
            // txtWriteData
            // 
            this.txtWriteData.Location = new System.Drawing.Point(510, 145);
            this.txtWriteData.Name = "txtWriteData";
            this.txtWriteData.Size = new System.Drawing.Size(194, 20);
            this.txtWriteData.TabIndex = 2;
            // 
            // txtReadData
            // 
            this.txtReadData.Location = new System.Drawing.Point(510, 81);
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.ReadOnly = true;
            this.txtReadData.Size = new System.Drawing.Size(194, 20);
            this.txtReadData.TabIndex = 3;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Chartreuse;
            this.btnConnect.Location = new System.Drawing.Point(92, 145);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(194, 67);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Kết nối";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click_1);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(745, 82);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(75, 23);
            this.btnRead.TabIndex = 5;
            this.btnRead.Text = "Đọc";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click_1);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(745, 145);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(75, 23);
            this.btnWrite.TabIndex = 6;
            this.btnWrite.Text = "Ghi";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click_1);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(381, 48);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(35, 13);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "label2";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDisconnect.Location = new System.Drawing.Point(92, 244);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(194, 67);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = " Ngắt kết nối";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnReadFloat
            // 
            this.btnReadFloat.Location = new System.Drawing.Point(745, 219);
            this.btnReadFloat.Name = "btnReadFloat";
            this.btnReadFloat.Size = new System.Drawing.Size(75, 23);
            this.btnReadFloat.TabIndex = 9;
            this.btnReadFloat.Text = "Đọc số thực";
            this.btnReadFloat.UseVisualStyleBackColor = true;
            this.btnReadFloat.Click += new System.EventHandler(this.btnReadFloat_Click);
            // 
            // btnWriteFloat
            // 
            this.btnWriteFloat.Location = new System.Drawing.Point(745, 288);
            this.btnWriteFloat.Name = "btnWriteFloat";
            this.btnWriteFloat.Size = new System.Drawing.Size(75, 23);
            this.btnWriteFloat.TabIndex = 10;
            this.btnWriteFloat.Text = "Ghi số thực";
            this.btnWriteFloat.UseVisualStyleBackColor = true;
            this.btnWriteFloat.Click += new System.EventHandler(this.btnWriteFloat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 598);
            this.Controls.Add(this.btnWriteFloat);
            this.Controls.Add(this.btnReadFloat);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtReadData);
            this.Controls.Add(this.txtWriteData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtIpAddress);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIpAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWriteData;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnReadFloat;
        private System.Windows.Forms.Button btnWriteFloat;
    }
}

