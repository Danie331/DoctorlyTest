CREATE TABLE [dbo].[Event] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Title]       VARCHAR (255) NOT NULL,
    [Description] VARCHAR (255) NOT NULL,
    [StartTime]   DATETIME      NOT NULL,
    [EndTime]     DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

