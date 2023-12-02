﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Messenger.Persistence.Migrations;

/// <inheritdoc />
public partial class AdminEntityIsActiveField : Migration
{
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.AddColumn<bool>(
            name: "IsActive",
            table: "Admins",
            type: "bit",
            nullable: false,
            defaultValue: false
        );

        migrationBuilder.InsertData(
            table: "Admins",
            columns: new[]
            {
                "Id",
                "CreatedAt",
                "Email",
                "IsActive",
                "Login",
                "PasswordHash",
                "PasswordSalt",
                "Role"
            },
            values: new object[]
            {
                1000,
                new DateTime(2023, 11, 26, 20, 1, 39, 713, DateTimeKind.Local).AddTicks(8471),
                "admin@admin.com",
                true,
                "Admin",
                new byte[]
                {
                    21,
                    199,
                    171,
                    201,
                    166,
                    31,
                    40,
                    225,
                    20,
                    77,
                    141,
                    66,
                    119,
                    70,
                    176,
                    14,
                    101,
                    169,
                    21,
                    91,
                    164,
                    107,
                    160,
                    25,
                    213,
                    99,
                    30,
                    195,
                    14,
                    40,
                    76,
                    29,
                    34,
                    235,
                    247,
                    52,
                    181,
                    173,
                    177,
                    55,
                    218,
                    69,
                    225,
                    126,
                    8,
                    169,
                    125,
                    205,
                    98,
                    255,
                    131,
                    5,
                    83,
                    63,
                    75,
                    61,
                    244,
                    219,
                    66,
                    212,
                    156,
                    19,
                    100,
                    147
                },
                new byte[]
                {
                    165,
                    174,
                    251,
                    7,
                    56,
                    105,
                    158,
                    254,
                    34,
                    31,
                    40,
                    28,
                    88,
                    150,
                    37,
                    222,
                    253,
                    237,
                    116,
                    184,
                    141,
                    200,
                    197,
                    39,
                    219,
                    232,
                    69,
                    211,
                    24,
                    81,
                    73,
                    204,
                    215,
                    151,
                    12,
                    129,
                    205,
                    136,
                    240,
                    35,
                    92,
                    57,
                    110,
                    253,
                    227,
                    96,
                    250,
                    29,
                    205,
                    49,
                    56,
                    220,
                    225,
                    134,
                    52,
                    171,
                    201,
                    61,
                    32,
                    142,
                    106,
                    251,
                    142,
                    69,
                    112,
                    88,
                    152,
                    138,
                    205,
                    14,
                    240,
                    102,
                    6,
                    128,
                    207,
                    181,
                    172,
                    160,
                    241,
                    8,
                    211,
                    219,
                    130,
                    149,
                    190,
                    167,
                    75,
                    58,
                    215,
                    7,
                    250,
                    118,
                    242,
                    56,
                    167,
                    123,
                    54,
                    191,
                    239,
                    6,
                    242,
                    99,
                    100,
                    122,
                    51,
                    2,
                    169,
                    10,
                    29,
                    238,
                    132,
                    18,
                    22,
                    0,
                    77,
                    225,
                    75,
                    8,
                    120,
                    72,
                    77,
                    137,
                    213,
                    34,
                    254,
                    72,
                    121,
                    200
                },
                "Admin"
            }
        );
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.DeleteData(table: "Admins", keyColumn: "Id", keyValue: 1000);

        migrationBuilder.DropColumn(name: "IsActive", table: "Admins");
    }
}
