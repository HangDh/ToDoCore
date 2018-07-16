using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ToDoCore.Data.Migrations
{
    public partial class AddItems : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IsDone = table.Column<bool>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    DueAt = table.Column<DateTime>(nullable: false),
                    StartAt = table.Column<DateTime>(nullable: false),
                    StopAt = table.Column<DateTime>(nullable: false),
                    TimeSpend = table.Column<TimeSpan>(nullable: false),
                    TimeRem = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
