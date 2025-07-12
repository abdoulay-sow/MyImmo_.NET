using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Abdoulaye.MyImmo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "myimmo_t_societes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    TenantId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Adresse = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myimmo_t_societes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "myimmo_t_tenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ConnectionString = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myimmo_t_tenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "myimmo_t_agences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    SocieteId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Adresse = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myimmo_t_agences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_myimmo_t_agences_myimmo_t_societes_SocieteId",
                        column: x => x.SocieteId,
                        principalTable: "myimmo_t_societes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "myimmo_t_agents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AgenceId = table.Column<Guid>(type: "uuid", nullable: false),
                    Nom = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    Telephone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_myimmo_t_agents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_myimmo_t_agents_myimmo_t_agences_AgenceId",
                        column: x => x.AgenceId,
                        principalTable: "myimmo_t_agences",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_myimmo_t_agences_SocieteId",
                table: "myimmo_t_agences",
                column: "SocieteId");

            migrationBuilder.CreateIndex(
                name: "IX_myimmo_t_agents_AgenceId",
                table: "myimmo_t_agents",
                column: "AgenceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "myimmo_t_agents");

            migrationBuilder.DropTable(
                name: "myimmo_t_tenants");

            migrationBuilder.DropTable(
                name: "myimmo_t_agences");

            migrationBuilder.DropTable(
                name: "myimmo_t_societes");
        }
    }
}
