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
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Intitule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFormationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moduleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formationBindingSource = new System.Windows.Forms.BindingSource(this.components);
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
            this.idModuleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intituleDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nbJourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluationDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.formateurDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panelView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).BeginInit();
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
            this.btModule.Click += new System.EventHandler(this.btModule_Click);
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
            this.btFormation.Click += new System.EventHandler(this.btFormation_Click);
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
            this.btStagiaire.Click += new System.EventHandler(this.btStagiaire_Click);
            // 
            // panelView
            // 
            this.panelView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelView.Controls.Add(this.dataGridView3);
            this.panelView.Controls.Add(this.dataGridView2);
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
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.idModuleDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn1,
            this.descriptionDataGridViewTextBoxColumn1,
            this.nbJourDataGridViewTextBoxColumn,
            this.formationDataGridViewTextBoxColumn,
            this.seanceDataGridViewTextBoxColumn,
            this.evaluationDataGridViewTextBoxColumn1,
            this.formateurDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.moduleBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(601, 379);
            this.dataGridView3.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Intitule";
            this.dataGridViewTextBoxColumn1.HeaderText = "Intitule";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn2.HeaderText = "Description";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // moduleBindingSource
            // 
            this.moduleBindingSource.DataSource = typeof(FormaDai.Module);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Intitule,
            this.Description,
            this.idFormationDataGridViewTextBoxColumn,
            this.intituleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.moduleDataGridViewTextBoxColumn,
            this.sessionDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.formationBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(6, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(601, 379);
            this.dataGridView2.TabIndex = 5;
            // 
            // Intitule
            // 
            this.Intitule.DataPropertyName = "Intitule";
            this.Intitule.HeaderText = "Intitule";
            this.Intitule.Name = "Intitule";
            this.Intitule.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.DataPropertyName = "Description";
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // idFormationDataGridViewTextBoxColumn
            // 
            this.idFormationDataGridViewTextBoxColumn.DataPropertyName = "IdFormation";
            this.idFormationDataGridViewTextBoxColumn.HeaderText = "IdFormation";
            this.idFormationDataGridViewTextBoxColumn.Name = "idFormationDataGridViewTextBoxColumn";
            this.idFormationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intituleDataGridViewTextBoxColumn
            // 
            this.intituleDataGridViewTextBoxColumn.DataPropertyName = "Intitule";
            this.intituleDataGridViewTextBoxColumn.HeaderText = "Intitule";
            this.intituleDataGridViewTextBoxColumn.Name = "intituleDataGridViewTextBoxColumn";
            this.intituleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moduleDataGridViewTextBoxColumn
            // 
            this.moduleDataGridViewTextBoxColumn.DataPropertyName = "Module";
            this.moduleDataGridViewTextBoxColumn.HeaderText = "Module";
            this.moduleDataGridViewTextBoxColumn.Name = "moduleDataGridViewTextBoxColumn";
            this.moduleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessionDataGridViewTextBoxColumn1
            // 
            this.sessionDataGridViewTextBoxColumn1.DataPropertyName = "Session";
            this.sessionDataGridViewTextBoxColumn1.HeaderText = "Session";
            this.sessionDataGridViewTextBoxColumn1.Name = "sessionDataGridViewTextBoxColumn1";
            this.sessionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // formationBindingSource
            // 
            this.formationBindingSource.DataSource = typeof(FormaDai.Formation);
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
            //this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Metro;
            //this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.DimGray, System.Drawing.Color.DimGray);
            // 
            // panelBienvenue
            // 
            this.panelBienvenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panelBienvenue.Controls.Add(this.lbBienvenue);
            this.panelBienvenue.Controls.Add(this.btDeconnexion);
            this.panelBienvenue.ForeColor = System.Drawing.Color.Black;
            this.panelBienvenue.Location = new System.Drawing.Point(1, 35);
            this.panelBienvenue.Name = "panelBienvenue";
            this.panelBienvenue.Size = new System.Drawing.Size(781, 100);
            this.panelBienvenue.TabIndex = 2;
            this.panelBienvenue.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBienvenue_Paint);
            // 
            // lbBienvenue
            // 
            this.lbBienvenue.AutoSize = true;
            this.lbBienvenue.BackColor = System.Drawing.Color.Transparent;
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
            this.btDeconnexion.ForeColor = System.Drawing.Color.Black;
            this.btDeconnexion.Location = new System.Drawing.Point(25, 24);
            this.btDeconnexion.Name = "btDeconnexion";
            this.btDeconnexion.Size = new System.Drawing.Size(123, 52);
            this.btDeconnexion.TabIndex = 1;
            this.btDeconnexion.Text = "Deconnexion";
            this.btDeconnexion.UseVisualStyleBackColor = false;
            // 
            // idModuleDataGridViewTextBoxColumn
            // 
            this.idModuleDataGridViewTextBoxColumn.DataPropertyName = "IdModule";
            this.idModuleDataGridViewTextBoxColumn.HeaderText = "IdModule";
            this.idModuleDataGridViewTextBoxColumn.Name = "idModuleDataGridViewTextBoxColumn";
            this.idModuleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // intituleDataGridViewTextBoxColumn1
            // 
            this.intituleDataGridViewTextBoxColumn1.DataPropertyName = "Intitule";
            this.intituleDataGridViewTextBoxColumn1.HeaderText = "Intitule";
            this.intituleDataGridViewTextBoxColumn1.Name = "intituleDataGridViewTextBoxColumn1";
            this.intituleDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            this.descriptionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nbJourDataGridViewTextBoxColumn
            // 
            this.nbJourDataGridViewTextBoxColumn.DataPropertyName = "NbJour";
            this.nbJourDataGridViewTextBoxColumn.HeaderText = "NbJour";
            this.nbJourDataGridViewTextBoxColumn.Name = "nbJourDataGridViewTextBoxColumn";
            this.nbJourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // formationDataGridViewTextBoxColumn
            // 
            this.formationDataGridViewTextBoxColumn.DataPropertyName = "Formation";
            this.formationDataGridViewTextBoxColumn.HeaderText = "Formation";
            this.formationDataGridViewTextBoxColumn.Name = "formationDataGridViewTextBoxColumn";
            this.formationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // seanceDataGridViewTextBoxColumn
            // 
            this.seanceDataGridViewTextBoxColumn.DataPropertyName = "Seance";
            this.seanceDataGridViewTextBoxColumn.HeaderText = "Seance";
            this.seanceDataGridViewTextBoxColumn.Name = "seanceDataGridViewTextBoxColumn";
            this.seanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // evaluationDataGridViewTextBoxColumn1
            // 
            this.evaluationDataGridViewTextBoxColumn1.DataPropertyName = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn1.HeaderText = "Evaluation";
            this.evaluationDataGridViewTextBoxColumn1.Name = "evaluationDataGridViewTextBoxColumn1";
            this.evaluationDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // formateurDataGridViewTextBoxColumn1
            // 
            this.formateurDataGridViewTextBoxColumn1.DataPropertyName = "Formateur";
            this.formateurDataGridViewTextBoxColumn1.HeaderText = "Formateur";
            this.formateurDataGridViewTextBoxColumn1.Name = "formateurDataGridViewTextBoxColumn1";
            this.formateurDataGridViewTextBoxColumn1.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.formationBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Intitule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.BindingSource formationBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource moduleBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFormationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idModuleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intituleDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nbJourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn formationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluationDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn formateurDataGridViewTextBoxColumn1;
    }
}