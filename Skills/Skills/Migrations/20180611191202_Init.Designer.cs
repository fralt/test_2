﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Skills;

namespace Skills.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20180611191202_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Skills.Option", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<Guid?>("ParentId");

                    b.Property<Guid?>("SkillId");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.HasIndex("SkillId");

                    b.ToTable("Options");
                });

            modelBuilder.Entity("Skills.Skill", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Skills.Option", b =>
                {
                    b.HasOne("Skills.Skill")
                        .WithMany("Options")
                        .HasForeignKey("SkillId");
                });
#pragma warning restore 612, 618
        }
    }
}
