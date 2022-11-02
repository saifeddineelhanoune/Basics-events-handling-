namespace list_des_villes
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnRemplir = new System.Windows.Forms.Button();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnselect = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.listVilles = new System.Windows.Forms.ListBox();
            this.txtVilles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(123, 48);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(145, 40);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnRemplir
            // 
            this.btnRemplir.Location = new System.Drawing.Point(123, 94);
            this.btnRemplir.Name = "btnRemplir";
            this.btnRemplir.Size = new System.Drawing.Size(145, 40);
            this.btnRemplir.TabIndex = 1;
            this.btnRemplir.Text = "REMPLIR";
            this.btnRemplir.UseVisualStyleBackColor = true;
            this.btnRemplir.Click += new System.EventHandler(this.btnRemplir_Click);
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(8, 140);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(260, 25);
            this.btnAfficher.TabIndex = 2;
            this.btnAfficher.Text = "Afficher l\'élement selectionné";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnselect
            // 
            this.btnselect.Location = new System.Drawing.Point(8, 171);
            this.btnselect.Name = "btnselect";
            this.btnselect.Size = new System.Drawing.Size(260, 25);
            this.btnselect.TabIndex = 3;
            this.btnselect.Text = "La liste des villes sélectionné";
            this.btnselect.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(8, 202);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(260, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "Forcer casa a apparaitre selectionné";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(8, 233);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 25);
            this.button6.TabIndex = 5;
            this.button6.Text = "Chercher si le dernier élement est sélectionné";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // listVilles
            // 
            this.listVilles.FormattingEnabled = true;
            this.listVilles.Location = new System.Drawing.Point(8, 13);
            this.listVilles.Name = "listVilles";
            this.listVilles.ScrollAlwaysVisible = true;
            this.listVilles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listVilles.Size = new System.Drawing.Size(109, 121);
            this.listVilles.TabIndex = 6;
            // 
            // txtVilles
            // 
            this.txtVilles.Location = new System.Drawing.Point(126, 17);
            this.txtVilles.Multiline = true;
            this.txtVilles.Name = "txtVilles";
            this.txtVilles.Size = new System.Drawing.Size(142, 20);
            this.txtVilles.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 271);
            this.Controls.Add(this.txtVilles);
            this.Controls.Add(this.listVilles);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnselect);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.btnRemplir);
            this.Controls.Add(this.btnAjouter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnRemplir;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnselect;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ListBox listVilles;
        private System.Windows.Forms.TextBox txtVilles;
    }
}

