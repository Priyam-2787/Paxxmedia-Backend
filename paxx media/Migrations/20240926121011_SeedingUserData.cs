using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace paxx_media.Migrations
{
    /// <inheritdoc />
    public partial class SeedingUserData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "ID", "Email", "Name", "PasswordHash", "Role" },
                values: new object[,]
                {
                    { 1, "alice@example.com", "Alice Smith", "hashedpassword1", "Developer" },
                    { 2, "bob@example.com", "Bob Johnson", "hashedpassword2", "Data Analyst" },
                    { 3, "charlie@example.com", "Charlie Brown", "hashedpassword3", "scrum master" },
                    { 4, "ali@example.com", "Ali Shah", "hashedpassword5", "Developer" },
                    { 5, "bon@example.com", "Bon Johnson", "hashedpassword9", "Data Analyst" },
                    { 6, "Juhi@example.com", "Juhi Brown", "hashedpassword7", "scrum master" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
