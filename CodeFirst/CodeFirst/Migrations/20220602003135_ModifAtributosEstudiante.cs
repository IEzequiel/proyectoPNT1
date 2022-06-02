using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirst.Migrations
{
    public partial class ModifAtributosEstudiante : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Cursos_CursoId",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "IdCurso",
                table: "Estudiantes",
                newName: "HobbyFavorito");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Estudiantes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Cursos_CursoId",
                table: "Estudiantes",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estudiantes_Cursos_CursoId",
                table: "Estudiantes");

            migrationBuilder.RenameColumn(
                name: "HobbyFavorito",
                table: "Estudiantes",
                newName: "IdCurso");

            migrationBuilder.AlterColumn<int>(
                name: "CursoId",
                table: "Estudiantes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estudiantes_Cursos_CursoId",
                table: "Estudiantes",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }
    }
}
