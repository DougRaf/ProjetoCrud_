﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoCrud_.Data;

#nullable disable

namespace ProjetoCrud_.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220516003035_Criacao-add")]
    partial class Criacaoadd
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ProjetoCrud_.Models.Avaliacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Avaliação")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Avaliacao");

                    b.HasKey("Id");

                    b.ToTable("Avaliacao");
                });

            modelBuilder.Entity("ProjetoCrud_.Models.Operadoras", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Operadora")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Operadora");

                    b.HasKey("Id");

                    b.ToTable("Operadoras");
                });

            modelBuilder.Entity("ProjetoCrud_.Models.Usuarios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Endereco");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("Nome");

                    b.HasKey("Id");

                    b.ToTable("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
