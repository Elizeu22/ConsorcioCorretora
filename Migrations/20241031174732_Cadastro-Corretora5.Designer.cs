﻿// <auto-generated />
using System;
using Corretora_Consorcio.DB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Corretora_Consorcio.Migrations
{
    [DbContext(typeof(CorretoraContext))]
    [Migration("20241031174732_Cadastro-Corretora5")]
    partial class CadastroCorretora5
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("Corretora_Consorcio.Model.Corretor", b =>
                {
                    b.Property<long>("IdCnpj")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<long>("IdCnpj"));

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdCnpj");

                    b.ToTable("Corretores");
                });

            modelBuilder.Entity("Corretora_Consorcio.Model.CorretoraCadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<long?>("CorretorIdCnpj")
                        .HasColumnType("bigint");

                    b.Property<long>("IdCnpj")
                        .HasColumnType("bigint");

                    b.Property<string>("bairro")
                        .HasColumnType("longtext");

                    b.Property<string>("cep")
                        .HasColumnType("longtext");

                    b.Property<string>("codigo_cvm")
                        .HasColumnType("longtext");

                    b.Property<string>("complemento")
                        .HasColumnType("longtext");

                    b.Property<string>("data_inicio_situacao")
                        .HasColumnType("longtext");

                    b.Property<string>("data_patrimonio_liquido")
                        .HasColumnType("longtext");

                    b.Property<string>("data_registro")
                        .HasColumnType("longtext");

                    b.Property<string>("email")
                        .HasColumnType("longtext");

                    b.Property<string>("logradouro")
                        .HasColumnType("longtext");

                    b.Property<string>("municipio")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_comercial")
                        .HasColumnType("longtext");

                    b.Property<string>("nome_social")
                        .HasColumnType("longtext");

                    b.Property<string>("pais")
                        .HasColumnType("longtext");

                    b.Property<string>("status")
                        .HasColumnType("longtext");

                    b.Property<string>("telefone")
                        .HasColumnType("longtext");

                    b.Property<string>("type")
                        .HasColumnType("longtext");

                    b.Property<string>("uf")
                        .HasColumnType("longtext");

                    b.Property<string>("valor_patrimonio_liquido")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CorretorIdCnpj");

                    b.ToTable("Corretoras");
                });

            modelBuilder.Entity("Corretora_Consorcio.Model.CorretoraCadastro", b =>
                {
                    b.HasOne("Corretora_Consorcio.Model.Corretor", null)
                        .WithMany("CorretoraCadastro")
                        .HasForeignKey("CorretorIdCnpj");
                });

            modelBuilder.Entity("Corretora_Consorcio.Model.Corretor", b =>
                {
                    b.Navigation("CorretoraCadastro");
                });
#pragma warning restore 612, 618
        }
    }
}
