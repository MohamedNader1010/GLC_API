﻿// <auto-generated />
using System;
using GLC.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GLC.EF.Migrations
{
    [DbContext(typeof(GLCDbContext))]
    [Migration("20221119175822_DBCreation")]
    partial class DBCreation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("GLC.Cores.Models.ChatingDetails", b =>
                {
                    b.Property<Guid?>("StId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupChatId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StId", "GroupChatId", "GroupId", "TeacherId");

                    b.HasIndex("GroupChatId");

                    b.HasIndex("GroupId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ChatingDetails");
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.Property<Guid>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfStudents")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("SubjectId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherID");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("GLC.Cores.Models.GroupChat", b =>
                {
                    b.Property<Guid>("GroupChatId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.HasKey("GroupChatId");

                    b.ToTable("GroupChats");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionAnswer", b =>
                {
                    b.Property<Guid>("QuestionAnswerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("QuestionAnsWer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QuestionAnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionBank", b =>
                {
                    b.Property<Guid>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("CorrectAnswer")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("QuestionMark")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.ToTable("questionBanks");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionCategory", b =>
                {
                    b.Property<Guid>("QuestionCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<Guid?>("QuestionBankId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("QuestionCategoryId");

                    b.HasIndex("QuestionBankId");

                    b.ToTable("questionCategories");
                });

            modelBuilder.Entity("GLC.Cores.Models.Quiz", b =>
                {
                    b.Property<Guid>("QuizId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<Guid?>("StudentId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("SubjectID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuizId");

                    b.HasIndex("StudentId");

                    b.HasIndex("SubjectID");

                    b.ToTable("Quizes");
                });

            modelBuilder.Entity("GLC.Cores.Models.Student", b =>
                {
                    b.Property<Guid>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<string>("Address")
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<DateTime>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("GroupID")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ParentEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("barcode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId");

                    b.HasIndex("GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GLC.Cores.Models.StudentQuizeQuestionBank", b =>
                {
                    b.Property<Guid?>("StudentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QuizeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("QuestionId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("StudentId", "QuizeId", "QuestionId");

                    b.HasIndex("QuestionId");

                    b.HasIndex("QuizeId");

                    b.ToTable("QuizeQuestions");
                });

            modelBuilder.Entity("GLC.Cores.Models.Subject", b =>
                {
                    b.Property<Guid>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<Guid?>("TeacherId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("GLC.Cores.Models.Teacher", b =>
                {
                    b.Property<Guid>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int?>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PhotoPath")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("School")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("GLC.Cores.Models.Video", b =>
                {
                    b.Property<Guid>("VideoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier")
                        .HasDefaultValueSql("newsequentialid()");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainSection")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MainSubject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("SubjectId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("TeacherId")
                        .IsRequired()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VideoId");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("GLC.Cores.Models.ChatingDetails", b =>
                {
                    b.HasOne("GLC.Cores.Models.GroupChat", "GroupChat")
                        .WithMany("Chats")
                        .HasForeignKey("GroupChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Group", "group")
                        .WithMany("ChatingDetails")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Student", "Student")
                        .WithMany("ChatingDetails")
                        .HasForeignKey("StId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Teacher", "Teacher")
                        .WithMany("ChatingDetails")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("GroupChat");

                    b.Navigation("Student");

                    b.Navigation("Teacher");

                    b.Navigation("group");
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.HasOne("GLC.Cores.Models.Subject", "Subject")
                        .WithMany("Groups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Teacher", "Teacher")
                        .WithMany()
                        .HasForeignKey("TeacherID");

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionAnswer", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "QuestionBank")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("QuestionBank");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionCategory", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "QuestionBank")
                        .WithMany("QuestionCategory")
                        .HasForeignKey("QuestionBankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionBank");
                });

            modelBuilder.Entity("GLC.Cores.Models.Quiz", b =>
                {
                    b.HasOne("GLC.Cores.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Subject", "Subject")
                        .WithMany("Quizes")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GLC.Cores.Models.Student", b =>
                {
                    b.HasOne("GLC.Cores.Models.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");
                });

            modelBuilder.Entity("GLC.Cores.Models.StudentQuizeQuestionBank", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "Question")
                        .WithMany("QuizeQuestion")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Quiz", "Quize")
                        .WithMany()
                        .HasForeignKey("QuizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Student", "Student")
                        .WithMany("Quizes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");

                    b.Navigation("Quize");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GLC.Cores.Models.Subject", b =>
                {
                    b.HasOne("GLC.Cores.Models.Teacher", "Teacher")
                        .WithMany("subjects")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("GLC.Cores.Models.Video", b =>
                {
                    b.HasOne("GLC.Cores.Models.Subject", "Subject")
                        .WithMany("videos")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Teacher", "Teacher")
                        .WithMany("videos")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.Navigation("ChatingDetails");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("GLC.Cores.Models.GroupChat", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionBank", b =>
                {
                    b.Navigation("QuestionAnswers");

                    b.Navigation("QuestionCategory");

                    b.Navigation("QuizeQuestion");
                });

            modelBuilder.Entity("GLC.Cores.Models.Student", b =>
                {
                    b.Navigation("ChatingDetails");

                    b.Navigation("Quizes");
                });

            modelBuilder.Entity("GLC.Cores.Models.Subject", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("Quizes");

                    b.Navigation("videos");
                });

            modelBuilder.Entity("GLC.Cores.Models.Teacher", b =>
                {
                    b.Navigation("ChatingDetails");

                    b.Navigation("subjects");

                    b.Navigation("videos");
                });
#pragma warning restore 612, 618
        }
    }
}