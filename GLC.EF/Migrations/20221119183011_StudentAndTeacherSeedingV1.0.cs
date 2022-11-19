using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GLC.EF.Migrations
{
    public partial class StudentAndTeacherSeedingV10 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,AssignDate,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Mona','mona3q@gmail.com','Alex',24,'11/11/2022',00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
