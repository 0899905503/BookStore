using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LOAISACH",
                columns: table => new
                {
                    ID_column = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NAME = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LOAI_SAC__1E5A0B8E55B4F752", x => x.ID_column);
                });

            migrationBuilder.CreateTable(
                name: "Sachs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TEN = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    HINHANH = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    MOTA = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DABAN = table.Column<int>(type: "int", nullable: true),
                    MALOAISACH = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sachs", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LOAISACH");

            migrationBuilder.DropTable(
                name: "Sachs");
        }
    }
}
