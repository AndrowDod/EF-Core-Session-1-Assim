using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Session_1_Assim.Migrations
{
    public partial class StudentcourseRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Department",
                table: "Department");

            migrationBuilder.DropColumn(
                name: "Dept_Id",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "Department",
                newName: "Departments");

            migrationBuilder.RenameColumn(
                name: "Stud_id",
                table: "Stud_Courses",
                newName: "CourseId");

            migrationBuilder.RenameColumn(
                name: "Dept_ID",
                table: "Stud_Courses",
                newName: "StudentID");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "St_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Departments",
                table: "Departments",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Stud_Courses_CourseId",
                table: "Stud_Courses",
                column: "CourseId");

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Stud_Courses_Students_StudentID",
                table: "Stud_Courses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "St_Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Courses_CourseId",
                table: "Stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Stud_Courses_Students_StudentID",
                table: "Stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Stud_Courses_CourseId",
                table: "Stud_Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Departments",
                table: "Departments");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "Departments",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "CourseId",
                table: "Stud_Courses",
                newName: "Stud_id");

            migrationBuilder.RenameColumn(
                name: "StudentID",
                table: "Stud_Courses",
                newName: "Dept_ID");

            migrationBuilder.AlterColumn<int>(
                name: "Grade",
                table: "Stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Dept_Id",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "St_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Department",
                table: "Department",
                column: "Id");
        }
    }
}
