namespace FormaDai
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.panel2 = new System.Windows.Forms.Panel();
            this.LbWelcome = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btModule = new System.Windows.Forms.Button();
            this.BtSession = new System.Windows.Forms.Button();
            this.BtFormateur = new System.Windows.Forms.Button();
            this.BtStagiaire = new System.Windows.Forms.Button();
            this.LbMenu = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.Controls.Add(this.LbWelcome);
            this.panel2.Location = new System.Drawing.Point(136, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 102);
            this.panel2.TabIndex = 5;
            // 
            // LbWelcome
            // 
            this.LbWelcome.AutoSize = true;
            this.LbWelcome.Font = new System.Drawing.Font("Segoe Print", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbWelcome.ForeColor = System.Drawing.Color.Gray;
            this.LbWelcome.Location = new System.Drawing.Point(195, 16);
            this.LbWelcome.Name = "LbWelcome";
            this.LbWelcome.Size = new System.Drawing.Size(237, 57);
            this.LbWelcome.TabIndex = 0;
            this.LbWelcome.Text = "BIENVENUE ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(122, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btModule
            // 
            this.btModule.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModule.Location = new System.Drawing.Point(3, 390);
            this.btModule.Name = "btModule";
            this.btModule.Size = new System.Drawing.Size(124, 44);
            this.btModule.TabIndex = 4;
            this.btModule.Text = "Module";
            this.btModule.UseVisualStyleBackColor = true;
            // 
            // BtSession
            // 
            this.BtSession.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtSession.Location = new System.Drawing.Point(5, 340);
            this.BtSession.Name = "BtSession";
            this.BtSession.Size = new System.Drawing.Size(124, 44);
            this.BtSession.TabIndex = 3;
            this.BtSession.Text = "Session";
            this.BtSession.UseVisualStyleBackColor = true;
            // 
            // BtFormateur
            // 
            this.BtFormateur.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFormateur.Location = new System.Drawing.Point(5, 290);
            this.BtFormateur.Name = "BtFormateur";
            this.BtFormateur.Size = new System.Drawing.Size(124, 44);
            this.BtFormateur.TabIndex = 2;
            this.BtFormateur.Text = "Formateur";
            this.BtFormateur.UseVisualStyleBackColor = true;
            // 
            // BtStagiaire
            // 
            this.BtStagiaire.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtStagiaire.Location = new System.Drawing.Point(5, 240);
            this.BtStagiaire.Name = "BtStagiaire";
            this.BtStagiaire.Size = new System.Drawing.Size(124, 44);
            this.BtStagiaire.TabIndex = 1;
            this.BtStagiaire.Text = "Stagiaire";
            this.BtStagiaire.UseVisualStyleBackColor = true;
            // 
            // LbMenu
            // 
            this.LbMenu.AutoSize = true;
            this.LbMenu.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMenu.Location = new System.Drawing.Point(20, 102);
            this.LbMenu.Name = "LbMenu";
            this.LbMenu.Size = new System.Drawing.Size(76, 33);
            this.LbMenu.TabIndex = 0;
            this.LbMenu.Text = "MENU";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(136, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(648, 457);
            this.panel3.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btModule);
            this.panel1.Controls.Add(this.BtSession);
            this.panel1.Controls.Add(this.BtFormateur);
            this.panel1.Controls.Add(this.BtStagiaire);
            this.panel1.Controls.Add(this.LbMenu);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 561);
            this.panel1.TabIndex = 4;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LbWelcome;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btModule;
        private System.Windows.Forms.Button BtSession;
        private System.Windows.Forms.Button BtFormateur;
        private System.Windows.Forms.Button BtStagiaire;
        private System.Windows.Forms.Label LbMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
    }
}