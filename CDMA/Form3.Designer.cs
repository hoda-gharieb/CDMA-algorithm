namespace CDMA
{
    partial class Form3
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
            this.DataS = new System.Windows.Forms.TextBox();
            this.Key = new System.Windows.Forms.TextBox();
            this.Signal = new System.Windows.Forms.TextBox();
            this.bit_0 = new System.Windows.Forms.TextBox();
            this.bit_1 = new System.Windows.Forms.TextBox();
            this.Gen = new System.Windows.Forms.Button();
            this.OrSig = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DataS
            // 
            this.DataS.Location = new System.Drawing.Point(31, 33);
            this.DataS.Name = "DataS";
            this.DataS.Size = new System.Drawing.Size(100, 20);
            this.DataS.TabIndex = 0;
            // 
            // Key
            // 
            this.Key.Location = new System.Drawing.Point(31, 91);
            this.Key.Name = "Key";
            this.Key.Size = new System.Drawing.Size(100, 20);
            this.Key.TabIndex = 1;
            // 
            // Signal
            // 
            this.Signal.Location = new System.Drawing.Point(31, 144);
            this.Signal.Name = "Signal";
            this.Signal.Size = new System.Drawing.Size(261, 20);
            this.Signal.TabIndex = 2;
            // 
            // bit_0
            // 
            this.bit_0.Location = new System.Drawing.Point(235, 32);
            this.bit_0.Name = "bit_0";
            this.bit_0.Size = new System.Drawing.Size(58, 20);
            this.bit_0.TabIndex = 3;
            // 
            // bit_1
            // 
            this.bit_1.Location = new System.Drawing.Point(360, 32);
            this.bit_1.Name = "bit_1";
            this.bit_1.Size = new System.Drawing.Size(58, 20);
            this.bit_1.TabIndex = 4;
            // 
            // Gen
            // 
            this.Gen.Location = new System.Drawing.Point(176, 188);
            this.Gen.Name = "Gen";
            this.Gen.Size = new System.Drawing.Size(75, 23);
            this.Gen.TabIndex = 5;
            this.Gen.Text = "Generate";
            this.Gen.UseVisualStyleBackColor = true;
            this.Gen.Click += new System.EventHandler(this.Gen_CLicked);
            // 
            // OrSig
            // 
            this.OrSig.Location = new System.Drawing.Point(31, 247);
            this.OrSig.Name = "OrSig";
            this.OrSig.Size = new System.Drawing.Size(261, 20);
            this.OrSig.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Original Signal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Signal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Key";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Size";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "0-bit value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(360, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "1-bit value";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 296);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrSig);
            this.Controls.Add(this.Gen);
            this.Controls.Add(this.bit_1);
            this.Controls.Add(this.bit_0);
            this.Controls.Add(this.Signal);
            this.Controls.Add(this.Key);
            this.Controls.Add(this.DataS);
            this.Name = "Form3";
            this.Text = "Reciever";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DataS;
        private System.Windows.Forms.TextBox Key;
        private System.Windows.Forms.TextBox Signal;
        private System.Windows.Forms.TextBox bit_0;
        private System.Windows.Forms.TextBox bit_1;
        private System.Windows.Forms.Button Gen;
        private System.Windows.Forms.TextBox OrSig;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}