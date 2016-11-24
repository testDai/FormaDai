namespace FormaDai
{
    partial class FenetreAjouterFormation
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
            this.txtIntitule = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btValider = new System.Windows.Forms.Button();
            this.btAjoutFormation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtIntitule
            // 
            this.txtIntitule.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntitule.Location = new System.Drawing.Point(67, 109);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(158, 28);
            this.txtIntitule.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(67, 161);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(307, 156);
            this.txtDescription.TabIndex = 1;
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LightGray;
            this.btValider.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValider.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.ForeColor = System.Drawing.Color.Black;
            this.btValider.Location = new System.Drawing.Point(135, 369);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(158, 40);
            this.btValider.TabIndex = 2;
            this.btValider.Text = "Enregistrer";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // btAjoutFormation
            // 
            this.btAjoutFormation.AutoSize = true;
            this.btAjoutFormation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAjoutFormation.ForeColor = System.Drawing.Color.White;
            this.btAjoutFormation.Location = new System.Drawing.Point(62, 51);
            this.btAjoutFormation.Name = "btAjoutFormation";
            this.btAjoutFormation.Size = new System.Drawing.Size(261, 25);
            this.btAjoutFormation.TabIndex = 3;
            this.btAjoutFormation.Text = "Ajout nouvelle formation";
            // 
            // FenetreAjouterFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(444, 463);
            this.Controls.Add(this.btAjoutFormation);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIntitule);
            this.DoubleBuffered = true;
            this.Name = "FenetreAjouterFormation";
            this.Text = "FenetreAjouterFormation";
            this.Load += new System.EventHandler(this.FenetreAjouterFormation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.Label btAjoutFormation;
    }
}