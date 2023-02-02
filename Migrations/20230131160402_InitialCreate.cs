using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IhorProjektGame.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CollectionGame",
                columns: table => new
                {
                    CollectionGameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameCollectiongame = table.Column<string>(name: "Name Collection game", type: "nvarchar(80)", maxLength: 80, nullable: false),
                    NameCompanyCollection = table.Column<string>(name: "Name Company Collection", type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Developeryearatthegamecollection = table.Column<double>(name: " Developer year at the game collection", type: "float", nullable: false),
                    Prisegamecollection = table.Column<double>(name: "Prise game collection", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CollectionGame", x => x.CollectionGameId);
                });

            migrationBuilder.CreateTable(
                name: "Game",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namegame = table.Column<string>(name: "Name game", type: "nvarchar(80)", maxLength: 80, nullable: false),
                    NameCompany = table.Column<string>(name: "Name Company", type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Developeryearatthegame = table.Column<double>(name: " Developer year at the game", type: "float", nullable: false),
                    Prisegame = table.Column<double>(name: "Prise game", type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Game", x => x.GameId);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    GenreId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NGenre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GameId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.GenreId);
                    table.ForeignKey(
                        name: "FK_Genre_Game_GameId",
                        column: x => x.GameId,
                        principalTable: "Game",
                        principalColumn: "GameId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Genre_GameId",
                table: "Genre",
                column: "GameId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CollectionGame");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Game");
        }
    }
}
