DELETE FROM [7602Sale];
DELETE FROM [7602Record];
DELETE FROM [7602Customer];
DELETE FROM [7602Interest];

INSERT INTO [7602Record](RecordID, Title, Performer)
VALUES	('PF003', 'The Wall', 'Pink Floyd'),
		('IX002', 'Kick', 'INXS'),
		('SP069', 'Never Mind the Bollocks', 'Sex Pistols'),
		('PF002', 'The Dark Side of the Moon', 'Pink Floyd'),
		('IX005', 'Shabooh shoobah', 'INXS'),
		('SP070', 'Flogging a Dead Horse', 'Sex Pistols'),
		('PF004', 'The Endless River', 'Pink Floyd'),
		('PF006', 'Wish You Were Here', 'Pink Floyd'),
		('SP075', 'Agents of Anarchy', 'Sex Pistols'),
		('PF007', 'the Division Bell', 'Pink Floyd');

INSERT INTO [7602Interest](InterestCode, InterestDescription)
VALUES	('RR', 'Rock and Roll'),
		('JA', 'Jazz'),
		('RB', 'Rhythm and Blues');

INSERT INTO [7602Customer](CustomerNumber, [Name], [Address], PostCode, InterestCode)
VALUES	(123, 'Jimmy Barnes', '1 Sesame Street', 3000, 'RR'),
		(456, 'Ian Moss', '10 Downing Street', 4000, 'JA'),
		(789, 'Don Walker', '221B Baker Street', 5000, 'RB'),
		(234, 'Steve Prestwich', 'LG1 College Cres, Parkville', 6000, 'RR'),
		(567, 'Phil Small', '1 Adelaide Avenue', 7000, 'RB');

INSERT INTO [7602Sale](SaleDate, PricePaid, RecordID, CustomerNumber, InterestCode)
VALUES	('20151201', 30, 'PF003', 123, 'RR'),
		('20151201', 29.95, 'IX002', 123, 'RR'),
		('20151202', 12.45, 'SP069', 123, 'RR'),
		('20151205', 30, 'IX002', 123, 'RR'),
		('20151201', 31, 'PF002', 456, 'JA'),
		('20151203', 28.95, 'IX005', 456, 'JA'),
		('20151206', 13.45, 'SP070', 456, 'JA'),
		('20151202', 29, 'PF004', 789, 'RB'),
		('20151205', 29.95, 'IX002', 789, 'RB'),
		('20151201', 45, 'PF006', 234, 'RR'),
		('20151204', 5.67, 'SP075', 234, 'RR'),
		('20151203', 9.95, 'PF007', 567, 'RB');