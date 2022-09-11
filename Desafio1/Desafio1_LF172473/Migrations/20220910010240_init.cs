﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Desafio1_LF172473.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(name: "Excursiones");
            migrationBuilder.CreateTable(
                name: "Excursiones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lugar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CostoxPersona = table.Column<double>(type: "float", nullable: false),
                    Img1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Img3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Recomendacion3 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pais = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipoDestino = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Excursiones", x => x.Id);
                });


            migrationBuilder.InsertData(
              table: "Excursiones",
              columns: new[] { "Id", "Lugar", "Descripcion", "CostoxPersona", "Img1", "Img2", "Img3", "Recomendacion1", "Recomendacion2", "Recomendacion3", "Pais", "TipoDestino" },
              values: new object[,]
              {
                {1, "El Tunco", "La Playa el Tunco tiene una linda vista y se observa a los deportistas locales y extranjeros que hacen surf, buen ambiente tanto para jóvenes como también familias, en el que pueden pasar un momento de dispercion, descansando y comiendo en la variedad de Hoteles y restaurantes que tiene",60.18,"eltunco11.jpg","eltunco22.jpg","eltunco33.jpg","Hotel Acantilados","Malecon, Puerto de la Libertad","Playa El Sunzal","El Salvador","Playas"},
                {2, "Acantilados", "Es un lugar con vista panorámica de la playa, una buena opción para comer, el menú es diverso, tienen buena cocina. Esta ubicado a 30 desde Santa Tecla, ofrecen la opción de alojamiento con uso de piscinas. Puedes acceder al mar.",30.41,"acantilados1.jpg","acantilados2.jpg","acantilados3.jpg","Malecon, Puerto de la Libertad","Playa El Sunzal","Playa El Tunco","El Salvador","Playas"},
                {3, "El Pital", "Siendo el punto mas alto de El Salvador con 2730 msnm, El Pital es el lugar perfecto para acampar. El clima es muy fresco durante el dia, pero por las madrugadas se alcanzan temperaturas muy bajas por lo que es necesario llevar equipo adecuado como sleepin bags adecuadas o colchas",25.26,"elpital1.jpg","elpital2.jpg","elpital3.jpg","La Palma","Las Pilas","Mirador Alpes del Pital","El Salvador","Montañas"},
                {4, "Piscinas de Atzumpa", "Las piscinas de Atzumpa esta muy cerca de Ataco, es ideal para refrescarse en días calurosos pues el agua es muy helada, son bastante sencillas la estructura del lugar, pero esto también lo hace accesible para cualquier presupuesto.",32.42,"atzumpa1.jpg","atzumpa2.jpg","atzumpa3.jpg","Mirador De La Cruz","Concepción de Ataco","Cafe Entre Nubes","El Salvador","Balnearios"},
                {5, "Termales Santa Teresa", "Ubicado en Ahuachapán (Termales de Santa Teresa) ofrece al visitante amplios parqueos, extensas piscinas de agua caliente medicinal originada en los pozos geotérmicos de la zona, amplias habitaciones, comedor, cafetería y múltiples senderos para disfrutar el día acompañado de familiares y amigos",23,"termales1.jpg","termales2.jpg","termales3.jpg","Concepcion de Ataco","Cafe Entre Nubes","Piscinas de Atzumpa","El Salvador","Balnearios"},
                {6, "Gumbalimba Park", "Es un hermoso parque que cuenta con diversidad de plantas y animales y si lo deseas te ayudara un guía que te explicara un poco sobre todo. Tambien hay un museo que cuenta la historia de la isla",576.88,"gumbalimba1.jpg","gumbalimba2.jpg","gumbalimba3.jpg","Glass Bottom Boat tours","Grand Roatan Resort","Argentinian Grill West Bay","Honduras","Zoologicos"},
                {7, "Playa Delfines", "Hermosa y emblemática playa de Cancún. Aquí se encuentra el famoso letrero de `CANCÚN` para tomarse la foto. La playa cuenta con servicios de baños y vestuarios; y el mar es precioso",467.32,"playadelfines1.jpg","playadelfines2.jpg","playadelfines3.jpg","La Isla Berkinada","Museo Maya de Cancun","Playa Ballenas","México","Playas"},
                {8, "Entre Pinos", "En un lugar maravilloso, con vistas impresionantes, ideal para estar en contacto con la naturaleza. La quesadilla horneada en horno de barro, deliciosa. Se encuentra a 87.5 kilómetros de la Capital de el Salvador",45.6,"entrepinos1.jpg","entrepinos2.jpg","entrepinos3.jpg","El Pital","La Palma","Las Pilas","El Salvador","Montañas"},
                {9, "Apuzunga", "Ubicado en la ciudad de Metapán, correspondiente al Departamento de Santa Ana, se encuentra este relajante sitio turístico, el cual si bien es conocido y muy visitado por los locales no lo es tanto por la gente que vive fuera de ese departamento.",50,"apuzunga1.jpg","apuzunga2.jpg","apuzunga3.jpg","Parque Recreativo Nuestros Hermanos Lejanos","Hostal Tilapias Conchagua","Balneario Don Elias","El Salvador","Balnearios"},
                {10, "Cayo Cochino Grande", "A solo unos kilómetros de ciudad portuaria caribeña de La Ceiba, Honduras guarda un inexplorado paraíso terrenal en Cayos Cochinos. El archipiélago formado por pequeñas islas, es uno de los tesoros turísticos del país centroamericano que han sorprendido a los visitantes por su espectáculo natural",500,"cochinos1.jpg","cochinos2.jpg","cochinos3.jpg","Cabañas Laru Beya","Cayo Cochino Menor","Vito`s EcoDiving Resort","Honduras","Playas"}

              });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Excursiones");
        }
    }
}
