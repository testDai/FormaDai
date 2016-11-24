namespace FormaDai
{
    partial class FenetreAjouterModule
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
            this.lbAjouterModule = new System.Windows.Forms.Label();
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtNbJour = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbAjouterModule
            // 
            this.lbAjouterModule.AutoSize = true;
            this.lbAjouterModule.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAjouterModule.ForeColor = System.Drawing.Color.White;
            this.lbAjouterModule.Location = new System.Drawing.Point(104, 68);
            this.lbAjouterModule.Name = "lbAjouterModule";
            this.lbAjouterModule.Size = new System.Drawing.Size(196, 25);
            this.lbAjouterModule.TabIndex = 0;
            this.lbAjouterModule.Text = "Ajout d\'un module";
            // 
            // txtIntitule
            // 
            this.txtIntitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntitule.Location = new System.Drawing.Point(80, 117);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(221, 27);
            this.txtIntitule.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(80, 170);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 100);
            this.txtDescription.TabIndex = 2;
            // 
            // txtNbJour
            // 
            this.txtNbJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNbJour.Location = new System.Drawing.Point(148, 295);
            this.txtNbJour.Name = "txtNbJour";
            this.txtNbJour.Size = new System.Drawing.Size(86, 27);
            this.txtNbJour.TabIndex = 3;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LightGray;
            this.btValider.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValider.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.ForeColor = System.Drawing.Color.Black;
            this.btValider.Location = new System.Drawing.Point(109, 351);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(165, 37);
            this.btValider.TabIndex = 4;
            this.btValider.Text = "Enregistrer";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FenetreAjouterModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(448, 476);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.txtNbJour);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIntitule);
            this.Controls.Add(this.lbAjouterModule);
            this.DoubleBuffered = true;
            this.Name = "FenetreAjouterModule";
            this.Text = "FenetreAjouterModule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbAjouterModule;
        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtNbJour;
        private System.Windows.Forms.Button btValider;
    }
}