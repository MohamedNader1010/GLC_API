﻿// <auto-generated />
using System;
using GLC.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace GLC_API.Migrations
{
    [DbContext(typeof(GLCDbContext))]
    [Migration("20221117164639_V1")]
    partial class V1
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
                    b.Property<int>("StId")
                        .HasColumnType("int");

                    b.Property<int>("GroupChatId")
                        .HasColumnType("int");

                    b.Property<int>("GroupId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("StId", "GroupChatId", "GroupId", "TeacherId");

                    b.HasIndex("GroupChatId");

                    b.ToTable("ChatingDetails");
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<bool>("Availability")
                        .HasColumnType("bit");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("From")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfStudents")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("GLC.Cores.Models.GroupChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("level")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GroupChats");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionAnswer", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.Property<string>("QuestionAnsWer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QuestionId");

                    b.HasIndex("BankId");

                    b.ToTable("QuestionAnswers");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionBank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("QuestionMark")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("questionBanks");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("QuestionBankId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("QuestionBankId");

                    b.ToTable("questionCategories");
                });

            modelBuilder.Entity("GLC.Cores.Models.Quize", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Date")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.ToTable("Quizes");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuizeQuestion", b =>
                {
                    b.Property<int>("QuizeId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionID")
                        .HasColumnType("int");

                    b.Property<int>("BankId")
                        .HasColumnType("int");

                    b.HasKey("QuizeId", "QuestionID");

                    b.HasIndex("BankId");

                    b.ToTable("QuizeQuestions");
                });

            modelBuilder.Entity("GLC.Cores.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<int>("Email")
                        .HasColumnType("int");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("ImageFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<int>("Name")
                        .HasColumnType("int");

                    b.Property<string>("ParentEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parcode")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("GroupID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("GLC.Cores.Models.StudentQuizeQuestionBank", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionBankId")
                        .HasColumnType("int");

                    b.Property<int>("QuizeId")
                        .HasColumnType("int");

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentId", "QuestionBankId", "QuizeId");

                    b.ToTable("StudentQuizeQuestionBanks");
                });

            modelBuilder.Entity("GLC.Cores.Models.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TeacherId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("GLC.Cores.Models.Teacher", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("ConfirmPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("School")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("GLC.Cores.Models.Video", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("TeacherId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.HasIndex("TeacherId");

                    b.ToTable("Videos");
                });

            modelBuilder.Entity("GLC.Cores.Models.ChatingDetails", b =>
                {
                    b.HasOne("GLC.Cores.Models.GroupChat", null)
                        .WithMany("Chats")
                        .HasForeignKey("GroupChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.HasOne("GLC.Cores.Models.Subject", "Subject")
                        .WithMany("Groups")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionAnswer", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "QuestionBank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionBank");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuestionCategory", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "QuestionBank")
                        .WithMany()
                        .HasForeignKey("QuestionBankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("QuestionBank");
                });

            modelBuilder.Entity("GLC.Cores.Models.Quize", b =>
                {
                    b.HasOne("GLC.Cores.Models.Student", "Student")
                        .WithMany("Quizes")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("GLC.Cores.Models.QuizeQuestion", b =>
                {
                    b.HasOne("GLC.Cores.Models.QuestionBank", "Question")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GLC.Cores.Models.Quize", null)
                        .WithMany("QuizeQuestions")
                        .HasForeignKey("QuizeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Question");
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
                    b.HasOne("GLC.Cores.Models.Subject", null)
                        .WithMany("videos")
                        .HasForeignKey("SubjectId");

                    b.HasOne("GLC.Cores.Models.Teacher", "Teacher")
                        .WithMany("videos")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("GLC.Cores.Models.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("GLC.Cores.Models.GroupChat", b =>
                {
                    b.Navigation("Chats");
                });

            modelBuilder.Entity("GLC.Cores.Models.Quize", b =>
                {
                    b.Navigation("QuizeQuestions");
                });

            modelBuilder.Entity("GLC.Cores.Models.Student", b =>
                {
                    b.Navigation("Quizes");
                });

            modelBuilder.Entity("GLC.Cores.Models.Subject", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("videos");
                });

            modelBuilder.Entity("GLC.Cores.Models.Teacher", b =>
                {
                    b.Navigation("subjects");

                    b.Navigation("videos");
                });
#pragma warning restore 612, 618
        }
    }
}
