namespace FormaDai
{
    partial class FenetreAccueil
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabFormation = new System.Windows.Forms.TabPage();
            this.tabPersonnes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.lbNom = new System.Windows.Forms.Label();
            this.lbPrenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabFormation.SuspendLayout();
            this.tabPersonnes.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabFormation);
            this.tabControl1.Controls.Add(this.tabPersonnes);
            this.tabControl1.Location = new System.Drawing.Point(12, 45);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 441);
            this.tabControl1.TabIndex = 1;
            // 
            // tabFormation
            // 
            this.tabFormation.Controls.Add(this.button1);
            this.tabFormation.Location = new System.Drawing.Point(4, 22);
            this.tabFormation.Name = "tabFormation";
            this.tabFormation.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormation.Size = new System.Drawing.Size(752, 415);
            this.tabFormation.TabIndex = 0;
            this.tabFormation.Text = "Formations";
            this.tabFormation.UseVisualStyleBackColor = true;
            // 
            // tabPersonnes
            // 
            this.tabPersonnes.Controls.Add(this.btValider);
            this.tabPersonnes.Controls.Add(this.txtPrenom);
            this.tabPersonnes.Controls.Add(this.txtNom);
            this.tabPersonnes.Controls.Add(this.lbPrenom);
            this.tabPersonnes.Controls.Add(this.lbNom);
            this.tabPersonnes.Location = new System.Drawing.Point(4, 22);
            this.tabPersonnes.Name = "tabPersonnes";
            this.tabPersonnes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPersonnes.Size = new System.Drawing.Size(752, 415);
            this.tabPersonnes.TabIndex = 1;
            this.tabPersonnes.Text = "Personnes";
            this.tabPersonnes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(86, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(32, 57);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(29, 13);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom";
            // 
            // lbPrenom
            // 
            this.lbPrenom.AutoSize = true;
            this.lbPrenom.Location = new System.Drawing.Point(32, 128);
            this.lbPrenom.Name = "lbPrenom";
            this.lbPrenom.Size = new System.Drawing.Size(43, 13);
            this.lbPrenom.TabIndex = 1;
            this.lbPrenom.Text = "Prénom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(98, 57);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(98, 121);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(98, 228);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FenetreAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FenetreAccueil";
            this.Text = "Accueil ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabFormation.ResumeLayout(false);
            this.tabPersonnes.ResumeLayout(false);
            this.tabPersonnes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabFormation;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPersonnes;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lbPrenom;
        private System.Windows.Forms.Label lbNom;
    }
}