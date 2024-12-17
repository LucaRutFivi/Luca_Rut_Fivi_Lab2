using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Luca_Rut_Fivi_Lab2.Migrations
{
    /// <inheritdoc />
    public partial class newmigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Authors");

            migrationBuilder.RenameColumn(
                name: "Author",
                table: "Book",
                newName: "AuthorID");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Authors",
                newName: "AuthorsName");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(6,2)");

            migrationBuilder.AddColumn<int>(
                name: "AuthorID1",
                table: "Book",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Book_AuthorID1",
                table: "Book",
                column: "AuthorID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorID1",
                table: "Book",
                column: "AuthorID1",
                principalTable: "Authors",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorID1",
                table: "Book");

            migrationBuilder.DropIndex(
                name: "IX_Book_AuthorID1",
                table: "Book");

            migrationBuilder.DropColumn(
                name: "AuthorID1",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Book",
                newName: "Author");

            migrationBuilder.RenameColumn(
                name: "AuthorsName",
                table: "Authors",
                newName: "LastName");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Book",
                type: "decimal(6,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Authors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
