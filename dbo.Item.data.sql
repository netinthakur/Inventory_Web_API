SET IDENTITY_INSERT [dbo].[Item] ON
INSERT INTO [dbo].[Item] ([Id], [Name], [Price], [Quantity]) VALUES (1, N'HP Elitebook', CAST(900.00 AS Decimal(18, 2)), 1000)
INSERT INTO [dbo].[Item] ([Id], [Name], [Price], [Quantity]) VALUES (2, N'Samsung Smart TV 21''''', CAST(1200.00 AS Decimal(18, 2)), 500)
INSERT INTO [dbo].[Item] ([Id], [Name], [Price], [Quantity]) VALUES (3, N'X box 360 ', CAST(800.00 AS Decimal(18, 2)), 2000)
SET IDENTITY_INSERT [dbo].[Item] OFF
