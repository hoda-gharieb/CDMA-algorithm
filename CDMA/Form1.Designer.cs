namespace CDMA
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
            this.New = new System.Windows.Forms.Button();
            this.KeyS = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.signal = new System.Windows.Forms.TextBox();
            this.summation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bit_0 = new System.Windows.Forms.TextBox();
            this.bit_1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // New
            // 
            this.New.Location = new System.Drawing.Point(32, 24);
            this.New.Name = "New";
            this.New.Size = new System.Drawing.Size(75, 23);
            this.New.TabIndex = 0;
            this.New.Text = "new";
            this.New.UseVisualStyleBackColor = true;
            this.New.Click += new System.EventHandler(this.NewClicked);
            // 
            // KeyS
            // 
            this.KeyS.Location = new System.Drawing.Point(32, 84);
            this.KeyS.Name = "KeyS";
            this.KeyS.Size = new System.Drawing.Size(130, 20);
            this.KeyS.TabIndex = 1;
            // 
            // Data
            // 
            this.Data.Location = new System.Drawing.Point(32, 135);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(130, 20);
            this.Data.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Data";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Signal";
            // 
            // signal
            // 
            this.signal.Location = new System.Drawing.Point(32, 246);
            this.signal.Name = "signal";
            this.signal.Size = new System.Drawing.Size(295, 20);
            this.signal.TabIndex = 6;
            // 
            // summation
            // 
            this.summation.Location = new System.Drawing.Point(32, 319);
            this.summation.Name = "summation";
            this.summation.Size = new System.Drawing.Size(295, 20);
            this.summation.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Signal Summation";
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(32, 177);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 9;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_clicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(291, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "0-bit value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(421, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "1-bit value";
            // 
            // bit_0
            // 
            this.bit_0.Location = new System.Drawing.Point(294, 84);
            this.bit_0.Name = "bit_0";
            this.bit_0.Size = new System.Drawing.Size(55, 20);
            this.bit_0.TabIndex = 12;
            // 
            // bit_1
            // 
            this.bit_1.Location = new System.Drawing.Point(424, 83);
            this.bit_1.Name = "bit_1";
            this.bit_1.Size = new System.Drawing.Size(55, 20);
            this.bit_1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 367);
            this.Controls.Add(this.bit_1);
            this.Controls.Add(this.bit_0);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.summation);
            this.Controls.Add(this.signal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.KeyS);
            this.Controls.Add(this.New);
            this.Name = "Form1";
            this.Text = "Sender";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button New;
        private System.Windows.Forms.TextBox KeyS;
        private System.Windows.Forms.TextBox Data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox signal;
        private System.Windows.Forms.TextBox summation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bit_0;
        private System.Windows.Forms.TextBox bit_1;
    }
}

