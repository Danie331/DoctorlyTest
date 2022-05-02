CREATE TABLE [dbo].[EventNotification] (
    [Id]       INT      IDENTITY (1, 1) NOT NULL,
    [EventId]  INT      NOT NULL,
    [Sent]     BIT      DEFAULT ((0)) NOT NULL,
    [DateSent] DATETIME NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([Id])
);

