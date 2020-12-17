namespace TP1WindowsFormsApp1
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
            this.Txtx = new System.Windows.Forms.TextBox();
            this.Txty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txtz = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btplus = new System.Windows.Forms.Button();
            this.Btmult = new System.Windows.Forms.Button();
            this.Btsous = new System.Windows.Forms.Button();
            this.Btdiv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txtx
            // 
            this.Txtx.Location = new System.Drawing.Point(387, 111);
            this.Txtx.Name = "Txtx";
            this.Txtx.Size = new System.Drawing.Size(272, 31);
            this.Txtx.TabIndex = 0;
            // 
            // Txty
            // 
            this.Txty.Location = new System.Drawing.Point(387, 231);
            this.Txty.Name = "Txty";
            this.Txty.Size = new System.Drawing.Size(272, 31);
            this.Txty.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "y";
            // 
            // Txtz
            // 
            this.Txtz.Location = new System.Drawing.Point(387, 303);
            this.Txtz.Name = "Txtz";
            this.Txtz.Size = new System.Drawing.Size(272, 31);
            this.Txtz.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 303);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "resultat";
            // 
            // Btplus
            // 
            this.Btplus.Location = new System.Drawing.Point(82, 372);
            this.Btplus.Name = "Btplus";
            this.Btplus.Size = new System.Drawing.Size(111, 46);
            this.Btplus.TabIndex = 6;
            this.Btplus.Text = "+";
            this.Btplus.UseVisualStyleBackColor = true;
            // 
            // Btmult
            // 
            this.Btmult.Location = new System.Drawing.Point(557, 382);
            this.Btmult.Name = "Btmult";
            this.Btmult.Size = new System.Drawing.Size(132, 36);
            this.Btmult.TabIndex = 7;
            this.Btmult.Text = "/";
            this.Btmult.UseVisualStyleBackColor = true;
            // 
            // Btsous
            // 
            this.Btsous.Location = new System.Drawing.Point(243, 372);
            this.Btsous.Name = "Btsous";
            this.Btsous.Size = new System.Drawing.Size(96, 46);
            this.Btsous.TabIndex = 8;
            this.Btsous.Text = "-";
            this.Btsous.UseVisualStyleBackColor = true;
            // 
            // Btdiv
            // 
            this.Btdiv.Location = new System.Drawing.Point(387, 372);
            this.Btdiv.Name = "Btdiv";
            this.Btdiv.Size = new System.Drawing.Size(106, 46);
            this.Btdiv.TabIndex = 9;
            this.Btdiv.Text = "*";
            this.Btdiv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btdiv);
            this.Controls.Add(this.Btsous);
            this.Controls.Add(this.Btmult);
            this.Controls.Add(this.Btplus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txtz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txty);
            this.Controls.Add(this.Txtx);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtx;
        private System.Windows.Forms.TextBox Txty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txtz;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btplus;
        private System.Windows.Forms.Button Btmult;
        private System.Windows.Forms.Button Btsous;
        private System.Windows.Forms.Button Btdiv;
    }
}

