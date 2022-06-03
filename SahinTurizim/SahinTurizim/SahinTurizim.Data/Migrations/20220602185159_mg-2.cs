using Microsoft.EntityFrameworkCore.Migrations;

namespace SahinTurizim.Data.Migrations
{
    public partial class mg2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThiriTerminal",
                table: "Routes",
                newName: "ThirdTerminal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ThirdTerminal",
                table: "Routes",
                newName: "ThiriTerminal");
        }
    }
}
