namespace FormaDai
{
    partial class FenetreModifierFormation
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
            this.lbModifierFormation = new System.Windows.Forms.Label();
            this.btValider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtIntitule
            // 
            this.txtIntitule.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIntitule.Location = new System.Drawing.Point(103, 147);
            this.txtIntitule.Name = "txtIntitule";
            this.txtIntitule.Size = new System.Drawing.Size(187, 28);
            this.txtIntitule.TabIndex = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(103, 198);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(221, 72);
            this.txtDescription.TabIndex = 1;
            // 
            // lbModifierFormation
            // 
            this.lbModifierFormation.AutoSize = true;
            this.lbModifierFormation.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModifierFormation.ForeColor = System.Drawing.Color.White;
            this.lbModifierFormation.Location = new System.Drawing.Point(76, 55);
            this.lbModifierFormation.Name = "lbModifierFormation";
            this.lbModifierFormation.Size = new System.Drawing.Size(248, 25);
            this.lbModifierFormation.TabIndex = 2;
            this.lbModifierFormation.Text = "Modifier la formation";
            // 
            // btValider
            // 
            this.btValider.BackColor = System.Drawing.Color.LightGray;
            this.btValider.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btValider.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btValider.ForeColor = System.Drawing.Color.Black;
            this.btValider.Location = new System.Drawing.Point(103, 311);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(158, 40);
            this.btValider.TabIndex = 3;
            this.btValider.Text = "Enregistrer";
            this.btValider.UseVisualStyleBackColor = false;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // FenetreModifierFormation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(409, 407);
            this.Controls.Add(this.btValider);
            this.Controls.Add(this.lbModifierFormation);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtIntitule);
            this.DoubleBuffered = true;
            this.Name = "FenetreModifierFormation";
            this.Text = "FenetreModifierFormation";
            this.Load += new System.EventHandler(this.FenetreModifierFormation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIntitule;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lbModifierFormation;
        private System.Windows.Forms.Button btValider;
    }
}