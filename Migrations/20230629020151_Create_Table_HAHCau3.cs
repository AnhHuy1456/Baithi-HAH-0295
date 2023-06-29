using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baithi_HAH.Migrations
{
    /// <inheritdoc />
    public partial class Create_Table_HAHCau3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HAHCau3",
                columns: table => new
                {
                    Masinhvien = table.Column<string>(type: "TEXT", nullable: false),
                    Hoten = table.Column<string>(type: "TEXT", nullable: false),
                    Namsinh = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HAHCau3", x => x.Masinhvien);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HAHCau3");
        }
    }
}
