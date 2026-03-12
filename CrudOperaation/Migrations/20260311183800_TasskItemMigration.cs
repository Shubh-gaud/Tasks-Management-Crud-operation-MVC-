using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CrudOperaation.Migrations
{
    /// <inheritdoc />
    public partial class TasskItemMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TaskTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskDueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TaskStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskRemarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedByName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    LastUpdatedByName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedById = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");
        }
    }
}
