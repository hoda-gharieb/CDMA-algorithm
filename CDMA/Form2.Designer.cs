namespace CDMA
{
    partial class Form2
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
            this.Send = new System.Windows.Forms.Button();
            this.Rec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Send
            // 
            this.Send.Location = new System.Drawing.Point(60, 45);
            this.Send.Name = "Send";
            this.Send.Size = new System.Drawing.Size(75, 23);
            this.Send.TabIndex = 0;
            this.Send.Text = "Sender";
            this.Send.UseVisualStyleBackColor = true;
            this.Send.Click += new System.EventHandler(this.Sen_clicked);
            // 
            // Rec
            // 
            this.Rec.Location = new System.Drawing.Point(60, 89);
            this.Rec.Name = "Rec";
            this.Rec.Size = new System.Drawing.Size(75, 23);
            this.Rec.TabIndex = 1;
            this.Rec.Text = "Reciever";
            this.Rec.UseVisualStyleBackColor = true;
            this.Rec.Click += new System.EventHandler(this.Rec_clicked);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(199, 164);
            this.Controls.Add(this.Rec);
            this.Controls.Add(this.Send);
            this.Name = "Form2";
            this.Text = "CDMA";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Send;
        private System.Windows.Forms.Button Rec;
    }
}