using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingApp.Infrastructure.Migrations
{
    public partial class Dataseeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "99b1aa36-e10b-4644-b284-31b8cf3b7298", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEC8DvZ9TzqQye+Lg/8Ev02jK6FPVaEL/naJckQHEWG2fn0eNr5b030S8z0D1unRNew==", null, false, "3e68d1f7-64ac-406f-8d1a-47fae524b69b", false, "guest@mail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "dea12856-c198-4129-b3f3-b893d8395082", 0, "b981b09d-6280-4544-b25e-7b01d5a8349f", "agent@mail.com", false, false, null, "agent@mail.com", "agent@mail.com", "AQAAAAEAACcQAAAAEJp7nvSR/CF8DrJYB3Ct/jrI5Tl2WnV8vlZ5XWgig8TQ67jWrKDYMJm/iLKUhwVaOw==", null, false, "9a7d0ba4-3eeb-4ff9-8062-577f5bd7870d", false, "agent@mail.com" });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "Name", "UserId" },
                values: new object[] { 1, "Ivan Petrov", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "CardioTrainings",
                columns: new[] { "Id", "Date", "DistanceInMeters", "DurationInMinutes", "ParticipantId", "TrainerId", "Type" },
                values: new object[] { 1, new DateTime(2024, 5, 7, 12, 0, 0, 0, DateTimeKind.Unspecified), 5000, 60, null, 1, "Running" });

            migrationBuilder.InsertData(
                table: "Crossfits",
                columns: new[] { "Id", "Date", "DurationInMinutes", "ParticipantId", "TrainerId" },
                values: new object[] { 1, new DateTime(2024, 5, 5, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 1 });

            migrationBuilder.InsertData(
                table: "Hiits",
                columns: new[] { "Id", "Date", "DurationInMinutes", "Intervals", "ParticipantId", "TrainerId", "Type" },
                values: new object[] { 1, new DateTime(2024, 5, 6, 12, 0, 0, 0, DateTimeKind.Unspecified), 30, 10, null, 1, "Running" });

            migrationBuilder.InsertData(
                table: "StrenghtTrainings",
                columns: new[] { "Id", "BodyPart", "Date", "DurationInMinutes", "ParticipantId", "Sets", "TrainerId" },
                values: new object[] { 1, "Chest", new DateTime(2024, 5, 8, 12, 0, 0, 0, DateTimeKind.Unspecified), 60, null, 21, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "CardioTrainings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Crossfits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hiits",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StrenghtTrainings",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Trainers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
