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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSession = new System.Windows.Forms.Button();
            this.btModule = new System.Windows.Forms.Button();
            this.btFormation = new System.Windows.Forms.Button();
            this.btStagiaire = new System.Windows.Forms.Button();
            this.panelView = new System.Windows.Forms.Panel();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btCreer = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.civiliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codePostalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.photoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formateurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelBienvenue = new System.Windows.Forms.Panel();
            this.lbBienvenue = new System.Windows.Forms.Label();
            this.btDeconnexion = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            this.panelBienvenue.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.btSession);
            this.panel1.Controls.Add(this.btModule);
            this.panel1.Controls.Add(this.btFormation);
            this.panel1.Controls.Add(this.btStagiaire);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(-2, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 433);
            this.panel1.TabIndex = 0;
            // 
            // btSession
            // 
            this.btSession.BackColor = System.Drawing.Color.DimGray;
            this.btSession.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btSession.FlatAppearance.BorderSize = 2;
            this.btSession.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSession.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSession.ForeColor = System.Drawing.Color.White;
            this.btSession.Location = new System.Drawing.Point(3, 331);
            this.btSession.Name = "btSession";
            this.btSession.Size = new System.Drawing.Size(168, 91);
            this.btSession.TabIndex = 3;
            this.btSession.Text = "Sessions";
            this.btSession.UseVisualStyleBackColor = false;
            // 
            // btModule
            // 
            this.btModule.BackColor = System.Drawing.Color.DimGray;
            this.btModule.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btModule.FlatAppearance.BorderSize = 2;
            this.btModule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModule.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModule.ForeColor = System.Drawing.Color.White;
            this.btModule.Location = new System.Drawing.Point(3, 220);
            this.btModule.Name = "btModule";
            this.btModule.Size = new System.Drawing.Size(168, 91);
            this.btModule.TabIndex = 2;
            this.btModule.Text = "Modules";
            this.btModule.UseVisualStyleBackColor = false;
            // 
            // btFormation
            // 
            this.btFormation.BackColor = System.Drawing.Color.DimGray;
            this.btFormation.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btFormation.FlatAppearance.BorderSize = 2;
            this.btFormation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btFormation.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFormation.ForeColor = System.Drawing.Color.White;
            this.btFormation.Location = new System.Drawing.Point(3, 110);
            this.btFormation.Name = "btFormation";
            this.btFormation.Size = new System.Drawing.Size(168, 91);
            this.btFormation.TabIndex = 1;
            this.btFormation.Text = "Formations";
            this.btFormation.UseVisualStyleBackColor = false;
            // 
            // btStagiaire
            // 
            this.btStagiaire.BackColor = System.Drawing.Color.DimGray;
            this.btStagiaire.FlatAppearance.BorderColor = System.Drawing.Color.Orange;
            this.btStagiaire.FlatAppearance.BorderSize = 2;
            this.btStagiaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btStagiaire.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStagiaire.ForeColor = System.Drawing.Color.White;
            this.btStagiaire.Location = new System.Drawing.Point(3, 3);
            this.btStagiaire.Name = "btStagiaire";
            this.btStagiaire.Size = new System.Drawing.Size(168, 91);
            this.btStagiaire.TabIndex = 0;
            this.btStagiaire.Text = "Stagiaires";
            this.btStagiaire.UseVisualStyleBackColor = false;
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelView.Controls.Add(this.btSupprimer);
            this.panelView.Controls.Add(this.btModifier);
            this.panelView.Controls.Add(this.btCreer);
            this.panelView.Controls.Add(this.dataGridView1);
            this.panelView.ForeColor = System.Drawing.Color.Black;
            this.panelView.Location = new System.Drawing.Point(175, 138);
            this.panelView.Name = "panelView";
            this.panelView.Size = new System.Drawing.Size(607, 422);
            this.panelView.TabIndex = 1;
            // 
            // btSupprimer
            // 
            this.btSupprimer.BackColor = System.Drawing.Color.DimGray;
            this.btSupprimer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btSupprimer.FlatAppearance.BorderSize = 2;
            this.btSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSupprimer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSupprimer.ForeColor = System.Drawing.Color.White;
            this.btSupprimer.Location = new System.Drawing.Point(409, 385);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(195, 34);
            this.btSupprimer.TabIndex = 4;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.UseVisualStyleBackColor = false;
            // 
            // btModifier
            // 
            this.btModifier.BackColor = System.Drawing.Color.DimGray;
            this.btModifier.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btModifier.FlatAppearance.BorderSize = 2;
            this.btModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btModifier.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModifier.ForeColor = System.Drawing.Color.White;
            this.btModifier.Location = new System.Drawing.Point(210, 385);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(193, 34);
            this.btModifier.TabIndex = 3;
            this.btModifier.Text = "Modifier";
            this.btModifier.UseVisualStyleBackColor = false;
            // 
            // btCreer
            // 
            this.btCreer.BackColor = System.Drawing.Color.DimGray;
            this.btCreer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCreer.FlatAppearance.BorderSize = 2;
            this.btCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCreer.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreer.ForeColor = System.Drawing.Color.White;
            this.btCreer.Location = new System.Drawing.Point(3, 385);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(201, 34);
            this.btCreer.TabIndex = 2;
            this.btCreer.Text = "Creer";
            this.btCreer.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.civiliteDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn,
            this.codePostalDataGridViewTextBoxColumn,
            this.villeDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.telephoneDataGridViewTextBoxColumn,
            this.photoDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn,
            this.formateurDataGridViewTextBoxColumn,
            this.evaluationDataGridViewTextBoxColumn,
            this.equipeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(601, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            this.nomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            this.prenomDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // civiliteDataGridViewTextBoxColumn
            // 
            this.civiliteDataGridViewTextBoxColumn.DataPropertyName = "Civilite";
            this.civiliteDataGridViewTextBoxColumn.HeaderText = "Civilite";
            this.civiliteDataGridViewTextBoxColumn.Name = "civiliteDataGridViewTextBoxColumn";
            this.civiliteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresseDataGridViewTextBoxColumn
            // 
            this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
            this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
            this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
            this.adresseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codePostalDataGridViewTextBoxColumn
            // 
            this.codePostalDataGridViewTextBoxColumn.DataPropertyName = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.HeaderText = "CodePostal";
            this.codePostalDataGridViewTextBoxColumn.Name = "codePostalDataGridViewTextBoxColumn";
            this.codePostalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // villeDataGridViewTextBoxColumn
            // 
            this.villeDataGridViewTextBoxColumn.DataPropertyName = "Ville";
            this.villeDataGridViewTextBoxColumn.HeaderText = "Ville";
            this.villeDataGridViewTextBoxColumn.Name = "villeDataGridViewTextBoxColumn";
            this.villeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // telephoneDataGridViewTextBoxColumn
            // 
            this.telephoneDataGridViewTextBoxColumn.DataPropertyName = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneDataGridViewTextBoxColumn.Name = "telephoneDataGridViewTextBoxColumn";
            this.telephoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // photoDataGridViewTextBoxColumn
            // 
            this.photoDataGridViewTextBoxColumn.DataPropertyName = "Photo";
            this.photoDataGridViewTextBoxColumn.HeaderText = "Photo";
            this.photoDataGridViewTextBoxColumn.Name = "photoDataGridViewTextBoxColumn";
            this.photoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            this.sessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formateurDataGridViewTextBoxColumn
            // 
            this.formateurDataGridViewTextBoxColumn.DataPropertyName = "Formateur";
            this.formateurDataGridViewTextBoxColumn.HeaderText = "Formateur";
            this.formateurDataGridViewTextBoxColumn.Name = "formateurDataGridViewTextBoxColumn";
            this.formateurDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluationDataGridViewTextBoxColumn
            // 
            this.evaluationDataGridViewTextBoxColumn.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn.Name = "evaluationDataGridViewTextBoxColumn";
            this.evaluationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // equipeDataGridViewTextBoxColumn
            // 
            this.equipeDataGridViewTextBoxColumn.DataPropertyName = "Equipe";
            this.equipeDataGridViewTextBoxColumn.HeaderText = "Equipe";
            this.equipeDataGridViewTextBoxColumn.Name = "equipeDataGridViewTextBoxColumn";
            this.equipeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(FormaDai.Personne);
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.DimGray, System.Drawing.Color.DimGray);
            // 
            // panelBienvenue
            // 
            this.panelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBienvenue.Controls.Add(this.lbBienvenue);
            this.panelBienvenue.Controls.Add(this.btDeconnexion);
            this.panelBienvenue.Location = new System.Drawing.Point(1, 35);
            this.panelBienvenue.Name = "panelBienvenue";
            this.panelBienvenue.Size = new System.Drawing.Size(781, 100);
            this.panelBienvenue.TabIndex = 2;
            this.panelBienvenue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBienvenue_Paint);
            // 
            // lbBienvenue
            // 
            this.lbBienvenue.AutoSize = true;
            this.lbBienvenue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBienvenue.ForeColor = System.Drawing.Color.White;
            this.lbBienvenue.Location = new System.Drawing.Point(218, 41);
            this.lbBienvenue.Name = "lbBienvenue";
            this.lbBienvenue.Size = new System.Drawing.Size(137, 29);
            this.lbBienvenue.TabIndex = 2;
            this.lbBienvenue.Text = "Bienvenue";
            // 
            // btDeconnexion
            // 
            this.btDeconnexion.BackColor = System.Drawing.Color.DimGray;
            this.btDeconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btDeconnexion.FlatAppearance.BorderSize = 2;
            this.btDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btDeconnexion.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeconnexion.ForeColor = System.Drawing.Color.White;
            this.btDeconnexion.Location = new System.Drawing.Point(25, 24);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(123, 52);
            this.btDeconnexion.TabIndex = 1;
            this.btDeconnexion.Text = "Deconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = false;
            // 
            // FenetreAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBienvenue);
            this.Controls.Add(this.panelView);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "FenetreAccueil";
            this.Text = "FenetreAccueil";
            this.Load += new System.EventHandler(this.FenetreAccueil_Load);
            this.panel1.ResumeLayout(false);
            this.panelView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            this.panelBienvenue.ResumeLayout(false);
            this.panelBienvenue.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSession;
        private System.Windows.Forms.Button btModule;
        private System.Windows.Forms.Button btFormation;
        private System.Windows.Forms.Button btStagiaire;
        private System.Windows.Forms.Panel panelView;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn civiliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codePostalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn photoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formateurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource personneBindingSource;
        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.Panel panelBienvenue;
        private System.Windows.Forms.Label lbBienvenue;
        private System.Windows.Forms.Button btDeconnexion;
    }
}