USE [Chart]
GO
SET IDENTITY_INSERT [dbo].[ChartType] ON 

INSERT [dbo].[ChartType] ([Id], [Name]) VALUES (5, N'Bar')
INSERT [dbo].[ChartType] ([Id], [Name]) VALUES (4, N'Line')
INSERT [dbo].[ChartType] ([Id], [Name]) VALUES (2, N'Pie')
INSERT [dbo].[ChartType] ([Id], [Name]) VALUES (1, N'Polar')
INSERT [dbo].[ChartType] ([Id], [Name]) VALUES (3, N'Spline')
SET IDENTITY_INSERT [dbo].[ChartType] OFF
SET IDENTITY_INSERT [dbo].[LineChart] ON 

INSERT [dbo].[LineChart] ([Id], [Value]) VALUES (1, CAST(1.50 AS Decimal(18, 2)))
INSERT [dbo].[LineChart] ([Id], [Value]) VALUES (2, CAST(3.50 AS Decimal(18, 2)))
INSERT [dbo].[LineChart] ([Id], [Value]) VALUES (3, CAST(5.50 AS Decimal(18, 2)))
INSERT [dbo].[LineChart] ([Id], [Value]) VALUES (4, CAST(8.00 AS Decimal(18, 2)))
INSERT [dbo].[LineChart] ([Id], [Value]) VALUES (5, CAST(15.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[LineChart] OFF
SET IDENTITY_INSERT [dbo].[PieChart] ON 

INSERT [dbo].[PieChart] ([Id], [Month], [Percent]) VALUES (1, N'January', 34)
INSERT [dbo].[PieChart] ([Id], [Month], [Percent]) VALUES (2, N'February', 21)
INSERT [dbo].[PieChart] ([Id], [Month], [Percent]) VALUES (3, N'March', 17)
INSERT [dbo].[PieChart] ([Id], [Month], [Percent]) VALUES (4, N'April', 28)
SET IDENTITY_INSERT [dbo].[PieChart] OFF
SET IDENTITY_INSERT [dbo].[PolarChart] ON 

INSERT [dbo].[PolarChart] ([Id], [Year], [Car], [Bus], [Tractors]) VALUES (1, 2007, 43, 78, 23)
INSERT [dbo].[PolarChart] ([Id], [Year], [Car], [Bus], [Tractors]) VALUES (2, 2008, 87, 97, 74)
INSERT [dbo].[PolarChart] ([Id], [Year], [Car], [Bus], [Tractors]) VALUES (3, 2010, 80, 130, 86)
SET IDENTITY_INSERT [dbo].[PolarChart] OFF
SET IDENTITY_INSERT [dbo].[SplineChart] ON 

INSERT [dbo].[SplineChart] ([Id], [Letter], [X], [Y]) VALUES (1, N'a', 0, 20)
INSERT [dbo].[SplineChart] ([Id], [Letter], [X], [Y]) VALUES (3, N'b', 20, 40)
INSERT [dbo].[SplineChart] ([Id], [Letter], [X], [Y]) VALUES (4, N'c', 50, 70)
SET IDENTITY_INSERT [dbo].[SplineChart] OFF
