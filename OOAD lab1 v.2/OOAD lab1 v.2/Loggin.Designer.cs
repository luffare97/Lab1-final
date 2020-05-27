namespace OOAD_lab1_v._2
{
    partial class Loggin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LoggaInKnapp = new System.Windows.Forms.Button();
            this.Lösenordtext = new System.Windows.Forms.TextBox();
            this.IDtext = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "AnvändarID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Lösenord:";
            // 
            // LoggaInKnapp
            // 
            this.LoggaInKnapp.Location = new System.Drawing.Point(113, 65);
            this.LoggaInKnapp.Name = "LoggaInKnapp";
            this.LoggaInKnapp.Size = new System.Drawing.Size(99, 25);
            this.LoggaInKnapp.TabIndex = 7;
            this.LoggaInKnapp.Text = "Logga in";
            this.LoggaInKnapp.UseVisualStyleBackColor = true;
            this.LoggaInKnapp.Click += new System.EventHandler(this.LoggaInKnapp_Click);
            // 
            // Lösenordtext
            // 
            this.Lösenordtext.Location = new System.Drawing.Point(91, 39);
            this.Lösenordtext.Name = "Lösenordtext";
            this.Lösenordtext.PasswordChar = '*';
            this.Lösenordtext.Size = new System.Drawing.Size(121, 20);
            this.Lösenordtext.TabIndex = 6;
            // 
            // IDtext
            // 
            this.IDtext.Location = new System.Drawing.Point(91, 12);
            this.IDtext.Name = "IDtext";
            this.IDtext.Size = new System.Drawing.Size(121, 20);
            this.IDtext.TabIndex = 5;
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 106);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoggaInKnapp);
            this.Controls.Add(this.Lösenordtext);
            this.Controls.Add(this.IDtext);
            this.Name = "Loggin";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button LoggaInKnapp;
        private System.Windows.Forms.TextBox Lösenordtext;
        private System.Windows.Forms.TextBox IDtext;
    }
}

