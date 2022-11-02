namespace les_4_operations_de_2_valeur
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
            this.btnSomme = new System.Windows.Forms.Button();
            this.lblA = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.lblB = new System.Windows.Forms.Label();
            this.lblResultat = new System.Windows.Forms.Label();
            this.btnSoustraction = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnMultiplucation = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSomme
            // 
            this.btnSomme.Location = new System.Drawing.Point(244, 92);
            this.btnSomme.Name = "btnSomme";
            this.btnSomme.Size = new System.Drawing.Size(131, 42);
            this.btnSomme.TabIndex = 0;
            this.btnSomme.Text = "+";
            this.btnSomme.UseVisualStyleBackColor = true;
            this.btnSomme.Click += new System.EventHandler(this.btnSomme_Click);
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(69, 18);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(20, 20);
            this.lblA.TabIndex = 1;
            this.lblA.Text = "A";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(131, 15);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(126, 26);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(131, 60);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(128, 26);
            this.txtB.TabIndex = 3;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(69, 63);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(20, 20);
            this.lblB.TabIndex = 4;
            this.lblB.Text = "B";
            // 
            // lblResultat
            // 
            this.lblResultat.AutoSize = true;
            this.lblResultat.Location = new System.Drawing.Point(12, 260);
            this.lblResultat.Name = "lblResultat";
            this.lblResultat.Size = new System.Drawing.Size(77, 20);
            this.lblResultat.TabIndex = 5;
            this.lblResultat.Text = "Resultat :";
            // 
            // btnSoustraction
            // 
            this.btnSoustraction.Location = new System.Drawing.Point(244, 140);
            this.btnSoustraction.Name = "btnSoustraction";
            this.btnSoustraction.Size = new System.Drawing.Size(131, 37);
            this.btnSoustraction.TabIndex = 6;
            this.btnSoustraction.Text = "-";
            this.btnSoustraction.UseVisualStyleBackColor = true;
            this.btnSoustraction.Click += new System.EventHandler(this.btnSoustraction_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(244, 183);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(131, 35);
            this.btnDivision.TabIndex = 7;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnMultiplucation
            // 
            this.btnMultiplucation.Location = new System.Drawing.Point(244, 224);
            this.btnMultiplucation.Name = "btnMultiplucation";
            this.btnMultiplucation.Size = new System.Drawing.Size(131, 33);
            this.btnMultiplucation.TabIndex = 8;
            this.btnMultiplucation.Text = "*";
            this.btnMultiplucation.UseVisualStyleBackColor = true;
            this.btnMultiplucation.Click += new System.EventHandler(this.btnMultiplucation_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(99, 257);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(135, 26);
            this.txtResultat.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 334);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnMultiplucation);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSoustraction);
            this.Controls.Add(this.lblResultat);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.btnSomme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSomme;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblResultat;
        private System.Windows.Forms.Button btnSoustraction;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnMultiplucation;
        private System.Windows.Forms.TextBox txtResultat;
    }
}

