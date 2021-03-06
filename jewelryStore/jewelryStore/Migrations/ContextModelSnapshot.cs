﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using jewelryStore.Models;

namespace jewelryStore.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("jewelryStore.Models.Client", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .IsRequired();

                    b.Property<string>("name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("jewelryStore.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("amount");

                    b.Property<int>("clientId");

                    b.Property<int>("productId");

                    b.HasKey("Id");

                    b.HasIndex("clientId");

                    b.HasIndex("productId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("jewelryStore.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("description")
                        .IsRequired();

                    b.Property<int>("price");

                    b.Property<string>("title")
                        .IsRequired();

                    b.Property<int>("typeId");

                    b.HasKey("Id");

                    b.HasIndex("typeId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("jewelryStore.Models.ProductType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("typeName")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ProductType");
                });

            modelBuilder.Entity("jewelryStore.Models.Order", b =>
                {
                    b.HasOne("jewelryStore.Models.Client", "Client")
                        .WithMany("Order")
                        .HasForeignKey("clientId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("jewelryStore.Models.Product", "Product")
                        .WithMany("Order")
                        .HasForeignKey("productId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("jewelryStore.Models.Product", b =>
                {
                    b.HasOne("jewelryStore.Models.ProductType", "ProductType")
                        .WithMany("Product")
                        .HasForeignKey("typeId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
