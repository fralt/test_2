using Microsoft.EntityFrameworkCore.Migrations;

namespace Skills.Migrations
{
    public partial class postinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Options_ParentId",
                table: "Options",
                column: "ParentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Options_ParentId",
                table: "Options",
                column: "ParentId",
                principalTable: "Options",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Options_ParentId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_ParentId",
                table: "Options");
        }
    }
}
