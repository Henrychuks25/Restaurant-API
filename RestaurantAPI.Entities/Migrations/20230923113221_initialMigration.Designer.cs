﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantAPI.Entities.ModelContexts;

#nullable disable

namespace RestaurantAPI.Entities.Migrations
{
    [DbContext(typeof(Contexts))]
    [Migration("20230923113221_initialMigration")]
    partial class initialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("OrderHistory", b =>
                {
                    b.Property<Guid>("TId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("t_id");

                    b.Property<Guid>("OId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("o_id");

                    b.HasKey("TId", "OId")
                        .HasName("order_history_PK");

                    b.HasIndex("OId");

                    b.ToTable("Order_History", (string)null);
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.BillDetail", b =>
                {
                    b.Property<decimal?>("Bill")
                        .HasColumnType("decimal(38,2)")
                        .HasColumnName("BILL");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.ToView("bill_detail");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Booking", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<Guid>("MenuTableId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("MenuTableId");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date")
                        .HasColumnName("Date");

                    b.Property<TimeSpan?>("Hour")
                        .HasColumnType("time")
                        .HasColumnName("Hour");

                    b.HasKey("CustomerId", "MenuTableId")
                        .HasName("booking_cid_tid_pk");

                    b.HasIndex("MenuTableId");

                    b.ToTable("Booking", (string)null);
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Customer", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Address");

                    b.Property<string>("Name")
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Name");

                    b.Property<string>("Occupation")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Occupation");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)")
                        .HasColumnName("Phone");

                    b.HasKey("Id")
                        .HasName("customers_c_id_pk");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.EmpList", b =>
                {
                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("ADDRESS");

                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("NAME");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("PHONE");

                    b.ToView("EMP_LIST");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Employee", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)")
                        .HasColumnName("Address");

                    b.Property<Guid>("JobId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("JobId");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)")
                        .HasColumnName("Name");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("Phone");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(6,2)")
                        .HasColumnName("Salary");

                    b.HasKey("Id")
                        .HasName("employees_e_id_pk");

                    b.HasIndex("JobId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Food", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeeId");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("Price");

                    b.HasKey("Id")
                        .HasName("foods_f_id_pk");

                    b.HasIndex("EmployeeId");

                    b.HasIndex(new[] { "Name" }, "UQ__foods__83C8D6387DD47217")
                        .IsUnique()
                        .HasFilter("[Name] IS NOT NULL");

                    b.ToTable("Foods");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Item", b =>
                {
                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("OrderId");

                    b.Property<Guid>("FoodId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("FoodId");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasColumnName("Quantity");

                    b.HasKey("OrderId", "FoodId")
                        .HasName("items_oid_fid_pk");

                    b.HasIndex("FoodId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Job", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<string>("Title")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.MenuTable", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<int>("Capacity")
                        .HasColumnType("int")
                        .HasColumnName("Capacity");

                    b.Property<Guid>("EmployeeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeeId");

                    b.HasKey("Id")
                        .HasName("tables_t_id_pk");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Menu_tables", (string)null);
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("Id");

                    b.Property<Guid?>("CustomerId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("CustomerId");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime")
                        .HasColumnName("Date");

                    b.Property<Guid?>("EmployeeId")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("EmployeeId");

                    b.Property<string>("Type")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("Type");

                    b.HasKey("Id")
                        .HasName("orders_o_id_pk");

                    b.HasIndex("CustomerId");

                    b.HasIndex("EmployeeId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.ResMenu", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<string>("Name")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasColumnName("NAME");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(5,2)")
                        .HasColumnName("PRICE");

                    b.ToView("RES_MENU");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.SellDetail", b =>
                {
                    b.Property<DateTime?>("SDate")
                        .HasColumnType("datetime")
                        .HasColumnName("S_DATE");

                    b.Property<decimal?>("Total")
                        .HasColumnType("decimal(38,2)")
                        .HasColumnName("TOTAL");

                    b.ToView("sell_detail");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.TableDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier")
                        .HasColumnName("ID");

                    b.Property<int>("Space")
                        .HasColumnType("int")
                        .HasColumnName("SPACE");

                    b.ToView("TABLE_DETAIL");
                });

            modelBuilder.Entity("OrderHistory", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Order", null)
                        .WithMany()
                        .HasForeignKey("OId")
                        .IsRequired()
                        .HasConstraintName("order_history_oid_fk");

                    b.HasOne("RestaurantAPI.Entities.Models.MenuTable", null)
                        .WithMany()
                        .HasForeignKey("TId")
                        .IsRequired()
                        .HasConstraintName("order_history_tid_fk");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Booking", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Customer", "Customer")
                        .WithMany("Bookings")
                        .HasForeignKey("CustomerId")
                        .IsRequired()
                        .HasConstraintName("Booking_cid_fk");

                    b.HasOne("RestaurantAPI.Entities.Models.MenuTable", "MenuTable")
                        .WithMany("Bookings")
                        .HasForeignKey("MenuTableId")
                        .IsRequired()
                        .HasConstraintName("Booking_tid_fk");

                    b.Navigation("Customer");

                    b.Navigation("MenuTable");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Employee", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Job", "Job")
                        .WithMany("Employees")
                        .HasForeignKey("JobId")
                        .IsRequired()
                        .HasConstraintName("employees_j_id_fk");

                    b.Navigation("Job");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Food", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Employee", "Employees")
                        .WithMany("Foods")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("foods_e_id_fk");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Item", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Food", "Foods")
                        .WithMany("Items")
                        .HasForeignKey("FoodId")
                        .IsRequired()
                        .HasConstraintName("items_fid_fk");

                    b.HasOne("RestaurantAPI.Entities.Models.Order", "Orders")
                        .WithMany("Items")
                        .HasForeignKey("OrderId")
                        .IsRequired()
                        .HasConstraintName("items_oid_fk");

                    b.Navigation("Foods");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.MenuTable", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Employee", "Employee")
                        .WithMany("MenuTables")
                        .HasForeignKey("EmployeeId")
                        .IsRequired()
                        .HasConstraintName("tables_e_id_fk");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Order", b =>
                {
                    b.HasOne("RestaurantAPI.Entities.Models.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .HasConstraintName("orders_cid_fk");

                    b.HasOne("RestaurantAPI.Entities.Models.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId")
                        .HasConstraintName("orders_eid_fk");

                    b.Navigation("Customer");

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Customer", b =>
                {
                    b.Navigation("Bookings");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Employee", b =>
                {
                    b.Navigation("Foods");

                    b.Navigation("MenuTables");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Food", b =>
                {
                    b.Navigation("Items");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Job", b =>
                {
                    b.Navigation("Employees");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.MenuTable", b =>
                {
                    b.Navigation("Bookings");
                });

            modelBuilder.Entity("RestaurantAPI.Entities.Models.Order", b =>
                {
                    b.Navigation("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
