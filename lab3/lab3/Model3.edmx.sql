
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 03/22/2020 22:51:48
-- Generated from EDMX file: C:\Users\etibulea\source\repos\lab3\lab3\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [lab3];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Albums'
CREATE TABLE [dbo].[Albums] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [AlbumName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Arists'
CREATE TABLE [dbo].[Arists] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AristAlbum'
CREATE TABLE [dbo].[AristAlbum] (
    [Arists_Id] int  NOT NULL,
    [Albums_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Albums'
ALTER TABLE [dbo].[Albums]
ADD CONSTRAINT [PK_Albums]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Arists'
ALTER TABLE [dbo].[Arists]
ADD CONSTRAINT [PK_Arists]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Arists_Id], [Albums_Id] in table 'AristAlbum'
ALTER TABLE [dbo].[AristAlbum]
ADD CONSTRAINT [PK_AristAlbum]
    PRIMARY KEY CLUSTERED ([Arists_Id], [Albums_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Arists_Id] in table 'AristAlbum'
ALTER TABLE [dbo].[AristAlbum]
ADD CONSTRAINT [FK_AristAlbum_Arist]
    FOREIGN KEY ([Arists_Id])
    REFERENCES [dbo].[Arists]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Albums_Id] in table 'AristAlbum'
ALTER TABLE [dbo].[AristAlbum]
ADD CONSTRAINT [FK_AristAlbum_Album]
    FOREIGN KEY ([Albums_Id])
    REFERENCES [dbo].[Albums]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AristAlbum_Album'
CREATE INDEX [IX_FK_AristAlbum_Album]
ON [dbo].[AristAlbum]
    ([Albums_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------