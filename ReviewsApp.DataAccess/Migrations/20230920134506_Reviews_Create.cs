using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ReviewsApp.DataAccess.Migrations
{
    public partial class Reviews_Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    OrganisationName = table.Column<string>(type: "nvarchar(256)", nullable: false),
                    OrganisationAddress = table.Column<string>(type: "nvarchar(256)", nullable: true),
                    Advantages = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    Disadvantages = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Evaluation = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
