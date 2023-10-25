using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    public partial class test4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCoupons_Students_StudentId",
                table: "FoodCoupons");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Students",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodCoupons",
                table: "FoodCoupons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Classes",
                table: "Classes");

            migrationBuilder.RenameTable(
                name: "Teachers",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "Students",
                newName: "Student");

            migrationBuilder.RenameTable(
                name: "FoodCoupons",
                newName: "FoodCoupon");

            migrationBuilder.RenameTable(
                name: "Classes",
                newName: "Class");

            migrationBuilder.RenameIndex(
                name: "IX_Students_ClassId",
                table: "Student",
                newName: "IX_Student_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCoupons_StudentId",
                table: "FoodCoupon",
                newName: "IX_FoodCoupon_StudentId");

            migrationBuilder.AddColumn<Guid>(
                name: "TeacherId",
                table: "Class",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Student",
                table: "Student",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodCoupon",
                table: "FoodCoupon",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Class",
                table: "Class",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Class_TeacherId",
                table: "Class",
                column: "TeacherId");

            migrationBuilder.AddForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                table: "Class",
                column: "TeacherId",
                principalTable: "Teacher",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCoupon_Student_StudentId",
                table: "FoodCoupon",
                column: "StudentId",
                principalTable: "Student",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Student_Class_ClassId",
                table: "Student",
                column: "ClassId",
                principalTable: "Class",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Class_Teacher_TeacherId",
                table: "Class");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodCoupon_Student_StudentId",
                table: "FoodCoupon");

            migrationBuilder.DropForeignKey(
                name: "FK_Student_Class_ClassId",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Teacher",
                table: "Teacher");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Student",
                table: "Student");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodCoupon",
                table: "FoodCoupon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Class",
                table: "Class");

            migrationBuilder.DropIndex(
                name: "IX_Class_TeacherId",
                table: "Class");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "Class");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teachers");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Students");

            migrationBuilder.RenameTable(
                name: "FoodCoupon",
                newName: "FoodCoupons");

            migrationBuilder.RenameTable(
                name: "Class",
                newName: "Classes");

            migrationBuilder.RenameIndex(
                name: "IX_Student_ClassId",
                table: "Students",
                newName: "IX_Students_ClassId");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCoupon_StudentId",
                table: "FoodCoupons",
                newName: "IX_FoodCoupons_StudentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Teachers",
                table: "Teachers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Students",
                table: "Students",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodCoupons",
                table: "FoodCoupons",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Classes",
                table: "Classes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCoupons_Students_StudentId",
                table: "FoodCoupons",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Classes_ClassId",
                table: "Students",
                column: "ClassId",
                principalTable: "Classes",
                principalColumn: "Id");
        }
    }
}
