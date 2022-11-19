using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GLC.EF.Migrations
{
    public partial class StudentAndTeacherSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AlterColumn<Guid>(
               name: "AssignDate",
               table: "Students",
               nullable: true);
            migrationBuilder.AlterColumn<Guid>(
               name: "GroupId",
               table: "Students",
               nullable: true);
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Mohamed','mohamed553q@gmail.com','Cairo',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Ahmed','Ahmed20@gmail.com','Tanta',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Mona','mona3q@gmail.com','Alex',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Hussein',25,'hussein@gmail.com','11225','01023444440','ShibineelKom')");
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Omar',28,'omar@gmail.com','100','01000252256','Cairo')");
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Nader',25,'Nader@gmail.com','2561','0111556545656','SelimeZohny')");

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from students where name in ('Mohmed','Ahmed','Mona')");
            migrationBuilder.Sql("delete from trachers where name in ('Hussein','Omar','Nader')");
        }
    }
}
