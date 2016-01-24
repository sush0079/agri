CREATE TABLE [dbo].[Registration] (
    [Name]           VARCHAR (50) NOT NULL,
    [Address Line 1] VARCHAR (50) NOT NULL,
    [Address Line 2] VARCHAR (50) NULL,
    [Pin Code]       NUMERIC (18) NOT NULL,
    [Occupation]     VARCHAR (50) NOT NULL,
    [Conatct Number] NUMERIC (18) NULL,
    [Email Id]       VARCHAR (50) NULL
);

