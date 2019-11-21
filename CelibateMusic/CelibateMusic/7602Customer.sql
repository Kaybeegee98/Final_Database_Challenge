CREATE TABLE [dbo].[7602Customer]
(
	CustomerNumber INT NOT NULL,
	[Name] NVARCHAR(50) NOT NULL,
	[Address] NVARCHAR(100) NOT NULL,
	Postcode INT NOT NULL,
	InterestCode NVARCHAR(5) NOT NULL,
	CONSTRAINT PK_Customer PRIMARY KEY(CustomerNumber, InterestCode),
	CONSTRAINT FK_Customer_Interest FOREIGN KEY(InterestCode) REFERENCES [7602Interest](InterestCode)
)
