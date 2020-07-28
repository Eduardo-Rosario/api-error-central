using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ErrorCentral.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ErrorLogs",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ocurred_at = table.Column<DateTime>(nullable: true),
                    http_status_code = table.Column<int>(nullable: false),
                    url_path = table.Column<string>(nullable: false),
                    remote_ip_host = table.Column<string>(nullable: false),
                    message = table.Column<string>(nullable: false),
                    user_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ErrorLogs", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ErrorLogs");
        }
    }
}
