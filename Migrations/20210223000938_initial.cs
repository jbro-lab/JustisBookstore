using Microsoft.EntityFrameworkCore.Migrations;

namespace JustisBookstore.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ISBN = table.Column<string>(nullable: false),
                    title = table.Column<string>(nullable: false),
                    authorFirstName = table.Column<string>(nullable: false),
                    authorMiddleName = table.Column<string>(nullable: false),
                    authorLastName = table.Column<string>(nullable: false),
                    publisher = table.Column<string>(nullable: false),
                    classification = table.Column<string>(nullable: false),
                    category = table.Column<string>(nullable: false),
                    price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
