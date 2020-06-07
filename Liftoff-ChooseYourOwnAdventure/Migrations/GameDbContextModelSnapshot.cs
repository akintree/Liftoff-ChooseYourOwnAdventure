﻿// <auto-generated />
using System;
using Liftoff_ChooseYourOwnAdventure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Liftoff_ChooseYourOwnAdventure.Migrations
{
    [DbContext(typeof(GameDbContext))]
    partial class GameDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Liftoff_ChooseYourOwnAdventure.Models.Game", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("GameID")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("GameID");

                    b.ToTable("Games");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Game");
                });

            modelBuilder.Entity("Liftoff_ChooseYourOwnAdventure.Models.Storyboard", b =>
                {
                    b.HasBaseType("Liftoff_ChooseYourOwnAdventure.Models.Game");

                    b.Property<int>("NextStoryboardID1")
                        .HasColumnType("int");

                    b.Property<int>("NextStoryboardID2")
                        .HasColumnType("int");

                    b.Property<string>("Option1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Option2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Story")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StoryboardID")
                        .HasColumnType("int");

                    b.HasIndex("StoryboardID");

                    b.HasDiscriminator().HasValue("Storyboard");
                });

            modelBuilder.Entity("Liftoff_ChooseYourOwnAdventure.Models.Game", b =>
                {
                    b.HasOne("Liftoff_ChooseYourOwnAdventure.Models.Game", null)
                        .WithMany("Games")
                        .HasForeignKey("GameID");
                });

            modelBuilder.Entity("Liftoff_ChooseYourOwnAdventure.Models.Storyboard", b =>
                {
                    b.HasOne("Liftoff_ChooseYourOwnAdventure.Models.Storyboard", null)
                        .WithMany("Storyboards")
                        .HasForeignKey("StoryboardID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
