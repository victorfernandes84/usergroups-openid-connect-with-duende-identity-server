﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using idsserver;

namespace idsserver.Migrations.MysqlApplicationDb
{
    [DbContext(typeof(MysqlApplicationDbContext))]
    partial class MysqlApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.5");

            modelBuilder.Entity("idsserver.UserAuth", b =>
                {
                    b.Property<string>("UserAuthId")
                        .HasColumnType("TEXT");

                    b.Property<string>("AuthenticationType")
                        .HasColumnType("TEXT");

                    b.Property<string>("DisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Has2Fa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("HashedPassword")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAuthenticated")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("TwoFaToken")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.HasKey("UserAuthId");

                    b.ToTable("UserAuth");
                });
#pragma warning restore 612, 618
        }
    }
}
