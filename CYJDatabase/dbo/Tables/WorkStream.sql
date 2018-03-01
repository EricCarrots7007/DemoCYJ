CREATE TABLE [dbo].[WorkStream] (
    [WorkStreamId]   INT           IDENTITY (1, 1) NOT NULL,
    [WorkStreamName] VARCHAR (MAX) NOT NULL,
    [TeamId]         INT           NULL,
    PRIMARY KEY CLUSTERED ([WorkStreamId] ASC),
    CONSTRAINT [FK_WorkStream] FOREIGN KEY ([TeamId]) REFERENCES [dbo].[Team] ([TeamId])
);

