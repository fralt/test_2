IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Skills] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Value] nvarchar(max) NULL,
    CONSTRAINT [PK_Skills] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Options] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(max) NULL,
    [Value] nvarchar(max) NULL,
    [ParentId] uniqueidentifier NULL,
    [SkillId] uniqueidentifier NULL,
    CONSTRAINT [PK_Options] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Options_Skills_SkillId] FOREIGN KEY ([SkillId]) REFERENCES [Skills] ([Id]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Options_SkillId] ON [Options] ([SkillId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180611191202_Init', N'2.1.0-rtm-30799');

GO

CREATE INDEX [IX_Options_ParentId] ON [Options] ([ParentId]);

GO

ALTER TABLE [Options] ADD CONSTRAINT [FK_Options_Options_ParentId] FOREIGN KEY ([ParentId]) REFERENCES [Options] ([Id]) ON DELETE NO ACTION;

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180611191416_post-init', N'2.1.0-rtm-30799');

GO

