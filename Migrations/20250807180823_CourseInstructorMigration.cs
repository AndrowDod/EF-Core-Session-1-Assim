using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Core_Session_1_Assim.Migrations
{
    public partial class CourseInstructorMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.AlterColumn<decimal>(
                name: "Evaluate",
                table: "Course_Inst",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldDefaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Inst",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "InstructorId",
                table: "Course_Inst",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Inst_Id", "Course_Id" });

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Inst_InstructorId",
                table: "Course_Inst",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Courses_CourseID",
                table: "Course_Inst",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorId",
                table: "Course_Inst",
                column: "InstructorId",
                principalSchema: "dbo",
                principalTable: "Instructor",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Courses_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Inst_Instructor_InstructorId",
                table: "Course_Inst");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_CourseID",
                table: "Course_Inst");

            migrationBuilder.DropIndex(
                name: "IX_Course_Inst_InstructorId",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Inst");

            migrationBuilder.DropColumn(
                name: "InstructorId",
                table: "Course_Inst");

            migrationBuilder.AlterColumn<decimal>(
                name: "Evaluate",
                table: "Course_Inst",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Course_Inst",
                table: "Course_Inst",
                columns: new[] { "Course_Id", "Inst_Id" });
        }
    }
}
