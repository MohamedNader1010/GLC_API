using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GLC.EF.Migrations
{
    public partial class seedingdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //Students
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Mohamed','mohamed553q@gmail.com','Cairo',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Ahmed','Ahmed20@gmail.com','Tanta',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            migrationBuilder.Sql("insert Into Students(Name,Email,Address,Age,barcode,Gender,Level,ParentEmail,Password,Phone)\r\nValues('Mona','mona3q@gmail.com','Alex',24,00000,'Male',3,'Parent@gmail.com','Mooo','01023493643')");
            //Teachers
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Hussein',25,'hussein@gmail.com','11225','01023444440','ShibineelKom')");
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Omar',28,'omar@gmail.com','100','01000252256','Cairo')");
            migrationBuilder.Sql("insert into Teachers(Name,Age,Email,Password,Phone,School)\r\nvalues('Nader',25,'Nader@gmail.com','2561','0111556545656','SelimeZohny')");

            //Quizes
            migrationBuilder.Sql("insert into Quizes(Type,Mark,Level,Date,Duration)\r\nvalues('MCQ',100,1,'20/2/2021',4)");
            migrationBuilder.Sql("insert into Quizes(Type,Mark,Level,Date,Duration)\r\nvalues('T-F',90,2,'08/5/2021',6)");

            //Videos
            migrationBuilder.Sql("insert into Videos(Title,Level,MainSection,MainSubject,Link)\r\nvalues('C# Coure',1,'Main Section','Sub Section','http://google.com')");
            migrationBuilder.Sql("insert into Videos(Title,Level,MainSection,MainSubject,Link)\r\nvalues('C++ Coure',2,'Main Section','Sub Section','http://google.com')");


            //Groups
            migrationBuilder.Sql("insert into Groups(Day,StartDate,[From],[To],Capacity,NumOfStudents,Availability)\r\nvalues('Suterday','2021-9-12','Member1','Member2',50,40,'true')");
            migrationBuilder.Sql("insert into Groups(Day,StartDate,[From],[To],Capacity,NumOfStudents,Availability)\r\nvalues('Manday',	'2022-8-19','Member2','Member1',40,20,'true')");


            //Subjects
            migrationBuilder.Sql("insert into Subjects(Name,Level)\r\nvalues('C#',1)");
            migrationBuilder.Sql("insert into Subjects(Name,Level)\r\nvalues('SQL',2)");

            //questionCategories
            migrationBuilder.Sql("insert into questionCategories(Category)\r\nvalues('Web')");
            migrationBuilder.Sql("insert into questionCategories(Category)\r\nvalues('Front')");

            //QuestionAnswers
            migrationBuilder.Sql("insert into QuestionAnswers(QuestionAnsWer)\r\nvalues('An1')");
            migrationBuilder.Sql("insert into QuestionAnswers(QuestionAnsWer)\r\nvalues('An2')");

            //questionBanks
            migrationBuilder.Sql("insert into questionBanks(QuestionMark,Level,CorrectAnswer)\r\nvalues(20,1,'Anwser1')");
            migrationBuilder.Sql("insert into questionBanks(QuestionMark,Level,CorrectAnswer)\r\nvalues(30,2,'Anwser2')");

            //GroupChats
            migrationBuilder.Sql("insert into GroupChats(Message,level)\r\nvalues('Hi Omar',1)");
            migrationBuilder.Sql("insert into GroupChats(Message,level)\r\nvalues('Hi Nader',2)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from students where name in ('Mohmed','Ahmed','Mona')");
            migrationBuilder.Sql("delete from trachers where name in ('Hussein','Omar','Nader')");

            migrationBuilder.Sql("delete from GroupChats where level in (1,2)");
            migrationBuilder.Sql("delete from questionBanks where Level in (1,2)");
            migrationBuilder.Sql("delete from QuestionAnswers where QuestionAnsWer in ('Answer1','Answer2')");

            migrationBuilder.Sql("delete from questionCategories where Category in ('Front-End','WebDevolopment')");

            migrationBuilder.Sql("delete from Subjects where Level in  (1,2)");

            migrationBuilder.Sql("delete from Groups where Day in ('Suterday','Manday')");


            migrationBuilder.Sql("delete from Videos where Level in (1,2)");

            migrationBuilder.Sql("delete from Quizes where Level in (1,2)");
        }
    }
}
