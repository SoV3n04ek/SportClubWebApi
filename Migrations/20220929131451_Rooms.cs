using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SportClubApi.Migrations
{
    public partial class Rooms : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCountPeoples = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "MaxCountPeoples", "Name" },
                values: new object[] { 1, 10, "Small gym first floor" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "MaxCountPeoples", "Name" },
                values: new object[] { 2, 10, "Small gym second floor" });

            migrationBuilder.InsertData(
                table: "Rooms",
                columns: new[] { "Id", "MaxCountPeoples", "Name" },
                values: new object[] { 3, 30, "Big gym second floor" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rooms");
        }
    }
}
