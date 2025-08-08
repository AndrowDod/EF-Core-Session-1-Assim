using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Session_1_Assim.Migrations
{
    public partial class DepartmentinstructorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Dept_Id",
                schema: "dbo",
                table: "Instructor",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "Isn_Id",
                table: "Departments",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Top_Id",
                table: "Courses",
                newName: "Top_ID");

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                schema: "dbo",
                table: "Instructor",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Top_ID",
                table: "Courses",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TopicsId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicsId",
                table: "Courses",
                column: "TopicsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicsId",
                table: "Courses",
                column: "TopicsId",
                principalTable: "Topics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructor_InstructorId",
                table: "Departments",
                column: "InstructorId",
                principalSchema: "dbo",
                principalTable: "Instructor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructor_Departments_DepartmentID",
                schema: "dbo",
                table: "Instructor",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicsId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructor_InstructorId",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructor_Departments_DepartmentID",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Instructor_DepartmentID",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorId",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicsId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseId",
                schema: "dbo",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "TopicsId",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                schema: "dbo",
                table: "Instructor",
                newName: "Dept_Id");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Departments",
                newName: "Isn_Id");

            migrationBuilder.RenameColumn(
                name: "Top_ID",
                table: "Courses",
                newName: "Top_Id");

            migrationBuilder.AlterColumn<int>(
                name: "Top_Id",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
