using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using RestaurantAPI.Entities.Models;

namespace RestaurantAPI.Entities.ModelContexts
{
    public partial class Contexts : DbContext
    {
        public Contexts()
        {
        }

        public Contexts(DbContextOptions<Contexts> options)
            : base(options)
        {
        }

        public virtual DbSet<BillDetail> BillDetails { get; set; } = null!;
        public virtual DbSet<Booking> Bookings { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<EmpList> EmpLists { get; set; } = null!;
        public virtual DbSet<Employee> Employees { get; set; } = null!;
        public virtual DbSet<Food> Foods { get; set; } = null!;
        public virtual DbSet<Item> Items { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<MenuTable> MenuTables { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<ResMenu> ResMenus { get; set; } = null!;
        public virtual DbSet<SellDetail> SellDetails { get; set; } = null!;
        public virtual DbSet<TableDetail> TableDetails { get; set; } = null!;

        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=cyborg;Database=RestaurantDB;Trusted_Connection=True;");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BillDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("bill_detail");

                entity.Property(e => e.Bill)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("BILL");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Booking>(entity =>
            {
                entity.HasKey(e => new { e.CustomerId, e.MenuTableId })
                    .HasName("booking_cid_tid_pk");

                entity.ToTable("Booking");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.MenuTableId).HasColumnName("MenuTableId");

                entity.Property(e => e.Date)
                    .HasColumnType("date")
                    .HasColumnName("Date");

                entity.Property(e => e.Hour).HasColumnName("Hour");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Booking_cid_fk");

                entity.HasOne(d => d.MenuTable)
                    .WithMany(p => p.Bookings)
                    .HasForeignKey(d => d.MenuTableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Booking_tid_fk");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("customers_c_id_pk");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .HasColumnName("Address");

                entity.Property(e => e.Name)
                    .HasMaxLength(25)
                    .HasColumnName("Name");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(10)
                    .HasColumnName("Occupation");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .HasColumnName("Phone");
            });

            modelBuilder.Entity<EmpList>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EMP_LIST");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .HasColumnName("ADDRESS");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("PHONE");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("employees_e_id_pk");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(25)
                    .HasColumnName("Address");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("Name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("Phone");

                entity.Property(e => e.Salary)
                    .HasColumnType("decimal(6, 2)")
                    .HasColumnName("Salary");

                entity.Property(e => e.JobId).HasColumnName("JobId");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("employees_j_id_fk");
            });

            modelBuilder.Entity<Food>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("foods_f_id_pk");

                entity.HasIndex(e => e.Name, "UQ__foods__83C8D6387DD47217")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("Name");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("Price");

                entity.HasOne(d => d.Employees)
                    .WithMany(p => p.Foods)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("foods_e_id_fk");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => new { e.OrderId, e.FoodId })
                    .HasName("items_oid_fid_pk");

                entity.Property(e => e.OrderId).HasColumnName("OrderId");

                entity.Property(e => e.FoodId).HasColumnName("FoodId");

                entity.Property(e => e.Quantity).HasColumnName("Quantity");

                entity.HasOne(d => d.Foods)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.FoodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("items_fid_fk");

                entity.HasOne(d => d.Orders)
                    .WithMany(p => p.Items)
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("items_oid_fk");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .HasColumnName("Title");
            });

            modelBuilder.Entity<MenuTable>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("tables_t_id_pk");

                entity.ToTable("Menu_tables");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.Capacity).HasColumnName("Capacity");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MenuTables)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("tables_e_id_fk");

                entity.HasMany(d => d.Orders)
                    .WithMany(p => p.MenuTables)
                    .UsingEntity<Dictionary<string, object>>(
                        "OrderHistory",
                        l => l.HasOne<Order>().WithMany().HasForeignKey("OId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("order_history_oid_fk"),
                        r => r.HasOne<MenuTable>().WithMany().HasForeignKey("TId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("order_history_tid_fk"),
                        j =>
                        {
                            j.HasKey("TId", "OId").HasName("order_history_PK");

                            j.ToTable("Order_History");

                            j.IndexerProperty<Guid>("TId").HasColumnName("t_id");

                            j.IndexerProperty<Guid>("OId").HasColumnName("o_id");
                        });
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("orders_o_id_pk");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("Id");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerId");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeId");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("Date");

                entity.Property(e => e.Type)
                    .HasMaxLength(10)
                    .HasColumnName("Type");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("orders_cid_fk");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("orders_eid_fk");
            });

            modelBuilder.Entity<ResMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("RES_MENU");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("NAME");

                entity.Property(e => e.Price)
                    .HasColumnType("decimal(5, 2)")
                    .HasColumnName("PRICE");
            });

            modelBuilder.Entity<SellDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("sell_detail");

                entity.Property(e => e.SDate)
                    .HasColumnType("datetime")
                    .HasColumnName("S_DATE");

                entity.Property(e => e.Total)
                    .HasColumnType("decimal(38, 2)")
                    .HasColumnName("TOTAL");
            });

            modelBuilder.Entity<TableDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TABLE_DETAIL");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Space).HasColumnName("SPACE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
