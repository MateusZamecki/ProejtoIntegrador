﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoIntegradorMVC.Models.ContextoDb;

namespace ProjetoIntegradorMVC.Migrations.Historico
{
    [DbContext(typeof(Contexto))]
    [Migration("20210823201914_addFavoritos")]
    partial class addFavoritos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Agendamentos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("PrestadorDeServicoId")
                        .HasColumnType("int");

                    b.Property<int?>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.HasIndex("PrestadorDeServicoId");

                    b.HasIndex("ServicoId");

                    b.ToTable("Agendamentos");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Favoritos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("ClienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Favoritos");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Servico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("PrestadorDeServicoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PrestadorDeServicoId");

                    b.ToTable("Servico");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Usuarios.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Usuarios.PrestadorDeServico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FavoritosId")
                        .HasColumnType("int");

                    b.Property<string>("Localizacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FavoritosId");

                    b.ToTable("PrestadorDeServico");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Agendamentos", b =>
                {
                    b.HasOne("ProjetoIntegradorMVC.Models.Usuarios.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.HasOne("ProjetoIntegradorMVC.Models.Usuarios.PrestadorDeServico", null)
                        .WithMany("Agendamentos")
                        .HasForeignKey("PrestadorDeServicoId");

                    b.HasOne("ProjetoIntegradorMVC.Models.Operacoes.Servico", "Servico")
                        .WithMany()
                        .HasForeignKey("ServicoId");

                    b.Navigation("Cliente");

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Favoritos", b =>
                {
                    b.HasOne("ProjetoIntegradorMVC.Models.Usuarios.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId");

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Servico", b =>
                {
                    b.HasOne("ProjetoIntegradorMVC.Models.Usuarios.PrestadorDeServico", null)
                        .WithMany("Servicos")
                        .HasForeignKey("PrestadorDeServicoId");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Usuarios.PrestadorDeServico", b =>
                {
                    b.HasOne("ProjetoIntegradorMVC.Models.Operacoes.Favoritos", null)
                        .WithMany("PrestadorDeServicos")
                        .HasForeignKey("FavoritosId");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Operacoes.Favoritos", b =>
                {
                    b.Navigation("PrestadorDeServicos");
                });

            modelBuilder.Entity("ProjetoIntegradorMVC.Models.Usuarios.PrestadorDeServico", b =>
                {
                    b.Navigation("Agendamentos");

                    b.Navigation("Servicos");
                });
#pragma warning restore 612, 618
        }
    }
}
