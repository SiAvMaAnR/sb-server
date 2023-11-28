﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messenger.Persistence.Migrations;

/// <inheritdoc />
public partial class UserEntityBirthdayField : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<DateOnly>(
            name: "Birthday",
            table: "Users",
            type: "date",
            nullable: true,
            oldClrType: typeof(DateTime),
            oldType: "datetime2",
            oldNullable: true);

        migrationBuilder.UpdateData(
            table: "Admins",
            keyColumn: "Id",
            keyValue: 1000,
            columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
            values: new object[] { new DateTime(2023, 11, 28, 22, 30, 15, 391, DateTimeKind.Local).AddTicks(2258), new byte[] { 182, 211, 225, 246, 103, 99, 196, 180, 240, 0, 175, 234, 28, 51, 142, 73, 74, 211, 97, 105, 202, 181, 47, 209, 159, 151, 66, 8, 173, 55, 225, 243, 67, 34, 127, 162, 168, 10, 114, 27, 4, 88, 66, 15, 242, 205, 179, 121, 198, 149, 204, 106, 210, 75, 243, 165, 198, 92, 129, 166, 108, 206, 236, 64 }, new byte[] { 96, 99, 242, 167, 79, 92, 166, 41, 217, 80, 39, 194, 62, 243, 113, 249, 217, 200, 35, 43, 143, 237, 231, 48, 56, 117, 25, 196, 175, 231, 166, 228, 82, 103, 160, 152, 145, 159, 35, 244, 97, 150, 169, 12, 189, 149, 121, 164, 33, 15, 108, 34, 137, 78, 244, 63, 79, 21, 78, 184, 60, 242, 233, 173, 4, 158, 1, 192, 212, 2, 92, 39, 30, 154, 141, 220, 88, 254, 112, 204, 19, 95, 35, 130, 33, 107, 178, 107, 165, 221, 209, 12, 6, 222, 223, 181, 164, 164, 205, 77, 48, 0, 45, 99, 11, 118, 41, 148, 122, 195, 127, 56, 252, 132, 112, 59, 70, 218, 97, 135, 111, 112, 148, 200, 129, 59, 229, 33 } });
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AlterColumn<DateTime>(
            name: "Birthday",
            table: "Users",
            type: "datetime2",
            nullable: true,
            oldClrType: typeof(DateOnly),
            oldType: "date",
            oldNullable: true);

        migrationBuilder.UpdateData(
            table: "Admins",
            keyColumn: "Id",
            keyValue: 1000,
            columns: new[] { "CreatedAt", "PasswordHash", "PasswordSalt" },
            values: new object[] { new DateTime(2023, 11, 26, 20, 1, 39, 713, DateTimeKind.Local).AddTicks(8471), new byte[] { 21, 199, 171, 201, 166, 31, 40, 225, 20, 77, 141, 66, 119, 70, 176, 14, 101, 169, 21, 91, 164, 107, 160, 25, 213, 99, 30, 195, 14, 40, 76, 29, 34, 235, 247, 52, 181, 173, 177, 55, 218, 69, 225, 126, 8, 169, 125, 205, 98, 255, 131, 5, 83, 63, 75, 61, 244, 219, 66, 212, 156, 19, 100, 147 }, new byte[] { 165, 174, 251, 7, 56, 105, 158, 254, 34, 31, 40, 28, 88, 150, 37, 222, 253, 237, 116, 184, 141, 200, 197, 39, 219, 232, 69, 211, 24, 81, 73, 204, 215, 151, 12, 129, 205, 136, 240, 35, 92, 57, 110, 253, 227, 96, 250, 29, 205, 49, 56, 220, 225, 134, 52, 171, 201, 61, 32, 142, 106, 251, 142, 69, 112, 88, 152, 138, 205, 14, 240, 102, 6, 128, 207, 181, 172, 160, 241, 8, 211, 219, 130, 149, 190, 167, 75, 58, 215, 7, 250, 118, 242, 56, 167, 123, 54, 191, 239, 6, 242, 99, 100, 122, 51, 2, 169, 10, 29, 238, 132, 18, 22, 0, 77, 225, 75, 8, 120, 72, 77, 137, 213, 34, 254, 72, 121, 200 } });
    }
}