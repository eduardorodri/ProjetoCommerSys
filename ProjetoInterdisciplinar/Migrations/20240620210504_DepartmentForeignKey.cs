using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoInterdisciplinar.Migrations
{
    public partial class DepartmentForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Department_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DepartamentoId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentId",
                table: "Vendedor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartmentId",
                table: "Vendedor",
                column: "DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Department_DepartmentId",
                table: "Vendedor",
                column: "DepartmentId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Department_DepartmentId",
                table: "Vendedor");

            migrationBuilder.DropIndex(
                name: "IX_Vendedor_DepartmentId",
                table: "Vendedor");

            migrationBuilder.DropColumn(
                name: "DepartmentId",
                table: "Vendedor");

            migrationBuilder.AddColumn<int>(
                name: "DepartamentoId",
                table: "Vendedor",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vendedor_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Department_DepartamentoId",
                table: "Vendedor",
                column: "DepartamentoId",
                principalTable: "Department",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
