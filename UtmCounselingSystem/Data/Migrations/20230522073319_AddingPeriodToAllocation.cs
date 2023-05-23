using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UtmCounselingSystem.Data.Migrations
{
    public partial class AddingPeriodToAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "AppointmentAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "2ad2a620-575f-423d-a7c5-6a64d239bb8f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                column: "ConcurrencyStamp",
                value: "4682cc6e-03fe-4053-b177-19d960f3df7a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f4631bd-f907-4409-b416-ba356312e659",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aafaf4ec-23ba-4d40-9d9b-21a3549f799e", "AQAAAAEAACcQAAAAEEA1Lqj9J1YVPFjNDsFQwIqDOPxWjznernrvugHnpHC9/JRtwDKdLYLWHDIrWBx4Tw==", "c8ea4d50-fbdf-4b58-88d2-e54d8b22906a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "408aa945-3d84-4421-8342-7269ec64d949",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3e3e041-e140-43ff-b1ed-4443e7164814", "AQAAAAEAACcQAAAAEFv74BOPO87tolUUE158V0d7azw2ahK04jeoDsDIts1uOmyByNcOPynUVyQgjW4trA==", "5c26a0b5-5141-4b85-ae84-bd762e9f543b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "AppointmentAllocations");

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
    }
}
