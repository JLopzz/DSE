IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

DROP TABLE [Excursiones];
GO

CREATE TABLE [Excursiones] (
    [Id] int NOT NULL IDENTITY,
    [Lugar] nvarchar(max) NOT NULL,
    [Descripcion] nvarchar(max) NOT NULL,
    [CostoxPersona] float NOT NULL,
    [Img1] nvarchar(max) NOT NULL,
    [Img2] nvarchar(max) NOT NULL,
    [Img3] nvarchar(max) NOT NULL,
    [Recomendacion1] nvarchar(max) NOT NULL,
    [Recomendacion2] nvarchar(max) NOT NULL,
    [Recomendacion3] nvarchar(max) NOT NULL,
    [Pais] nvarchar(max) NOT NULL,
    [TipoDestino] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Excursiones] PRIMARY KEY ([Id])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Lugar', N'Descripcion', N'CostoxPersona', N'Img1', N'Img2', N'Img3', N'Recomendacion1', N'Recomendacion2', N'Recomendacion3', N'Pais', N'TipoDestino') AND [object_id] = OBJECT_ID(N'[Excursiones]'))
    SET IDENTITY_INSERT [Excursiones] ON;
INSERT INTO [Excursiones] ([Id], [Lugar], [Descripcion], [CostoxPersona], [Img1], [Img2], [Img3], [Recomendacion1], [Recomendacion2], [Recomendacion3], [Pais], [TipoDestino])
VALUES (1, N'El Tunco', N'La Playa el Tunco tiene una linda vista y se observa a los deportistas locales y extranjeros que hacen surf, buen ambiente tanto para jóvenes como también familias, en el que pueden pasar un momento de dispercion, descansando y comiendo en la variedad de Hoteles y restaurantes que tiene', 60.18E0, N'eltunco11.jpg', N'eltunco22.jpg', N'eltunco33.jpg', N'Hotel Acantilados', N'Malecon, Puerto de la Libertad', N'Playa El Sunzal', N'El Salvador', N'Playas'),
(2, N'Acantilados', N'Es un lugar con vista panorámica de la playa, una buena opción para comer, el menú es diverso, tienen buena cocina. Esta ubicado a 30 desde Santa Tecla, ofrecen la opción de alojamiento con uso de piscinas. Puedes acceder al mar.', 30.41E0, N'acantilados1.jpg', N'acantilados2.jpg', N'acantilados3.jpg', N'Malecon, Puerto de la Libertad', N'Playa El Sunzal', N'Playa El Tunco', N'El Salvador', N'Playas'),
(3, N'El Pital', N'Siendo el punto mas alto de El Salvador con 2730 msnm, El Pital es el lugar perfecto para acampar. El clima es muy fresco durante el dia, pero por las madrugadas se alcanzan temperaturas muy bajas por lo que es necesario llevar equipo adecuado como sleepin bags adecuadas o colchas', 25.260000000000002E0, N'elpital1.jpg', N'elpital2.jpg', N'elpital3.jpg', N'La Palma', N'Las Pilas', N'Mirador Alpes del Pital', N'El Salvador', N'Montañas'),
(4, N'Piscinas de Atzumpa', N'Las piscinas de Atzumpa esta muy cerca de Ataco, es ideal para refrescarse en días calurosos pues el agua es muy helada, son bastante sencillas la estructura del lugar, pero esto también lo hace accesible para cualquier presupuesto.', 32.420000000000002E0, N'atzumpa1.jpg', N'atzumpa2.jpg', N'atzumpa3.jpg', N'Mirador De La Cruz', N'Concepción de Ataco', N'Cafe Entre Nubes', N'El Salvador', N'Balnearios'),
(5, N'Termales Santa Teresa', N'Ubicado en Ahuachapán (Termales de Santa Teresa) ofrece al visitante amplios parqueos, extensas piscinas de agua caliente medicinal originada en los pozos geotérmicos de la zona, amplias habitaciones, comedor, cafetería y múltiples senderos para disfrutar el día acompañado de familiares y amigos', 23.0E0, N'termales1.jpg', N'termales2.jpg', N'termales3.jpg', N'Concepcion de Ataco', N'Cafe Entre Nubes', N'Piscinas de Atzumpa', N'El Salvador', N'Balnearios'),
(6, N'Gumbalimba Park', N'Es un hermoso parque que cuenta con diversidad de plantas y animales y si lo deseas te ayudara un guía que te explicara un poco sobre todo. Tambien hay un museo que cuenta la historia de la isla', 576.88E0, N'gumbalimba1.jpg', N'gumbalimba2.jpg', N'gumbalimba3.jpg', N'Glass Bottom Boat tours', N'Grand Roatan Resort', N'Argentinian Grill West Bay', N'Honduras', N'Zoologicos'),
(7, N'Playa Delfines', N'Hermosa y emblemática playa de Cancún. Aquí se encuentra el famoso letrero de `CANCÚN` para tomarse la foto. La playa cuenta con servicios de baños y vestuarios; y el mar es precioso', 467.31999999999999E0, N'playadelfines1.jpg', N'playadelfines2.jpg', N'playadelfines3.jpg', N'La Isla Berkinada', N'Museo Maya de Cancun', N'Playa Ballenas', N'México', N'Playas'),
(8, N'Entre Pinos', N'En un lugar maravilloso, con vistas impresionantes, ideal para estar en contacto con la naturaleza. La quesadilla horneada en horno de barro, deliciosa. Se encuentra a 87.5 kilómetros de la Capital de el Salvador', 45.600000000000001E0, N'entrepinos1.jpg', N'entrepinos2.jpg', N'entrepinos3.jpg', N'El Pital', N'La Palma', N'Las Pilas', N'El Salvador', N'Montañas'),
(9, N'Apuzunga', N'Ubicado en la ciudad de Metapán, correspondiente al Departamento de Santa Ana, se encuentra este relajante sitio turístico, el cual si bien es conocido y muy visitado por los locales no lo es tanto por la gente que vive fuera de ese departamento.', 50.0E0, N'apuzunga1.jpg', N'apuzunga2.jpg', N'apuzunga3.jpg', N'Parque Recreativo Nuestros Hermanos Lejanos', N'Hostal Tilapias Conchagua', N'Balneario Don Elias', N'El Salvador', N'Balnearios'),
(10, N'Cayo Cochino Grande', N'A solo unos kilómetros de ciudad portuaria caribeña de La Ceiba, Honduras guarda un inexplorado paraíso terrenal en Cayos Cochinos. El archipiélago formado por pequeñas islas, es uno de los tesoros turísticos del país centroamericano que han sorprendido a los visitantes por su espectáculo natural', 500.0E0, N'cochinos1.jpg', N'cochinos2.jpg', N'cochinos3.jpg', N'Cabañas Laru Beya', N'Cayo Cochino Menor', N'Vito`s EcoDiving Resort', N'Honduras', N'Playas');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Lugar', N'Descripcion', N'CostoxPersona', N'Img1', N'Img2', N'Img3', N'Recomendacion1', N'Recomendacion2', N'Recomendacion3', N'Pais', N'TipoDestino') AND [object_id] = OBJECT_ID(N'[Excursiones]'))
    SET IDENTITY_INSERT [Excursiones] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220910010240_init', N'6.0.8');
GO

COMMIT;
GO

