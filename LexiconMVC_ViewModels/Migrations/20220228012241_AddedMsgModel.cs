using Microsoft.EntityFrameworkCore.Migrations;

namespace LexiconMVC_ViewModels.Migrations
{
    public partial class AddedMsgModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "87f8f4e4-e142-4dfa-a718-625e87664a2f");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ca54cb00-d174-41c5-ace3-653da1149541", "8a452800-e8c5-4404-a8c1-3441a4fb4d53" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a452800-e8c5-4404-a8c1-3441a4fb4d53");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca54cb00-d174-41c5-ace3-653da1149541");

            migrationBuilder.CreateTable(
                name: "Messages",
                columns: table => new
                {
                    MessageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 30, nullable: false),
                    Subject = table.Column<string>(maxLength: 25, nullable: false),
                    UsrMessage = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Messages", x => x.MessageId);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6a62f62-902c-4dd9-be41-d228c1389ab3", "2ca229e5-90b2-4c7d-92a9-cc2c6c003732", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4e8d2f87-8d66-414d-8603-37dacb430e31", "8573f5ad-ef52-4d2a-ba92-6e2f5c57363a", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c8903bb9-ac4b-4234-a30a-54be340cec18", 0, "1934-06-09", "156a866a-0bad-4a9e-87dc-253e616cb939", "admin@admin.com", false, "Donald", "Duck", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAELp86dPKM7MfULyeXi8A4+v49iEWdYc/5w3jta+AbWlQPnpAhrFFOXHCzMeGnl77xw==", null, false, "216a45b8-10a9-40c2-9735-53ea45e62975", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "c8903bb9-ac4b-4234-a30a-54be340cec18", "b6a62f62-902c-4dd9-be41-d228c1389ab3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Messages");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e8d2f87-8d66-414d-8603-37dacb430e31");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c8903bb9-ac4b-4234-a30a-54be340cec18", "b6a62f62-902c-4dd9-be41-d228c1389ab3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a62f62-902c-4dd9-be41-d228c1389ab3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c8903bb9-ac4b-4234-a30a-54be340cec18");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8a452800-e8c5-4404-a8c1-3441a4fb4d53", "7704f227-5895-406b-9e24-4e2335ce31d7", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "87f8f4e4-e142-4dfa-a718-625e87664a2f", "f7dea200-fb53-4a49-9088-585c2f310b81", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "BirthDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ca54cb00-d174-41c5-ace3-653da1149541", 0, "1934-06-09", "5aebc3bf-2cff-451a-9414-18afb27498ca", "admin@admin.com", false, "Donald", "Duck", false, null, "ADMIN@ADMIN.COM", "ADMIN@ADMIN.COM", "AQAAAAEAACcQAAAAECQ3HFEIR5lMJac/aGviRvJf4Mg3NP6ds57ewl28HcWM7BJjCbObTFcCHaGIuiXLFw==", null, false, "9babf81c-fd70-4159-a3e4-0d62fb2c45db", false, "admin@admin.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "ca54cb00-d174-41c5-ace3-653da1149541", "8a452800-e8c5-4404-a8c1-3441a4fb4d53" });
        }
    }
}
