
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/23/2012 16:31:40
-- Generated from EDMX file: C:\Projects\TimeTracker\TimeTracker\TimeTracker.Data\TimeTrackerDataModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [TimeTracker];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_UserBooking];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProject_User]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProject] DROP CONSTRAINT [FK_UserProject_User];
GO
IF OBJECT_ID(N'[dbo].[FK_UserProject_Project]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[UserProject] DROP CONSTRAINT [FK_UserProject_Project];
GO
IF OBJECT_ID(N'[dbo].[FK_ProjectBooking]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Bookings] DROP CONSTRAINT [FK_ProjectBooking];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO
IF OBJECT_ID(N'[dbo].[Projects]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Projects];
GO
IF OBJECT_ID(N'[dbo].[Bookings]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Bookings];
GO
IF OBJECT_ID(N'[dbo].[UserProject]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserProject];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'User'
CREATE TABLE [dbo].[User] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'Project'
CREATE TABLE [dbo].[Project] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Booking'
CREATE TABLE [dbo].[Booking] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [User_Id] int  NOT NULL,
    [Project_Id] int  NOT NULL
);
GO

-- Creating table 'UserProject'
CREATE TABLE [dbo].[UserProject] (
    [User_Id] int  NOT NULL,
    [Projects_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'User'
ALTER TABLE [dbo].[User]
ADD CONSTRAINT [PK_User]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Project'
ALTER TABLE [dbo].[Project]
ADD CONSTRAINT [PK_Project]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Booking'
ALTER TABLE [dbo].[Booking]
ADD CONSTRAINT [PK_Booking]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [User_Id], [Projects_Id] in table 'UserProject'
ALTER TABLE [dbo].[UserProject]
ADD CONSTRAINT [PK_UserProject]
    PRIMARY KEY NONCLUSTERED ([User_Id], [Projects_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'Booking'
ALTER TABLE [dbo].[Booking]
ADD CONSTRAINT [FK_UserBooking]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBooking'
CREATE INDEX [IX_FK_UserBooking]
ON [dbo].[Booking]
    ([User_Id]);
GO

-- Creating foreign key on [User_Id] in table 'UserProject'
ALTER TABLE [dbo].[UserProject]
ADD CONSTRAINT [FK_UserProject_User]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[User]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Projects_Id] in table 'UserProject'
ALTER TABLE [dbo].[UserProject]
ADD CONSTRAINT [FK_UserProject_Project]
    FOREIGN KEY ([Projects_Id])
    REFERENCES [dbo].[Project]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserProject_Project'
CREATE INDEX [IX_FK_UserProject_Project]
ON [dbo].[UserProject]
    ([Projects_Id]);
GO

-- Creating foreign key on [Project_Id] in table 'Booking'
ALTER TABLE [dbo].[Booking]
ADD CONSTRAINT [FK_ProjectBooking]
    FOREIGN KEY ([Project_Id])
    REFERENCES [dbo].[Project]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ProjectBooking'
CREATE INDEX [IX_FK_ProjectBooking]
ON [dbo].[Booking]
    ([Project_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------