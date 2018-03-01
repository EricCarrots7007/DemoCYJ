CREATE TABLE [dbo].[Category] (
    [CategoryId]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] VARCHAR (MAX) NOT NULL,
    [WorkStreamId] INT           NOT NULL,
    [TeamId]       INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([CategoryId] ASC),
    CONSTRAINT [FK1] FOREIGN KEY ([WorkStreamId]) REFERENCES [dbo].[WorkStream] ([WorkStreamId]),
    CONSTRAINT [FK2] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([TeamId])
);

