using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ООО_Техносервис.Model;

public partial class OooTachnoserviceContext : DbContext
{
    public OooTachnoserviceContext()
    {
    }

    public OooTachnoserviceContext(DbContextOptions<OooTachnoserviceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<Coment> Coments { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Post> Posts { get; set; }

    public virtual DbSet<Request> Requests { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<TypesProblem> TypesProblems { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseLazyLoadingProxies().UseMySql("server=localhost;user=root;password=root;database=ooo_tachnoservice", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.28-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.Idclient).HasName("PRIMARY");

            entity.ToTable("client");

            entity.Property(e => e.Idclient).HasColumnName("idclient");
            entity.Property(e => e.Firstname)
                .HasMaxLength(45)
                .HasColumnName("firstname");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(45)
                .HasColumnName("patronymic");
            entity.Property(e => e.Telephone)
                .HasMaxLength(11)
                .HasColumnName("telephone");
        });

        modelBuilder.Entity<Coment>(entity =>
        {
            entity.HasKey(e => e.Idcoments).HasName("PRIMARY");

            entity.ToTable("coments");

            entity.HasIndex(e => e.IdEmployee, "employee_coments_idx");

            entity.HasIndex(e => e.IdRequest, "request_coments_idx");

            entity.Property(e => e.Idcoments).HasColumnName("idcoments");
            entity.Property(e => e.IdEmployee).HasColumnName("id_employee");
            entity.Property(e => e.IdRequest).HasColumnName("id_request");
            entity.Property(e => e.TextComenrs).HasColumnName("text_comenrs");

            entity.HasOne(d => d.IdEmployeeNavigation).WithMany(p => p.Coments)
                .HasForeignKey(d => d.IdEmployee)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("employee_coments");

            entity.HasOne(d => d.IdRequestNavigation).WithMany(p => p.Coments)
                .HasForeignKey(d => d.IdRequest)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("request_coments");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Idemployee).HasName("PRIMARY");

            entity.ToTable("employee");

            entity.HasIndex(e => e.Login, "login_UNIQUE").IsUnique();

            entity.HasIndex(e => e.Post, "post_idx");

            entity.Property(e => e.Idemployee).HasColumnName("idemployee");
            entity.Property(e => e.Firstname)
                .HasMaxLength(45)
                .HasColumnName("firstname");
            entity.Property(e => e.Login)
                .HasMaxLength(45)
                .HasColumnName("login");
            entity.Property(e => e.Name)
                .HasMaxLength(45)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(45)
                .HasColumnName("password");
            entity.Property(e => e.Patronymic)
                .HasMaxLength(45)
                .HasColumnName("patronymic");
            entity.Property(e => e.Post).HasColumnName("post");

            entity.HasOne(d => d.PostNavigation).WithMany(p => p.Employees)
                .HasForeignKey(d => d.Post)
                .HasConstraintName("post");
        });

        modelBuilder.Entity<Post>(entity =>
        {
            entity.HasKey(e => e.Idpost).HasName("PRIMARY");

            entity.ToTable("post");

            entity.Property(e => e.Idpost)
                .ValueGeneratedNever()
                .HasColumnName("idpost");
            entity.Property(e => e.NamePost)
                .HasMaxLength(45)
                .HasColumnName("name_post");
        });

        modelBuilder.Entity<Request>(entity =>
        {
            entity.HasKey(e => e.IdRequest).HasName("PRIMARY");

            entity.ToTable("requests");

            entity.HasIndex(e => e.Client, "client_idx");

            entity.HasIndex(e => e.ResponsibleEmployee, "respons_employee_idx");

            entity.HasIndex(e => e.Status, "statuses_idx");

            entity.HasIndex(e => e.TypeProblem, "type_problem_idx");

            entity.Property(e => e.IdRequest).HasColumnName("id_request");
            entity.Property(e => e.Client).HasColumnName("client");
            entity.Property(e => e.DateAdd)
                .HasColumnType("datetime")
                .HasColumnName("date_add");
            entity.Property(e => e.DateEnd)
                .HasColumnType("datetime")
                .HasColumnName("date_end");
            entity.Property(e => e.DescriptionProblem).HasColumnName("description_problem");
            entity.Property(e => e.Device)
                .HasMaxLength(45)
                .HasColumnName("device");
            entity.Property(e => e.ResponsibleEmployee).HasColumnName("responsible_employee");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.TypeProblem).HasColumnName("type_problem");

            entity.HasOne(d => d.ClientNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Client)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("client");

            entity.HasOne(d => d.ResponsibleEmployeeNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.ResponsibleEmployee)
                .HasConstraintName("respons_employee");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("statuses");

            entity.HasOne(d => d.TypeProblemNavigation).WithMany(p => p.Requests)
                .HasForeignKey(d => d.TypeProblem)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("type_problem");
        });

        modelBuilder.Entity<Status>(entity =>
        {
            entity.HasKey(e => e.Idstatus).HasName("PRIMARY");

            entity.ToTable("statuses");

            entity.Property(e => e.Idstatus)
                .ValueGeneratedNever()
                .HasColumnName("idstatus");
            entity.Property(e => e.NameStatus)
                .HasMaxLength(45)
                .HasColumnName("name_status");
        });

        modelBuilder.Entity<TypesProblem>(entity =>
        {
            entity.HasKey(e => e.IdtypesProblem).HasName("PRIMARY");

            entity.ToTable("types_problem");

            entity.Property(e => e.IdtypesProblem)
                .ValueGeneratedNever()
                .HasColumnName("idtypes_problem");
            entity.Property(e => e.NameProblem)
                .HasMaxLength(45)
                .HasColumnName("name_problem");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
