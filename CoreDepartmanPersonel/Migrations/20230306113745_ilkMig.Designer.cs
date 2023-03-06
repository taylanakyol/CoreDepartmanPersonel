﻿// <auto-generated />
using CoreDepartmanPersonel.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CoreDepartmanPersonel.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20230306113745_ilkMig")]
    partial class ilkMig
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CoreDepartmanPersonel.Models.departmanlar", b =>
                {
                    b.Property<int>("departid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("departid"));

                    b.Property<string>("departmanad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("departid");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("CoreDepartmanPersonel.Models.personel", b =>
                {
                    b.Property<int>("perid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("perid"));

                    b.Property<string>("ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sehir")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("perid");

                    b.ToTable("personels");
                });
#pragma warning restore 612, 618
        }
    }
}
