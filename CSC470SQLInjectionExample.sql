/****** Object:  Table [Student]    Script Date: 9/17/2020 10:21:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Student](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[LastName] [varchar](100) NOT NULL,
	[FirstName] [varchar](100) NOT NULL,
	[GPA] [decimal](3, 2) NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [User]    Script Date: 9/17/2020 10:21:33 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [User](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](100) NOT NULL,
	[Password] [varchar](100) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [Student] ON 

INSERT [Student] ([Id], [LastName], [FirstName], [GPA]) VALUES (1, N'Weselenchuk', N'Kane', CAST(4.00 AS Decimal(3, 2)))
INSERT [Student] ([Id], [LastName], [FirstName], [GPA]) VALUES (2, N'De La Rosa', N'Daniel', CAST(3.75 AS Decimal(3, 2)))
INSERT [Student] ([Id], [LastName], [FirstName], [GPA]) VALUES (3, N'Carson III', N'Rocky', CAST(3.50 AS Decimal(3, 2)))
INSERT [Student] ([Id], [LastName], [FirstName], [GPA]) VALUES (4, N'Landa', N'Alejandro', CAST(3.25 AS Decimal(3, 2)))
SET IDENTITY_INSERT [Student] OFF
GO
SET IDENTITY_INSERT [User] ON 

INSERT [User] ([Id], [UserName], [Password]) VALUES (1, N'KaneW', N'number1')
INSERT [User] ([Id], [UserName], [Password]) VALUES (2, N'DanielD', N'number2')
INSERT [User] ([Id], [UserName], [Password]) VALUES (3, N'RockyC', N'number3')
INSERT [User] ([Id], [UserName], [Password]) VALUES (4, N'AlejandroL', N'number4')
SET IDENTITY_INSERT [User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_Student]    Script Date: 9/17/2020 10:21:33 AM ******/
ALTER TABLE [Student] ADD  CONSTRAINT [IX_Student] UNIQUE NONCLUSTERED 
(
	[LastName] ASC,
	[FirstName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_User]    Script Date: 9/17/2020 10:21:33 AM ******/
ALTER TABLE [User] ADD  CONSTRAINT [IX_User] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
