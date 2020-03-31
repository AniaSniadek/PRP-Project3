
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/14/2018 13:13:00
-- Generated from EDMX file: C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Projekt bazodanowy\BasketballModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [C:\USERS\SNIAD\DESKTOP\STUDIA\2 ROK\PRACOWNIA PROGRAMOWANIA\PROJEKT BAZODANOWY\PROJEKT BAZODANOWY\DATABASEBASKETBALL.MDF];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ZespolPrezes]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zespol] DROP CONSTRAINT [FK_ZespolPrezes];
GO
IF OBJECT_ID(N'[dbo].[FK_ZespolTrener]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Trener] DROP CONSTRAINT [FK_ZespolTrener];
GO
IF OBJECT_ID(N'[dbo].[FK_ZespolHala]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zespol] DROP CONSTRAINT [FK_ZespolHala];
GO
IF OBJECT_ID(N'[dbo].[FK_ZespolZawodnik]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Zawodnik] DROP CONSTRAINT [FK_ZespolZawodnik];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Zespol]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zespol];
GO
IF OBJECT_ID(N'[dbo].[Prezes]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Prezes];
GO
IF OBJECT_ID(N'[dbo].[Trener]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Trener];
GO
IF OBJECT_ID(N'[dbo].[Hala]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Hala];
GO
IF OBJECT_ID(N'[dbo].[Zawodnik]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Zawodnik];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Zespol'
CREATE TABLE [dbo].[Zespol] (
    [zespol_id] int  NOT NULL,
    [nazwa] varchar(50)  NOT NULL,
    [turniej_id] int  NOT NULL,
    [Prezes_prezes_id] int  NOT NULL,
    [Hala_hala_id] int  NOT NULL
);
GO

-- Creating table 'Prezes'
CREATE TABLE [dbo].[Prezes] (
    [prezes_id] int  NOT NULL,
    [nazwisko] nvarchar(max)  NOT NULL,
    [email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Trener'
CREATE TABLE [dbo].[Trener] (
    [trener_id] int IDENTITY(1,1) NOT NULL,
    [nazwisko] nvarchar(max)  NOT NULL,
    [zespol_id] int  NOT NULL
);
GO

-- Creating table 'Hala'
CREATE TABLE [dbo].[Hala] (
    [hala_id] int IDENTITY(1,1) NOT NULL,
    [nazwa] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Zawodnik'
CREATE TABLE [dbo].[Zawodnik] (
    [zawodnik_id] int IDENTITY(1,1) NOT NULL,
    [nazwisko] nvarchar(max)  NOT NULL,
    [numer] int  NOT NULL,
    [zespol_id] int  NOT NULL,
    [data_urodzin] datetime  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [zespol_id] in table 'Zespol'
ALTER TABLE [dbo].[Zespol]
ADD CONSTRAINT [PK_Zespol]
    PRIMARY KEY CLUSTERED ([zespol_id] ASC);
GO

-- Creating primary key on [prezes_id] in table 'Prezes'
ALTER TABLE [dbo].[Prezes]
ADD CONSTRAINT [PK_Prezes]
    PRIMARY KEY CLUSTERED ([prezes_id] ASC);
GO

-- Creating primary key on [trener_id] in table 'Trener'
ALTER TABLE [dbo].[Trener]
ADD CONSTRAINT [PK_Trener]
    PRIMARY KEY CLUSTERED ([trener_id] ASC);
GO

-- Creating primary key on [hala_id] in table 'Hala'
ALTER TABLE [dbo].[Hala]
ADD CONSTRAINT [PK_Hala]
    PRIMARY KEY CLUSTERED ([hala_id] ASC);
GO

-- Creating primary key on [zawodnik_id] in table 'Zawodnik'
ALTER TABLE [dbo].[Zawodnik]
ADD CONSTRAINT [PK_Zawodnik]
    PRIMARY KEY CLUSTERED ([zawodnik_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Prezes_prezes_id] in table 'Zespol'
ALTER TABLE [dbo].[Zespol]
ADD CONSTRAINT [FK_ZespolPrezes]
    FOREIGN KEY ([Prezes_prezes_id])
    REFERENCES [dbo].[Prezes]
        ([prezes_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZespolPrezes'
CREATE INDEX [IX_FK_ZespolPrezes]
ON [dbo].[Zespol]
    ([Prezes_prezes_id]);
GO

-- Creating foreign key on [zespol_id] in table 'Trener'
ALTER TABLE [dbo].[Trener]
ADD CONSTRAINT [FK_ZespolTrener]
    FOREIGN KEY ([zespol_id])
    REFERENCES [dbo].[Zespol]
        ([zespol_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZespolTrener'
CREATE INDEX [IX_FK_ZespolTrener]
ON [dbo].[Trener]
    ([zespol_id]);
GO

-- Creating foreign key on [Hala_hala_id] in table 'Zespol'
ALTER TABLE [dbo].[Zespol]
ADD CONSTRAINT [FK_ZespolHala]
    FOREIGN KEY ([Hala_hala_id])
    REFERENCES [dbo].[Hala]
        ([hala_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZespolHala'
CREATE INDEX [IX_FK_ZespolHala]
ON [dbo].[Zespol]
    ([Hala_hala_id]);
GO

-- Creating foreign key on [zespol_id] in table 'Zawodnik'
ALTER TABLE [dbo].[Zawodnik]
ADD CONSTRAINT [FK_ZespolZawodnik]
    FOREIGN KEY ([zespol_id])
    REFERENCES [dbo].[Zespol]
        ([zespol_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ZespolZawodnik'
CREATE INDEX [IX_FK_ZespolZawodnik]
ON [dbo].[Zawodnik]
    ([zespol_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------