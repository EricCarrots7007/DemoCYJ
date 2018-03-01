CREATE TABLE [dbo].[SubCategory] (
    [SubCategoryId]   INT           IDENTITY (1, 1) NOT NULL,
    [SubCategoryName] VARCHAR (MAX) NOT NULL,
    [CategoryId]      INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([SubCategoryId] ASC),
    CONSTRAINT [FKSubCategory] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Category] ([CategoryId])
);

