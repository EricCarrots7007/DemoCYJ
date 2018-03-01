CREATE TABLE [dbo].[Team] (
    [TeamId]   INT           IDENTITY (1, 1) NOT NULL,
    [TeamName] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([TeamId] ASC)
);

