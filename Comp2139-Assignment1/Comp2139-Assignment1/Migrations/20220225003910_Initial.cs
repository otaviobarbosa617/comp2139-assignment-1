﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Comp2139_Assignment1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerState = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerCountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CustomerPhone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductPrice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    TecId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TecName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TecEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TecPhone = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.TecId);
                });

            migrationBuilder.CreateTable(
                name: "Incidents",
                columns: table => new
                {
                    IncidentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    IncidentTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncidentDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TechId = table.Column<int>(type: "int", nullable: false),
                    TechnicianTecId = table.Column<int>(type: "int", nullable: true),
                    IncidentDateOpened = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IncidentDateClosed = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Incidents", x => x.IncidentId);
                    table.ForeignKey(
                        name: "FK_Incidents_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Incidents_Technicians_TechnicianTecId",
                        column: x => x.TechnicianTecId,
                        principalTable: "Technicians",
                        principalColumn: "TecId");
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "CustomerAddress", "CustomerCity", "CustomerCountry", "CustomerEmail", "CustomerFirstName", "CustomerLastName", "CustomerPhone", "CustomerState" },
                values: new object[,]
                {
                    { 1, "Test Street", "Toronto", "Canada", "janine.maeusana@georgebrown.ca", "Janine", "Usana", "666-666-6666", "Ontario" },
                    { 2, "Test Avenue", "New York", "USA", "omar.nabi@georgebrown.ca", "Omar", "Nabi", "666-666-6666", "NY" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "ProductCode", "ProductName", "ProductPrice", "ProductReleaseDate" },
                values: new object[] { 1, "1Sport", "Sport One - Team Management", "29.99", new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "Technicians",
                columns: new[] { "TecId", "TecEmail", "TecName", "TecPhone" },
                values: new object[] { 1, "otavio.pereirabarbosa@georgebrown.ca", "Otavio Barbosa", "647-562-3407" });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "IncidentDateClosed", "IncidentDateOpened", "IncidentDescription", "IncidentTitle", "ProductId", "TechId", "TechnicianTecId" },
                values: new object[] { 1, 1, null, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Create separated logins for users and admins", "Fix Login", 1, 0, null });

            migrationBuilder.InsertData(
                table: "Incidents",
                columns: new[] { "IncidentId", "CustomerId", "IncidentDateClosed", "IncidentDateOpened", "IncidentDescription", "IncidentTitle", "ProductId", "TechId", "TechnicianTecId" },
                values: new object[] { 2, 2, null, new DateTime(2022, 2, 24, 0, 0, 0, 0, DateTimeKind.Local), "Updated the whole visual", "Change overall theme", 1, 0, null });

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_CustomerId",
                table: "Incidents",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_ProductId",
                table: "Incidents",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Incidents_TechnicianTecId",
                table: "Incidents",
                column: "TechnicianTecId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Incidents");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Technicians");
        }
    }
}
