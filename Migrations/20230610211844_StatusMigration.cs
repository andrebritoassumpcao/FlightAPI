using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FlightAPI.Migrations
{
    /// <inheritdoc />
    public partial class StatusMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedAircraftId",
                table: "Flights",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StatusId",
                table: "Flights",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<float>(
                name: "CargoQuantity",
                table: "Aircrafts",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<int>(
                name: "PassangerQuantity",
                table: "Aircrafts",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "FlightStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FlightConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    FlightDelay = table.Column<bool>(type: "INTEGER", nullable: false),
                    FlightCanceled = table.Column<bool>(type: "INTEGER", nullable: false),
                    DelayReason = table.Column<string>(type: "TEXT", nullable: false),
                    NewTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CancellationReason = table.Column<string>(type: "TEXT", nullable: false),
                    Rebook = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Flights_AssignedAircraftId",
                table: "Flights",
                column: "AssignedAircraftId");

            migrationBuilder.CreateIndex(
                name: "IX_Flights_StatusId",
                table: "Flights",
                column: "StatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Aircrafts_AssignedAircraftId",
                table: "Flights",
                column: "AssignedAircraftId",
                principalTable: "Aircrafts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_FlightStatus_StatusId",
                table: "Flights",
                column: "StatusId",
                principalTable: "FlightStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Aircrafts_AssignedAircraftId",
                table: "Flights");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_FlightStatus_StatusId",
                table: "Flights");

            migrationBuilder.DropTable(
                name: "FlightStatus");

            migrationBuilder.DropIndex(
                name: "IX_Flights_AssignedAircraftId",
                table: "Flights");

            migrationBuilder.DropIndex(
                name: "IX_Flights_StatusId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "AssignedAircraftId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "StatusId",
                table: "Flights");

            migrationBuilder.DropColumn(
                name: "CargoQuantity",
                table: "Aircrafts");

            migrationBuilder.DropColumn(
                name: "PassangerQuantity",
                table: "Aircrafts");
        }
    }
}
