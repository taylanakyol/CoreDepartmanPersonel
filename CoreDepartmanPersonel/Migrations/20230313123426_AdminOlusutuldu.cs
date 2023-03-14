using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartmanPersonel.Migrations
{
    /// <inheritdoc />
    public partial class AdminOlusutuldu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "admins",
                columns: table => new
                {
                    AdminID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Kullanici = table.Column<string>(type: "Varchar(20)", nullable: false),
                    Sifre = table.Column<string>(type: "Varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_admins", x => x.AdminID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "admins");
        }
    }
}
