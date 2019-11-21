CREATE TABLE [dbo].[7602Sale]
(
	SaleDate DATE NOT NULL,
	PricePaid INT NOT NULL,
	RecordID NVARCHAR(10) NOT NULL,
	CustomerNumber INT NOT NULL,
	InterestCode NVARCHAR(5) NOT NULL,
	CONSTRAINT PK_Sale PRIMARY KEY(SaleDate, RecordID, CustomerNumber, InterestCode),
	CONSTRAINT FK_Sale_Record FOREIGN KEY(RecordID) REFERENCES [7602Record](RecordID),
	CONSTRAINT FK_Sale_Customer FOREIGN KEY(CustomerNumber, InterestCode) REFERENCES [7602Customer](CustomerNumber, InterestCode)
)
