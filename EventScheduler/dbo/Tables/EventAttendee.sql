CREATE TABLE [dbo].[EventAttendee] (
    [Id]                   INT IDENTITY (1, 1) NOT NULL,
    [EventId]              INT NOT NULL,
    [AttendeeId]           INT NOT NULL,
    [ConfirmationReceived] BIT DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    FOREIGN KEY ([AttendeeId]) REFERENCES [dbo].[Attendee] ([Id]),
    FOREIGN KEY ([EventId]) REFERENCES [dbo].[Event] ([Id])
);

