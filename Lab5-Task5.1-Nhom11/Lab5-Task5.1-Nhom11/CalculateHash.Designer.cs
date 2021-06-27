
namespace Lab5_Task5._1_Nhom11
{
    partial class CalculateHash
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput = new System.Windows.Forms.TextBox();
            this.cbInputType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMD5 = new System.Windows.Forms.TextBox();
            this.tbSHA1 = new System.Windows.Forms.TextBox();
            this.tbSHA256 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tbSHA384 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSHA512 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("UTM Alberta Heavy", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(174, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(691, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Task 5.1 - Generating message digests (hash values) and HMAC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "MD5";
            // 
            // tbInput
            // 
            this.tbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput.Location = new System.Drawing.Point(146, 114);
            this.tbInput.Margin = new System.Windows.Forms.Padding(2);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(896, 31);
            this.tbInput.TabIndex = 1;
            // 
            // cbInputType
            // 
            this.cbInputType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbInputType.FormattingEnabled = true;
            this.cbInputType.Items.AddRange(new object[] {
            "Text string",
            "Hex string",
            "File"});
            this.cbInputType.Location = new System.Drawing.Point(38, 113);
            this.cbInputType.Margin = new System.Windows.Forms.Padding(2);
            this.cbInputType.Name = "cbInputType";
            this.cbInputType.Size = new System.Drawing.Size(104, 32);
            this.cbInputType.TabIndex = 0;
            this.cbInputType.Text = "Input type";
            this.cbInputType.SelectedIndexChanged += new System.EventHandler(this.cbInputType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "SHA-1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "SHA-256";
            // 
            // tbMD5
            // 
            this.tbMD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMD5.Location = new System.Drawing.Point(146, 199);
            this.tbMD5.Margin = new System.Windows.Forms.Padding(2);
            this.tbMD5.Name = "tbMD5";
            this.tbMD5.Size = new System.Drawing.Size(896, 31);
            this.tbMD5.TabIndex = 5;
            // 
            // tbSHA1
            // 
            this.tbSHA1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA1.Location = new System.Drawing.Point(146, 245);
            this.tbSHA1.Margin = new System.Windows.Forms.Padding(2);
            this.tbSHA1.Name = "tbSHA1";
            this.tbSHA1.Size = new System.Drawing.Size(896, 31);
            this.tbSHA1.TabIndex = 6;
            // 
            // tbSHA256
            // 
            this.tbSHA256.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA256.Location = new System.Drawing.Point(146, 290);
            this.tbSHA256.Margin = new System.Windows.Forms.Padding(2);
            this.tbSHA256.Name = "tbSHA256";
            this.tbSHA256.Size = new System.Drawing.Size(896, 31);
            this.tbSHA256.TabIndex = 7;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.Black;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox5.Location = new System.Drawing.Point(38, 168);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(1002, 2);
            this.textBox5.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(406, 460);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(168, 50);
            this.btnCalculate.TabIndex = 10;
            this.btnCalculate.Text = "CALCULATE";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(606, 460);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(168, 50);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "CLOSE";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbSHA384
            // 
            this.tbSHA384.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA384.Location = new System.Drawing.Point(146, 335);
            this.tbSHA384.Margin = new System.Windows.Forms.Padding(2);
            this.tbSHA384.Name = "tbSHA384";
            this.tbSHA384.Size = new System.Drawing.Size(896, 31);
            this.tbSHA384.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "SHA-384";
            // 
            // tbSHA512
            // 
            this.tbSHA512.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSHA512.Location = new System.Drawing.Point(146, 379);
            this.tbSHA512.Margin = new System.Windows.Forms.Padding(2);
            this.tbSHA512.Name = "tbSHA512";
            this.tbSHA512.Size = new System.Drawing.Size(896, 31);
            this.tbSHA512.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "SHA-512";
            // 
            // CalculateHash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1081, 540);
            this.Controls.Add(this.tbSHA512);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbSHA384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.tbSHA256);
            this.Controls.Add(this.tbSHA1);
            this.Controls.Add(this.tbMD5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbInput);
            this.Controls.Add(this.cbInputType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CalculateHash";
            this.Text = "Task 5.1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.ComboBox cbInputType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMD5;
        private System.Windows.Forms.TextBox tbSHA1;
        private System.Windows.Forms.TextBox tbSHA256;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox tbSHA384;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSHA512;
        private System.Windows.Forms.Label label6;
    }
}

