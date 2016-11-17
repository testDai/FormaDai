
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/16/2016 15:32:56
-- Generated from EDMX file: C:\Users\erjk\Documents\Visual Studio 2015\Projects\FormaDai\FormaDai\BdForma.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FormatDaiBd];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ModuleFormation_Module]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModuleFormation] DROP CONSTRAINT [FK_ModuleFormation_Module];
GO
IF OBJECT_ID(N'[dbo].[FK_ModuleFormation_Formation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ModuleFormation] DROP CONSTRAINT [FK_ModuleFormation_Formation];
GO
IF OBJECT_ID(N'[dbo].[FK_FormationSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Session] DROP CONSTRAINT [FK_FormationSession];
GO
IF OBJECT_ID(N'[dbo].[FK_ModuleSeance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Seance] DROP CONSTRAINT [FK_ModuleSeance];
GO
IF OBJECT_ID(N'[dbo].[FK_SessionSeance]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Seance] DROP CONSTRAINT [FK_SessionSeance];
GO
IF OBJECT_ID(N'[dbo].[FK_Candidature_Personne]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Candidature] DROP CONSTRAINT [FK_Candidature_Personne];
GO
IF OBJECT_ID(N'[dbo].[FK_Candidature_Session]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Candidature] DROP CONSTRAINT [FK_Candidature_Session];
GO
IF OBJECT_ID(N'[dbo].[FK_PersonneFormateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Formateur] DROP CONSTRAINT [FK_PersonneFormateur];
GO
IF OBJECT_ID(N'[dbo].[FK_EvaluationSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_EvaluationSession];
GO
IF OBJECT_ID(N'[dbo].[FK_EvaluationModule]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_EvaluationModule];
GO
IF OBJECT_ID(N'[dbo].[FK_EvaluationFormateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Evaluation] DROP CONSTRAINT [FK_EvaluationFormateur];
GO
IF OBJECT_ID(N'[dbo].[FK_Note_Evaluation]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Note] DROP CONSTRAINT [FK_Note_Evaluation];
GO
IF OBJECT_ID(N'[dbo].[FK_Note_Personne]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Note] DROP CONSTRAINT [FK_Note_Personne];
GO
IF OBJECT_ID(N'[dbo].[FK_Intervenant_Formateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Intervenant] DROP CONSTRAINT [FK_Intervenant_Formateur];
GO
IF OBJECT_ID(N'[dbo].[FK_Intervenant_Module]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Intervenant] DROP CONSTRAINT [FK_Intervenant_Module];
GO
IF OBJECT_ID(N'[dbo].[FK_SeanceFormateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Seance] DROP CONSTRAINT [FK_SeanceFormateur];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetFormateur]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projet] DROP CONSTRAINT [FK_ProjetFormateur];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjetSession]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Projet] DROP CONSTRAINT [FK_ProjetSession];
GO
IF OBJECT_ID(N'[dbo].[FK_EquipeProjet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Equipe] DROP CONSTRAINT [FK_EquipeProjet];
GO
IF OBJECT_ID(N'[dbo].[FK_Membre_Equipe]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Membre] DROP CONSTRAINT [FK_Membre_Equipe];
GO
IF OBJECT_ID(N'[dbo].[FK_Membre_Personne]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Membre] DROP CONSTRAINT [FK_Membre_Personne];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Personne]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Personne];
GO
IF OBJECT_ID(N'[dbo].[Module]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Module];
GO
IF OBJECT_ID(N'[dbo].[Formation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formation];
GO
IF OBJECT_ID(N'[dbo].[Session]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Session];
GO
IF OBJECT_ID(N'[dbo].[Seance]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Seance];
GO
IF OBJECT_ID(N'[dbo].[Formateur]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Formateur];
GO
IF OBJECT_ID(N'[dbo].[Evaluation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Evaluation];
GO
IF OBJECT_ID(N'[dbo].[Projet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projet];
GO
IF OBJECT_ID(N'[dbo].[Equipe]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Equipe];
GO
IF OBJECT_ID(N'[dbo].[ModuleFormation]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ModuleFormation];
GO
IF OBJECT_ID(N'[dbo].[Candidature]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Candidature];
GO
IF OBJECT_ID(N'[dbo].[Note]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Note];
GO
IF OBJECT_ID(N'[dbo].[Intervenant]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Intervenant];
GO
IF OBJECT_ID(N'[dbo].[Membre]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Membre];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Personne'
CREATE TABLE [dbo].[Personne] (
    [IdPersonne] int IDENTITY(1,1) NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Prenom] nvarchar(max)  NOT NULL,
    [Mail] nvarchar(max)  NOT NULL,
    [Civilite] nvarchar(max)  NOT NULL,
    [Adresse] nvarchar(max)  NOT NULL,
    [CodePostal] nvarchar(max)  NOT NULL,
    [Ville] nvarchar(max)  NOT NULL,
    [Password] nvarchar(max)  NOT NULL,
    [Telephone] nvarchar(max)  NOT NULL,
    [Photo] nvarchar(max)  NULL,
    [EstAdmin] bit  NOT NULL
);
GO

-- Creating table 'Module'
CREATE TABLE [dbo].[Module] (
    [IdModule] int IDENTITY(1,1) NOT NULL,
    [Intitule] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [NbJour] int  NULL
);
GO

-- Creating table 'Formation'
CREATE TABLE [dbo].[Formation] (
    [IdFormation] int IDENTITY(1,1) NOT NULL,
    [Intitule] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Session'
CREATE TABLE [dbo].[Session] (
    [IdSession] int IDENTITY(1,1) NOT NULL,
    [IdFormation] int  NOT NULL,
    [DateDebut] datetime  NOT NULL,
    [DateFin] datetime  NOT NULL,
    [DateDebutInscription] datetime  NOT NULL
);
GO

-- Creating table 'Seance'
CREATE TABLE [dbo].[Seance] (
    [IdSeance] int IDENTITY(1,1) NOT NULL,
    [IdModule] int  NOT NULL,
    [IdSession] int  NOT NULL,
    [IdFormateur] int  NOT NULL,
    [Jour] datetime  NOT NULL,
    [Contenu] nvarchar(max)  NULL
);
GO

-- Creating table 'Formateur'
CREATE TABLE [dbo].[Formateur] (
    [IdFormateur] int IDENTITY(1,1) NOT NULL,
    [SiteWeb] nvarchar(max)  NULL,
    [Personne_IdPersonne] int  NOT NULL
);
GO

-- Creating table 'Evaluation'
CREATE TABLE [dbo].[Evaluation] (
    [IdEvaluation] int IDENTITY(1,1) NOT NULL,
    [IdSession] int  NOT NULL,
    [IdModule] int  NOT NULL,
    [IdFormateur] int  NOT NULL,
    [DateEffet] datetime  NOT NULL,
    [Commentaire] nvarchar(max)  NULL
);
GO

-- Creating table 'Projet'
CREATE TABLE [dbo].[Projet] (
    [IdProjet] int IDENTITY(1,1) NOT NULL,
    [IdFormateur] int  NOT NULL,
    [IdSession] int  NOT NULL,
    [Nom] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DateCreation] datetime  NOT NULL,
    [DateFin] datetime  NOT NULL
);
GO

-- Creating table 'Equipe'
CREATE TABLE [dbo].[Equipe] (
    [IdEquipe] int IDENTITY(1,1) NOT NULL,
    [IdProjet] int  NOT NULL,
    [Nom] nvarchar(max)  NULL,
    [Logo] nvarchar(max)  NULL,
    [DateCreation] datetime  NOT NULL,
    [EstCreateur] int  NOT NULL
);
GO

-- Creating table 'ModuleFormation'
CREATE TABLE [dbo].[ModuleFormation] (
    [Module_IdModule] int  NOT NULL,
    [Formation_IdFormation] int  NOT NULL
);
GO

-- Creating table 'Candidature'
CREATE TABLE [dbo].[Candidature] (
    [Personne_IdPersonne] int  NOT NULL,
    [Session_IdSession] int  NOT NULL
);
GO

-- Creating table 'Note'
CREATE TABLE [dbo].[Note] (
    [Evaluation_IdEvaluation] int  NOT NULL,
    [Personne_IdPersonne] int  NOT NULL
);
GO

-- Creating table 'Intervenant'
CREATE TABLE [dbo].[Intervenant] (
    [Formateur_IdFormateur] int  NOT NULL,
    [Module_IdModule] int  NOT NULL
);
GO

-- Creating table 'Membre'
CREATE TABLE [dbo].[Membre] (
    [Equipe_IdEquipe] int  NOT NULL,
    [Personne_IdPersonne] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdPersonne] in table 'Personne'
ALTER TABLE [dbo].[Personne]
ADD CONSTRAINT [PK_Personne]
    PRIMARY KEY CLUSTERED ([IdPersonne] ASC);
GO

-- Creating primary key on [IdModule] in table 'Module'
ALTER TABLE [dbo].[Module]
ADD CONSTRAINT [PK_Module]
    PRIMARY KEY CLUSTERED ([IdModule] ASC);
GO

-- Creating primary key on [IdFormation] in table 'Formation'
ALTER TABLE [dbo].[Formation]
ADD CONSTRAINT [PK_Formation]
    PRIMARY KEY CLUSTERED ([IdFormation] ASC);
GO

-- Creating primary key on [IdSession] in table 'Session'
ALTER TABLE [dbo].[Session]
ADD CONSTRAINT [PK_Session]
    PRIMARY KEY CLUSTERED ([IdSession] ASC);
GO

-- Creating primary key on [IdSeance] in table 'Seance'
ALTER TABLE [dbo].[Seance]
ADD CONSTRAINT [PK_Seance]
    PRIMARY KEY CLUSTERED ([IdSeance] ASC);
GO

-- Creating primary key on [IdFormateur] in table 'Formateur'
ALTER TABLE [dbo].[Formateur]
ADD CONSTRAINT [PK_Formateur]
    PRIMARY KEY CLUSTERED ([IdFormateur] ASC);
GO

-- Creating primary key on [IdEvaluation] in table 'Evaluation'
ALTER TABLE [dbo].[Evaluation]
ADD CONSTRAINT [PK_Evaluation]
    PRIMARY KEY CLUSTERED ([IdEvaluation] ASC);
GO

-- Creating primary key on [IdProjet] in table 'Projet'
ALTER TABLE [dbo].[Projet]
ADD CONSTRAINT [PK_Projet]
    PRIMARY KEY CLUSTERED ([IdProjet] ASC);
GO

-- Creating primary key on [IdEquipe] in table 'Equipe'
ALTER TABLE [dbo].[Equipe]
ADD CONSTRAINT [PK_Equipe]
    PRIMARY KEY CLUSTERED ([IdEquipe] ASC);
GO

-- Creating primary key on [Module_IdModule], [Formation_IdFormation] in table 'ModuleFormation'
ALTER TABLE [dbo].[ModuleFormation]
ADD CONSTRAINT [PK_ModuleFormation]
    PRIMARY KEY CLUSTERED ([Module_IdModule], [Formation_IdFormation] ASC);
GO

-- Creating primary key on [Personne_IdPersonne], [Session_IdSession] in table 'Candidature'
ALTER TABLE [dbo].[Candidature]
ADD CONSTRAINT [PK_Candidature]
    PRIMARY KEY CLUSTERED ([Personne_IdPersonne], [Session_IdSession] ASC);
GO

-- Creating primary key on [Evaluation_IdEvaluation], [Personne_IdPersonne] in table 'Note'
ALTER TABLE [dbo].[Note]
ADD CONSTRAINT [PK_Note]
    PRIMARY KEY CLUSTERED ([Evaluation_IdEvaluation], [Personne_IdPersonne] ASC);
GO

-- Creating primary key on [Formateur_IdFormateur], [Module_IdModule] in table 'Intervenant'
ALTER TABLE [dbo].[Intervenant]
ADD CONSTRAINT [PK_Intervenant]
    PRIMARY KEY CLUSTERED ([Formateur_IdFormateur], [Module_IdModule] ASC);
GO

-- Creating primary key on [Equipe_IdEquipe], [Personne_IdPersonne] in table 'Membre'
ALTER TABLE [dbo].[Membre]
ADD CONSTRAINT [PK_Membre]
    PRIMARY KEY CLUSTERED ([Equipe_IdEquipe], [Personne_IdPersonne] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Module_IdModule] in table 'ModuleFormation'
ALTER TABLE [dbo].[ModuleFormation]
ADD CONSTRAINT [FK_ModuleFormation_Module]
    FOREIGN KEY ([Module_IdModule])
    REFERENCES [dbo].[Module]
        ([IdModule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Formation_IdFormation] in table 'ModuleFormation'
ALTER TABLE [dbo].[ModuleFormation]
ADD CONSTRAINT [FK_ModuleFormation_Formation]
    FOREIGN KEY ([Formation_IdFormation])
    REFERENCES [dbo].[Formation]
        ([IdFormation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModuleFormation_Formation'
CREATE INDEX [IX_FK_ModuleFormation_Formation]
ON [dbo].[ModuleFormation]
    ([Formation_IdFormation]);
GO

-- Creating foreign key on [IdFormation] in table 'Session'
ALTER TABLE [dbo].[Session]
ADD CONSTRAINT [FK_FormationSession]
    FOREIGN KEY ([IdFormation])
    REFERENCES [dbo].[Formation]
        ([IdFormation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FormationSession'
CREATE INDEX [IX_FK_FormationSession]
ON [dbo].[Session]
    ([IdFormation]);
GO

-- Creating foreign key on [IdModule] in table 'Seance'
ALTER TABLE [dbo].[Seance]
ADD CONSTRAINT [FK_ModuleSeance]
    FOREIGN KEY ([IdModule])
    REFERENCES [dbo].[Module]
        ([IdModule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ModuleSeance'
CREATE INDEX [IX_FK_ModuleSeance]
ON [dbo].[Seance]
    ([IdModule]);
GO

-- Creating foreign key on [IdSession] in table 'Seance'
ALTER TABLE [dbo].[Seance]
ADD CONSTRAINT [FK_SessionSeance]
    FOREIGN KEY ([IdSession])
    REFERENCES [dbo].[Session]
        ([IdSession])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SessionSeance'
CREATE INDEX [IX_FK_SessionSeance]
ON [dbo].[Seance]
    ([IdSession]);
GO

-- Creating foreign key on [Personne_IdPersonne] in table 'Candidature'
ALTER TABLE [dbo].[Candidature]
ADD CONSTRAINT [FK_Candidature_Personne]
    FOREIGN KEY ([Personne_IdPersonne])
    REFERENCES [dbo].[Personne]
        ([IdPersonne])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Session_IdSession] in table 'Candidature'
ALTER TABLE [dbo].[Candidature]
ADD CONSTRAINT [FK_Candidature_Session]
    FOREIGN KEY ([Session_IdSession])
    REFERENCES [dbo].[Session]
        ([IdSession])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Candidature_Session'
CREATE INDEX [IX_FK_Candidature_Session]
ON [dbo].[Candidature]
    ([Session_IdSession]);
GO

-- Creating foreign key on [Personne_IdPersonne] in table 'Formateur'
ALTER TABLE [dbo].[Formateur]
ADD CONSTRAINT [FK_PersonneFormateur]
    FOREIGN KEY ([Personne_IdPersonne])
    REFERENCES [dbo].[Personne]
        ([IdPersonne])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PersonneFormateur'
CREATE INDEX [IX_FK_PersonneFormateur]
ON [dbo].[Formateur]
    ([Personne_IdPersonne]);
GO

-- Creating foreign key on [IdSession] in table 'Evaluation'
ALTER TABLE [dbo].[Evaluation]
ADD CONSTRAINT [FK_EvaluationSession]
    FOREIGN KEY ([IdSession])
    REFERENCES [dbo].[Session]
        ([IdSession])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvaluationSession'
CREATE INDEX [IX_FK_EvaluationSession]
ON [dbo].[Evaluation]
    ([IdSession]);
GO

-- Creating foreign key on [IdModule] in table 'Evaluation'
ALTER TABLE [dbo].[Evaluation]
ADD CONSTRAINT [FK_EvaluationModule]
    FOREIGN KEY ([IdModule])
    REFERENCES [dbo].[Module]
        ([IdModule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvaluationModule'
CREATE INDEX [IX_FK_EvaluationModule]
ON [dbo].[Evaluation]
    ([IdModule]);
GO

-- Creating foreign key on [IdFormateur] in table 'Evaluation'
ALTER TABLE [dbo].[Evaluation]
ADD CONSTRAINT [FK_EvaluationFormateur]
    FOREIGN KEY ([IdFormateur])
    REFERENCES [dbo].[Formateur]
        ([IdFormateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EvaluationFormateur'
CREATE INDEX [IX_FK_EvaluationFormateur]
ON [dbo].[Evaluation]
    ([IdFormateur]);
GO

-- Creating foreign key on [Evaluation_IdEvaluation] in table 'Note'
ALTER TABLE [dbo].[Note]
ADD CONSTRAINT [FK_Note_Evaluation]
    FOREIGN KEY ([Evaluation_IdEvaluation])
    REFERENCES [dbo].[Evaluation]
        ([IdEvaluation])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Personne_IdPersonne] in table 'Note'
ALTER TABLE [dbo].[Note]
ADD CONSTRAINT [FK_Note_Personne]
    FOREIGN KEY ([Personne_IdPersonne])
    REFERENCES [dbo].[Personne]
        ([IdPersonne])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Note_Personne'
CREATE INDEX [IX_FK_Note_Personne]
ON [dbo].[Note]
    ([Personne_IdPersonne]);
GO

-- Creating foreign key on [Formateur_IdFormateur] in table 'Intervenant'
ALTER TABLE [dbo].[Intervenant]
ADD CONSTRAINT [FK_Intervenant_Formateur]
    FOREIGN KEY ([Formateur_IdFormateur])
    REFERENCES [dbo].[Formateur]
        ([IdFormateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Module_IdModule] in table 'Intervenant'
ALTER TABLE [dbo].[Intervenant]
ADD CONSTRAINT [FK_Intervenant_Module]
    FOREIGN KEY ([Module_IdModule])
    REFERENCES [dbo].[Module]
        ([IdModule])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Intervenant_Module'
CREATE INDEX [IX_FK_Intervenant_Module]
ON [dbo].[Intervenant]
    ([Module_IdModule]);
GO

-- Creating foreign key on [IdFormateur] in table 'Seance'
ALTER TABLE [dbo].[Seance]
ADD CONSTRAINT [FK_SeanceFormateur]
    FOREIGN KEY ([IdFormateur])
    REFERENCES [dbo].[Formateur]
        ([IdFormateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SeanceFormateur'
CREATE INDEX [IX_FK_SeanceFormateur]
ON [dbo].[Seance]
    ([IdFormateur]);
GO

-- Creating foreign key on [IdFormateur] in table 'Projet'
ALTER TABLE [dbo].[Projet]
ADD CONSTRAINT [FK_ProjetFormateur]
    FOREIGN KEY ([IdFormateur])
    REFERENCES [dbo].[Formateur]
        ([IdFormateur])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetFormateur'
CREATE INDEX [IX_FK_ProjetFormateur]
ON [dbo].[Projet]
    ([IdFormateur]);
GO

-- Creating foreign key on [IdSession] in table 'Projet'
ALTER TABLE [dbo].[Projet]
ADD CONSTRAINT [FK_ProjetSession]
    FOREIGN KEY ([IdSession])
    REFERENCES [dbo].[Session]
        ([IdSession])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjetSession'
CREATE INDEX [IX_FK_ProjetSession]
ON [dbo].[Projet]
    ([IdSession]);
GO

-- Creating foreign key on [IdProjet] in table 'Equipe'
ALTER TABLE [dbo].[Equipe]
ADD CONSTRAINT [FK_EquipeProjet]
    FOREIGN KEY ([IdProjet])
    REFERENCES [dbo].[Projet]
        ([IdProjet])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EquipeProjet'
CREATE INDEX [IX_FK_EquipeProjet]
ON [dbo].[Equipe]
    ([IdProjet]);
GO

-- Creating foreign key on [Equipe_IdEquipe] in table 'Membre'
ALTER TABLE [dbo].[Membre]
ADD CONSTRAINT [FK_Membre_Equipe]
    FOREIGN KEY ([Equipe_IdEquipe])
    REFERENCES [dbo].[Equipe]
        ([IdEquipe])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Personne_IdPersonne] in table 'Membre'
ALTER TABLE [dbo].[Membre]
ADD CONSTRAINT [FK_Membre_Personne]
    FOREIGN KEY ([Personne_IdPersonne])
    REFERENCES [dbo].[Personne]
        ([IdPersonne])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Membre_Personne'
CREATE INDEX [IX_FK_Membre_Personne]
ON [dbo].[Membre]
    ([Personne_IdPersonne]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------