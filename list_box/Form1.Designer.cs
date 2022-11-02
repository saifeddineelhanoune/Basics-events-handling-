namespace list_box
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
            this.listville = new System.Windows.Forms.ListBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.btnAffichertt = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.txtville = new System.Windows.Forms.TextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnInserer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listville
            // 
            this.listville.FormattingEnabled = true;
            this.listville.Location = new System.Drawing.Point(17, 14);
            this.listville.Name = "listville";
            this.listville.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listville.Size = new System.Drawing.Size(101, 199);
            this.listville.TabIndex = 0;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.Color.White;
            this.btnAfficher.ForeColor = System.Drawing.Color.Red;
            this.btnAfficher.Location = new System.Drawing.Point(127, 111);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(86, 44);
            this.btnAfficher.TabIndex = 1;
            this.btnAfficher.Text = "AFFICHER";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // btnAffichertt
            // 
            this.btnAffichertt.BackColor = System.Drawing.Color.White;
            this.btnAffichertt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnAffichertt.Location = new System.Drawing.Point(219, 111);
            this.btnAffichertt.Name = "btnAffichertt";
            this.btnAffichertt.Size = new System.Drawing.Size(86, 44);
            this.btnAffichertt.TabIndex = 2;
            this.btnAffichertt.Text = "AFFICHER TOUS";
            this.btnAffichertt.UseVisualStyleBackColor = false;
            this.btnAffichertt.Click += new System.EventHandler(this.btnAffichertt_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.White;
            this.btnSupprimer.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSupprimer.Location = new System.Drawing.Point(127, 62);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(86, 43);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "SUPPRIMER";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.White;
            this.btnAjouter.ForeColor = System.Drawing.Color.Coral;
            this.btnAjouter.Location = new System.Drawing.Point(219, 62);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(86, 43);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.button4_Click);
            // 
            // txtville
            // 
            this.txtville.Location = new System.Drawing.Point(127, 29);
            this.txtville.Name = "txtville";
            this.txtville.Size = new System.Drawing.Size(175, 20);
            this.txtville.TabIndex = 5;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.Color.White;
            this.btnQuitter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnQuitter.Location = new System.Drawing.Point(127, 159);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(86, 44);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "QUITTER";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnInserer
            // 
            this.btnInserer.BackColor = System.Drawing.Color.White;
            this.btnInserer.ForeColor = System.Drawing.Color.Purple;
            this.btnInserer.Location = new System.Drawing.Point(219, 159);
            this.btnInserer.Name = "btnInserer";
            this.btnInserer.Size = new System.Drawing.Size(86, 44);
            this.btnInserer.TabIndex = 7;
            this.btnInserer.Text = "REMPLACER";
            this.btnInserer.UseVisualStyleBackColor = false;
            this.btnInserer.Click += new System.EventHandler(this.btnInserer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 224);
            this.Controls.Add(this.btnInserer);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.txtville);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAffichertt);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.listville);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listville;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Button btnAffichertt;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox txtville;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnInserer;
    }
}

