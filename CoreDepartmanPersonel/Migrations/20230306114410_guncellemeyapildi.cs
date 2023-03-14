using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartmanPersonel.Migrations
{
    /// <inheritdoc />
    public partial class guncellemeyapildi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departid",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_personels_departid",
                table: "personels",
                column: "departid");

            migrationBuilder.AddForeignKey(
                name: "FK_personels_departmanlars_departid",
                table: "personels",
                column: "departid",
                principalTable: "departmanlars",
                principalColumn: "departid",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_personels_departmanlars_departid",
                table: "personels");

            migrationBuilder.DropIndex(
                name: "IX_personels_departid",
                table: "personels");

            migrationBuilder.DropColumn(
                name: "departid",
                table: "personels");
        }
    }
}
