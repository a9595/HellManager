
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2015 23:22:25
-- Generated from EDMX file: C:\Users\Andrii\Documents\GitHub\HellManager\HellManager\EntityFrameworkDAL\EFModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [HellDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_SinnerSin_Sinner]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SinnerSin] DROP CONSTRAINT [FK_SinnerSin_Sinner];
GO
IF OBJECT_ID(N'[dbo].[FK_SinnerSin_Sin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SinnerSin] DROP CONSTRAINT [FK_SinnerSin_Sin];
GO
IF OBJECT_ID(N'[dbo].[FK_SinPunishment]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sins] DROP CONSTRAINT [FK_SinPunishment];
GO
IF OBJECT_ID(N'[dbo].[FK_SinPunisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sins] DROP CONSTRAINT [FK_SinPunisher];
GO
IF OBJECT_ID(N'[dbo].[FK_SinDegreeSin]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sins] DROP CONSTRAINT [FK_SinDegreeSin];
GO
IF OBJECT_ID(N'[dbo].[FK_PunisherRankPunisher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Punishers] DROP CONSTRAINT [FK_PunisherRankPunisher];
GO
IF OBJECT_ID(N'[dbo].[FK_SinnerGender]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Sinners] DROP CONSTRAINT [FK_SinnerGender];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Sinners]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sinners];
GO
IF OBJECT_ID(N'[dbo].[Sins]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Sins];
GO
IF OBJECT_ID(N'[dbo].[Punishments]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Punishments];
GO
IF OBJECT_ID(N'[dbo].[Punishers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Punishers];
GO
IF OBJECT_ID(N'[dbo].[PunisherRanks]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PunisherRanks];
GO
IF OBJECT_ID(N'[dbo].[SinDegrees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SinDegrees];
GO
IF OBJECT_ID(N'[dbo].[Genders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Genders];
GO
IF OBJECT_ID(N'[dbo].[SinnerSin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SinnerSin];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Sinners'
CREATE TABLE [dbo].[Sinners] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FullName] nvarchar(32)  NOT NULL,
    [Age] int  NULL,
    [JobTitle] nvarchar(50)  NULL,
    [Salary] int  NULL,
    [GenderId] int  NULL
);
GO

-- Creating table 'Sins'
CREATE TABLE [dbo].[Sins] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(500)  NOT NULL,
    [PunishmentId] int  NOT NULL,
    [PunisherId] int  NOT NULL,
    [SinDegreeId] int  NULL
);
GO

-- Creating table 'Punishments'
CREATE TABLE [dbo].[Punishments] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(256)  NOT NULL,
    [TreatCycle] int  NOT NULL
);
GO

-- Creating table 'Punishers'
CREATE TABLE [dbo].[Punishers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(32)  NOT NULL,
    [Phone] nvarchar(32)  NULL,
    [PunisherRankId] int  NULL
);
GO

-- Creating table 'PunisherRanks'
CREATE TABLE [dbo].[PunisherRanks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(32)  NOT NULL
);
GO

-- Creating table 'SinDegrees'
CREATE TABLE [dbo].[SinDegrees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(32)  NOT NULL,
    [Value] int  NOT NULL
);
GO

-- Creating table 'Genders'
CREATE TABLE [dbo].[Genders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(10)  NOT NULL
);
GO

-- Creating table 'SinnerSin'
CREATE TABLE [dbo].[SinnerSin] (
    [Sinners_Id] int  NOT NULL,
    [Sins_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Sinners'
ALTER TABLE [dbo].[Sinners]
ADD CONSTRAINT [PK_Sinners]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Sins'
ALTER TABLE [dbo].[Sins]
ADD CONSTRAINT [PK_Sins]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Punishments'
ALTER TABLE [dbo].[Punishments]
ADD CONSTRAINT [PK_Punishments]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Punishers'
ALTER TABLE [dbo].[Punishers]
ADD CONSTRAINT [PK_Punishers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PunisherRanks'
ALTER TABLE [dbo].[PunisherRanks]
ADD CONSTRAINT [PK_PunisherRanks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SinDegrees'
ALTER TABLE [dbo].[SinDegrees]
ADD CONSTRAINT [PK_SinDegrees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Genders'
ALTER TABLE [dbo].[Genders]
ADD CONSTRAINT [PK_Genders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Sinners_Id], [Sins_Id] in table 'SinnerSin'
ALTER TABLE [dbo].[SinnerSin]
ADD CONSTRAINT [PK_SinnerSin]
    PRIMARY KEY CLUSTERED ([Sinners_Id], [Sins_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Sinners_Id] in table 'SinnerSin'
ALTER TABLE [dbo].[SinnerSin]
ADD CONSTRAINT [FK_SinnerSin_Sinner]
    FOREIGN KEY ([Sinners_Id])
    REFERENCES [dbo].[Sinners]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Sins_Id] in table 'SinnerSin'
ALTER TABLE [dbo].[SinnerSin]
ADD CONSTRAINT [FK_SinnerSin_Sin]
    FOREIGN KEY ([Sins_Id])
    REFERENCES [dbo].[Sins]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SinnerSin_Sin'
CREATE INDEX [IX_FK_SinnerSin_Sin]
ON [dbo].[SinnerSin]
    ([Sins_Id]);
GO

-- Creating foreign key on [PunishmentId] in table 'Sins'
ALTER TABLE [dbo].[Sins]
ADD CONSTRAINT [FK_SinPunishment]
    FOREIGN KEY ([PunishmentId])
    REFERENCES [dbo].[Punishments]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SinPunishment'
CREATE INDEX [IX_FK_SinPunishment]
ON [dbo].[Sins]
    ([PunishmentId]);
GO

-- Creating foreign key on [PunisherId] in table 'Sins'
ALTER TABLE [dbo].[Sins]
ADD CONSTRAINT [FK_SinPunisher]
    FOREIGN KEY ([PunisherId])
    REFERENCES [dbo].[Punishers]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SinPunisher'
CREATE INDEX [IX_FK_SinPunisher]
ON [dbo].[Sins]
    ([PunisherId]);
GO

-- Creating foreign key on [SinDegreeId] in table 'Sins'
ALTER TABLE [dbo].[Sins]
ADD CONSTRAINT [FK_SinDegreeSin]
    FOREIGN KEY ([SinDegreeId])
    REFERENCES [dbo].[SinDegrees]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SinDegreeSin'
CREATE INDEX [IX_FK_SinDegreeSin]
ON [dbo].[Sins]
    ([SinDegreeId]);
GO

-- Creating foreign key on [PunisherRankId] in table 'Punishers'
ALTER TABLE [dbo].[Punishers]
ADD CONSTRAINT [FK_PunisherRankPunisher]
    FOREIGN KEY ([PunisherRankId])
    REFERENCES [dbo].[PunisherRanks]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PunisherRankPunisher'
CREATE INDEX [IX_FK_PunisherRankPunisher]
ON [dbo].[Punishers]
    ([PunisherRankId]);
GO

-- Creating foreign key on [GenderId] in table 'Sinners'
ALTER TABLE [dbo].[Sinners]
ADD CONSTRAINT [FK_SinnerGender]
    FOREIGN KEY ([GenderId])
    REFERENCES [dbo].[Genders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SinnerGender'
CREATE INDEX [IX_FK_SinnerGender]
ON [dbo].[Sinners]
    ([GenderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------