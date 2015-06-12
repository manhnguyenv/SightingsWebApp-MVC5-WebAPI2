# SightingsWebApp-MVC5-WebAPI2
Starter for MVC5 or Web API 2, with NInject, Indentity DB and Sightings ModelFactory ready
<pre>Package Manager Console Commmands</pre>

<code>Enable-Migrations -MigrationsDirectory Migrations\Sightings -ContextTypeName ZooSightingDemoDb -Verbose</code>

<code>Add-Migration -Name InitialCreate -ConfigurationTypeName SightingsWebApp.Migrations.Sightings.Configuration  -Verbose</code>

<code>Update-Database -ConfigurationTypeName SightingsWebApp.Migrations.Sightings.Configuration -Verbose</code>

<pre>sql script for zoo data</pre>

<pre>
USE SightingsWebAppMVC5Demo
GO

INSERT [sightings].[Zoos] ([City], [Name]) VALUES (N'Seattle', N'Seattle Zoo')
GO
INSERT [sightings].[Zoos] ([City], [Name]) VALUES (N'29 Palms', N'The Desert Zoo')
GO

INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (1, N'Salamander', 2.5, 1)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (1, N'Turtle, Musk', 6.5, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Whale', 1000, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Blackfish', 3, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Glassfish', 3, 1)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Catfish', 7, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Carp', 6, 1)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Trout', 3, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Herring', 2, 1)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Lungfish', 5, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Mackerel', 3, 1)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Cod', 4, 2)
GO
INSERT [sightings].[Animals] ([Group], [Name], [Weight], [Zoo_Id]) VALUES (2, N'Prowfish', 3, 1)
GO
</pre>
