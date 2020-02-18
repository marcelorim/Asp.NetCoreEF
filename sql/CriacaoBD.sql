IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Livros] (
    [Id] int NOT NULL IDENTITY,
    [Nome] varchar(200) NOT NULL,
    [Isbn] int NOT NULL,
    [Autor] varchar(200) NOT NULL,
    [Preco] decimal(18,2) NOT NULL,
    [DtPublicacao] datetime2 NOT NULL,
    [Capa] varchar(100) NOT NULL,
    CONSTRAINT [PK_Livros] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200217215514_Initial', N'3.1.1');

GO

