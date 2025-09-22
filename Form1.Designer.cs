namespace ChangeDNS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DNS_1 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.DNS_2 = new System.Windows.Forms.RadioButton();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // DNS_1
            // 
            this.DNS_1.AutoSize = true;
            this.DNS_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DNS_1.Location = new System.Drawing.Point(46, 19);
            this.DNS_1.Name = "DNS_1";
            this.DNS_1.Size = new System.Drawing.Size(91, 29);
            this.DNS_1.TabIndex = 0;
            this.DNS_1.TabStop = true;
            this.DNS_1.Text = "Default";
            this.DNS_1.UseVisualStyleBackColor = true;
            this.DNS_1.CheckedChanged += new System.EventHandler(this.DNS_1_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apply And Exit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.DNS_2);
            this.groupBox.Controls.Add(this.DNS_1);
            this.groupBox.Location = new System.Drawing.Point(12, 31);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(361, 65);
            this.groupBox.TabIndex = 4;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Chọn 1 trong 2 DNS";
            // 
            // DNS_2
            // 
            this.DNS_2.AutoSize = true;
            this.DNS_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.DNS_2.Location = new System.Drawing.Point(212, 19);
            this.DNS_2.Name = "DNS_2";
            this.DNS_2.Size = new System.Drawing.Size(93, 29);
            this.DNS_2.TabIndex = 1;
            this.DNS_2.TabStop = true;
            this.DNS_2.Text = "Google";
            this.DNS_2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 160);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton DNS_1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RadioButton DNS_2;
    }
}

