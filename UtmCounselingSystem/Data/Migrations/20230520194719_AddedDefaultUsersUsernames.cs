using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtmCounselingSystem.Data.Migrations
{
    public partial class AddedDefaultUsersUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2b766ba3-7b32-408f-abe5-f3e611403070");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "82fa851b-5365-494c-aabf-fde63a005ce4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd893dd0-bc5a-49d5-be2c-74cd1a396e0f", "AQAAAAEAACcQAAAAEBIJkRCyA5UJ3MXDVeVojDIEWx3uGmCk5YskakdpYn9+cnX7pknIAFu3CoqrClXNkw==", "61abb42b-2019-4083-9dc1-887bf174a6c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c42c200a-0db6-471b-a3f1-6d448407bb22", "AQAAAAEAACcQAAAAEFhEHLsKvJKbU0Nn0AD69DHPss6E1UsuNZzqLvHy8x8q03NE2sB5gtgEsUcVVnO6FQ==", "e77d265b-302b-468b-b05c-5488a70dc4c5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "161809b6-07f3-4c07-9758-cad6e99dee42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "a779622a-dd10-4d0a-a25e-90d1eebfce33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3bd3328-a7e9-410d-aa35-3bd046ab567c", "AQAAAAEAACcQAAAAEKkvFqbqCD58NK3+T4Sk7OUsrJca3igKzJgv+tiXN54ilcDIMZQA0mnbWJuL7I6t4g==", "264f9714-a324-4b61-a94a-9bb9e525d971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4089997-34a7-436f-99e7-cf8f74ac3acd", "AQAAAAEAACcQAAAAEApJPNP9VFITFrjdqKlTCGSSBwp75kTCU28ZUH2ouVFDvJ/zklmDvrd5djHmReVtpg==", "789702f8-3ef0-4a1c-8745-1609ad3d5808" });
        }
    }
}
