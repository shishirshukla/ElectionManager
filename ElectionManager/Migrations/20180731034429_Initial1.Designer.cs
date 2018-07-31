﻿// <auto-generated />
using System;
using ElectionManager.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ElectionManager.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20180731034429_Initial1")]
    partial class Initial1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ElectionManager.Models.Circle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CircleType");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<string>("Description");

                    b.Property<string>("FullName");

                    b.Property<int>("IntSetting1");

                    b.Property<int>("ParentCircle");

                    b.Property<string>("Setting1");

                    b.Property<string>("Setting2");

                    b.HasKey("Id");

                    b.ToTable("Circle");
                });

            modelBuilder.Entity("ElectionManager.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CommentText");

                    b.Property<DateTime?>("Created");

                    b.Property<int>("RelatedId");

                    b.Property<string>("RelatedType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("ElectionManager.Models.Option", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MoveToQuestionId");

                    b.Property<string>("OptionText");

                    b.Property<int>("QuestionId");

                    b.Property<bool>("isAnswered");

                    b.Property<bool>("isCorrect");

                    b.HasKey("Id");

                    b.HasIndex("QuestionId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("ElectionManager.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<string>("PostAdditionalInfo1");

                    b.Property<string>("PostAdditionalInfo2");

                    b.Property<string>("PostAdditionalInfo3");

                    b.Property<string>("PostAdditionalInfo4");

                    b.Property<string>("PostLink");

                    b.Property<string>("PostStatus");

                    b.Property<string>("PostText");

                    b.Property<string>("PostType");

                    b.Property<int>("RelatedId");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("ElectionManager.Models.PostInCircle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CircleId");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<int>("IntSetting1");

                    b.Property<int>("PostId");

                    b.Property<string>("Setting1");

                    b.Property<string>("Setting2");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("PostInCircles");
                });

            modelBuilder.Entity("ElectionManager.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<int>("QuestionInfo3");

                    b.Property<int>("QuestionInfo4");

                    b.Property<string>("QuestionNotValidProfile");

                    b.Property<string>("QuestionStatus");

                    b.Property<string>("QuestionText");

                    b.Property<string>("QuestionValidProfile");

                    b.Property<int>("SurveyId");

                    b.HasKey("Id");

                    b.HasIndex("SurveyId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("ElectionManager.Models.QuestionResponse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CircleId");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<string>("EpicNumber");

                    b.Property<string>("GeoLocation");

                    b.Property<int>("IntSetting1");

                    b.Property<int>("OptionId");

                    b.Property<int>("QuestionId");

                    b.Property<string>("Response");

                    b.Property<string>("ResponseId");

                    b.Property<string>("ResponserName");

                    b.Property<string>("ResponserNumber");

                    b.Property<string>("ResponserProfile");

                    b.Property<string>("Setting1");

                    b.Property<int>("SurveyId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("QuestionResponses");
                });

            modelBuilder.Entity("ElectionManager.Models.Reaction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<string>("ReactionType");

                    b.Property<int>("RelatedId");

                    b.Property<string>("RelatedType");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Reactions");
                });

            modelBuilder.Entity("ElectionManager.Models.Survey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Created");

                    b.Property<int>("IntSetting1");

                    b.Property<int>("IntSetting2");

                    b.Property<string>("StrSetting1");

                    b.Property<string>("StrSetting2");

                    b.Property<string>("SurveyName");

                    b.Property<int>("UserId");

                    b.Property<DateTime?>("ValidFromDate");

                    b.Property<DateTime?>("ValidToDate");

                    b.HasKey("Id");

                    b.ToTable("Surveys");
                });

            modelBuilder.Entity("ElectionManager.Models.SurveyInCircle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CircleId");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<int>("IntSetting1");

                    b.Property<string>("Setting1");

                    b.Property<string>("Setting2");

                    b.Property<int>("SurveyId");

                    b.HasKey("Id");

                    b.ToTable("SurveyInCircles");
                });

            modelBuilder.Entity("ElectionManager.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(36);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Bio");

                    b.Property<int>("CapabilityLevel");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("DateofBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName");

                    b.Property<int>("GroupId");

                    b.Property<DateTime?>("Joined");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("MappedDevice");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("NotificationId");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("ProfilePicture");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("ElectionManager.Models.UserInCircle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CircleId");

                    b.Property<DateTime?>("Created");

                    b.Property<DateTime?>("DateSetting");

                    b.Property<int>("IntSetting1");

                    b.Property<string>("Setting1");

                    b.Property<string>("Setting2");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserInCircle");
                });

            modelBuilder.Entity("ElectionManager.Models.Voter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age");

                    b.Property<string>("Bio");

                    b.Property<string>("Caste");

                    b.Property<string>("Category");

                    b.Property<int>("CircleId");

                    b.Property<string>("EpicNumber");

                    b.Property<string>("FullName");

                    b.Property<string>("Gender");

                    b.Property<string>("MobileNumber");

                    b.Property<string>("Religion");

                    b.Property<string>("Status");

                    b.Property<bool>("isInfluencer");

                    b.HasKey("Id");

                    b.HasIndex("CircleId");

                    b.ToTable("Voters");
                });

            modelBuilder.Entity("ElectionManager.Models.ZoneInfluencer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio");

                    b.Property<string>("Category");

                    b.Property<int>("CircleId");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("FullName");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.HasIndex("CircleId");

                    b.ToTable("ZoneInfluencers");
                });

            modelBuilder.Entity("ElectionManager.Models.ZoneIssue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio");

                    b.Property<int>("CircleId");

                    b.HasKey("Id");

                    b.HasIndex("CircleId");

                    b.ToTable("ZoneIssues");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ElectionManager.Models.Option", b =>
                {
                    b.HasOne("ElectionManager.Models.Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectionManager.Models.Question", b =>
                {
                    b.HasOne("ElectionManager.Models.Survey")
                        .WithMany("Questions")
                        .HasForeignKey("SurveyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectionManager.Models.Voter", b =>
                {
                    b.HasOne("ElectionManager.Models.Circle")
                        .WithMany("voters")
                        .HasForeignKey("CircleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectionManager.Models.ZoneInfluencer", b =>
                {
                    b.HasOne("ElectionManager.Models.Circle")
                        .WithMany("Influencers")
                        .HasForeignKey("CircleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ElectionManager.Models.ZoneIssue", b =>
                {
                    b.HasOne("ElectionManager.Models.Circle")
                        .WithMany("Issues")
                        .HasForeignKey("CircleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ElectionManager.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ElectionManager.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ElectionManager.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ElectionManager.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}