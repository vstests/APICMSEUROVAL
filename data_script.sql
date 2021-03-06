USE [PRUEBAS]
GO
SET IDENTITY_INSERT [dbo].[Categoria] ON 

INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (1, N'categoria1')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (2, N'categoria2')
INSERT [dbo].[Categoria] ([ID_Categoria], [Nombre_Categoria]) VALUES (3, N'categoria3')
SET IDENTITY_INSERT [dbo].[Categoria] OFF
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [Descripcion], [Precio], [Categoria]) VALUES (1, N'Producto1', N'descripcionproducto1Modificada', CAST(5 AS Decimal(18, 0)), 1)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [Descripcion], [Precio], [Categoria]) VALUES (2, N'Producto2', N'descripcionProducto2', CAST(20 AS Decimal(18, 0)), 2)
INSERT [dbo].[Producto] ([ID_Producto], [Nombre], [Descripcion], [Precio], [Categoria]) VALUES (3, N'Producto3', N'descripcionProducto3', CAST(30 AS Decimal(18, 0)), 3)
SET IDENTITY_INSERT [dbo].[Producto] OFF
SET IDENTITY_INSERT [dbo].[Idioma] ON 

INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre]) VALUES (1, N'es-ES')
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre]) VALUES (2, N'en-GB')
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre]) VALUES (3, N'de-DE')
INSERT [dbo].[Idioma] ([ID_Idioma], [Nombre]) VALUES (4, N'D')
SET IDENTITY_INSERT [dbo].[Idioma] OFF
INSERT [dbo].[ProductoIdioma] ([ID_Producto], [ID_Idioma]) VALUES (1, 1)
INSERT [dbo].[ProductoIdioma] ([ID_Producto], [ID_Idioma]) VALUES (2, 1)
INSERT [dbo].[ProductoIdioma] ([ID_Producto], [ID_Idioma]) VALUES (3, 1)
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([ID_Color], [Nombre_Color]) VALUES (1, N'Color1')
INSERT [dbo].[Color] ([ID_Color], [Nombre_Color]) VALUES (2, N'Color2')
INSERT [dbo].[Color] ([ID_Color], [Nombre_Color]) VALUES (3, N'Color3')
SET IDENTITY_INSERT [dbo].[Color] OFF
INSERT [dbo].[ProductoColor] ([ID_Producto], [ID_Color]) VALUES (1, 1)
INSERT [dbo].[ProductoColor] ([ID_Producto], [ID_Color]) VALUES (1, 2)
INSERT [dbo].[ProductoColor] ([ID_Producto], [ID_Color]) VALUES (2, 1)
