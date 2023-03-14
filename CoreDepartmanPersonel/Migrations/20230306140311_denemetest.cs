using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CoreDepartmanPersonel.Migrations
{
    /// <inheritdoc />
    public partial class denemetest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departmanid",
                table: "personels",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "departmanid",
                table: "personels");
        }
    }
}
