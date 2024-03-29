﻿// <auto-generated />
using System;
using Api.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Migrations
{
    [DbContext(typeof(TravelContext))]
    [Migration("20210702183742_01Initial")]
    partial class _01Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Api.Entities.Travel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<DateTime>("DateRegister")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Destiny")
                        .IsRequired()
                        .HasColumnType("character varying(100)")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Travel");
                });
#pragma warning restore 612, 618
        }
    }
}
