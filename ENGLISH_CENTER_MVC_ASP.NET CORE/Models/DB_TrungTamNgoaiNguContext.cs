using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ENGLISH_CENTER_MVC_ASP.NET_CORE.Models
{
    public partial class DB_TrungTamNgoaiNguContext : DbContext
    {
        public DB_TrungTamNgoaiNguContext()
        {
        }

        public DB_TrungTamNgoaiNguContext(DbContextOptions<DB_TrungTamNgoaiNguContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Class> Classes { get; set; } = null!;
        public virtual DbSet<ClassStudent> ClassStudents { get; set; } = null!;
        public virtual DbSet<ClassWeekday> ClassWeekdays { get; set; } = null!;
        public virtual DbSet<Course> Courses { get; set; } = null!;
        public virtual DbSet<Language> Languages { get; set; } = null!;
        public virtual DbSet<Level> Levels { get; set; } = null!;
        public virtual DbSet<Nhanvien> Nhanviens { get; set; } = null!;
        public virtual DbSet<NhanvienAccount> NhanvienAccounts { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;
        public virtual DbSet<StudentAccount> StudentAccounts { get; set; } = null!;
        public virtual DbSet<Teacher> Teachers { get; set; } = null!;
        public virtual DbSet<TeacherAccount> TeacherAccounts { get; set; } = null!;
        public virtual DbSet<WeekDay> WeekDays { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            //To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-HAHT29KJ;Initial Catalog=DB_TrungTamNgoaiNgu;Persist Security Info=True;User ID=DB_Bin0961;Password=B1nn002233..", x => x.UseNetTopologySuite());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.ToTable("Class");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.HocPhi)
                    .HasColumnType("money")
                    .HasColumnName("hoc_phi");

                entity.Property(e => e.IdCourse).HasColumnName("id_course");

                entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Ngaybatdau)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaybatdau");

                entity.Property(e => e.Ngayketthuc)
                    .HasColumnType("datetime")
                    .HasColumnName("ngayketthuc");

                entity.HasOne(d => d.IdCourseNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdCourse)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__id_course__59FA5E80");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.Classes)
                    .HasForeignKey(d => d.IdTeacher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Class__id_teache__5535A963");
            });

            modelBuilder.Entity<ClassStudent>(entity =>
            {
                entity.HasKey(e => new { e.IdStudent, e.IdClass, e.IdClassStudent })
                    .HasName("PK__class_st__9DF2BE9B76F5E8B7");

                entity.ToTable("class_student");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.Property(e => e.IdClass).HasColumnName("id_class");

                entity.Property(e => e.IdClassStudent)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id_class_student");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__class_stu__id_cl__52593CB8");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.ClassStudents)
                    .HasForeignKey(d => d.IdStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__class_stu__id_st__5812160E");
            });

            modelBuilder.Entity<ClassWeekday>(entity =>
            {
                entity.HasKey(e => new { e.IdClass, e.IdWeekday })
                    .HasName("PK__class_we__BDCE15F5CC9FD47E");

                entity.ToTable("class_weekday");

                entity.Property(e => e.IdClass).HasColumnName("id_class");

                entity.Property(e => e.IdWeekday).HasColumnName("id_weekday");

                entity.Property(e => e.Hours)
                    .HasMaxLength(50)
                    .HasColumnName("hours");

                entity.HasOne(d => d.IdClassNavigation)
                    .WithMany(p => p.ClassWeekdays)
                    .HasForeignKey(d => d.IdClass)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__class_wee__id_cl__5165187F");

                entity.HasOne(d => d.IdWeekdayNavigation)
                    .WithMany(p => p.ClassWeekdays)
                    .HasForeignKey(d => d.IdWeekday)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__class_wee__id_we__5441852A");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasKey(e => e.IdCourse)
                    .HasName("PK__course__FB82D9EA7C75D295");

                entity.ToTable("course");

                entity.Property(e => e.IdCourse).HasColumnName("id_course");

                entity.Property(e => e.IdLanguage).HasColumnName("id_language");

                entity.Property(e => e.IdLevel).HasColumnName("id_level");

                entity.Property(e => e.MoTaKhoaHoc)
                    .HasMaxLength(300)
                    .HasColumnName("mo_ta_khoa_hoc");

                entity.Property(e => e.SoBuoiHoc).HasColumnName("so_buoi_hoc");

                entity.HasOne(d => d.IdLanguageNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.IdLanguage)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__course__id_langu__5BE2A6F2");

                entity.HasOne(d => d.IdLevelNavigation)
                    .WithMany(p => p.Courses)
                    .HasForeignKey(d => d.IdLevel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__course__id_level__5AEE82B9");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.IdLanguage)
                    .HasName("PK__language__1D196341611685ED");

                entity.ToTable("language");

                entity.Property(e => e.IdLanguage).HasColumnName("id_language");

                entity.Property(e => e.NameLanguage)
                    .HasMaxLength(50)
                    .HasColumnName("name_language");
            });

            modelBuilder.Entity<Level>(entity =>
            {
                entity.HasKey(e => e.IdLevel)
                    .HasName("PK__level__4B7C48FFC5D5CFB6");

                entity.ToTable("level");

                entity.Property(e => e.IdLevel).HasColumnName("id_level");

                entity.Property(e => e.KiHieu)
                    .HasMaxLength(5)
                    .HasColumnName("ki_hieu")
                    .IsFixedLength();

                entity.Property(e => e.NameLevel)
                    .HasMaxLength(30)
                    .HasColumnName("name_level");
            });

            modelBuilder.Entity<Nhanvien>(entity =>
            {
                entity.HasKey(e => e.IdNhanvien)
                    .HasName("PK__nhanvien__FE2A92874159AAC6");

                entity.ToTable("nhanvien");

                entity.Property(e => e.IdNhanvien).HasColumnName("id_nhanvien");

                entity.Property(e => e.BirthdayNhanvien)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday_nhanvien");

                entity.Property(e => e.ChucDanhNhanvien)
                    .HasMaxLength(20)
                    .HasColumnName("chuc_danh_nhanvien");

                entity.Property(e => e.MailNhanvien)
                    .HasMaxLength(100)
                    .HasColumnName("mail_nhanvien");

                entity.Property(e => e.NameNhanvien)
                    .HasMaxLength(50)
                    .HasColumnName("name_nhanvien");

                entity.Property(e => e.SdtNhanvien)
                    .HasMaxLength(12)
                    .HasColumnName("sdt_nhanvien")
                    .IsFixedLength();
            });

            modelBuilder.Entity<NhanvienAccount>(entity =>
            {
                entity.HasKey(e => e.IdNhanvienAccount)
                    .HasName("PK__nhanvien__998BBDD43216AA26");

                entity.ToTable("nhanvien_account");

                entity.Property(e => e.IdNhanvienAccount).HasColumnName("id_nhanvien_account");

                entity.Property(e => e.IdNhanvien).HasColumnName("id_nhanvien");

                entity.Property(e => e.PwdNhanvienAccount)
                    .HasMaxLength(50)
                    .HasColumnName("pwd_nhanvien_account");

                entity.Property(e => e.UidNhanvienAccount)
                    .HasMaxLength(50)
                    .HasColumnName("uid_nhanvien_account");

                entity.HasOne(d => d.IdNhanvienNavigation)
                    .WithMany(p => p.NhanvienAccounts)
                    .HasForeignKey(d => d.IdNhanvien)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__nhanvien___id_nh__5DCAEF64");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("PK__payment__862FEFE07BB07816");

                entity.ToTable("payment");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasColumnName("payment_date");

                entity.Property(e => e.Status)
                    .HasMaxLength(30)
                    .HasColumnName("status");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.Id)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__payment__id__534D60F1");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.IdStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__payment__id_stud__59063A47");
            });

            modelBuilder.Entity<PaymentMethod>(entity =>
            {
                entity.HasKey(e => e.IdPaymentMethod)
                    .HasName("PK__payment___7451BE383564B97F");

                entity.ToTable("payment_method");

                entity.Property(e => e.IdPaymentMethod).HasColumnName("id_payment_method");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.NamePaymentMethod)
                    .HasMaxLength(30)
                    .HasColumnName("name_payment_method");

                entity.HasOne(d => d.IdPaymentNavigation)
                    .WithMany(p => p.PaymentMethods)
                    .HasForeignKey(d => d.IdPayment)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__payment_m__id_pa__5CD6CB2B");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.IdStudent)
                    .HasName("PK__student__2BE2EBB631A5A823");

                entity.ToTable("student");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.Property(e => e.AddressStudent)
                    .HasMaxLength(200)
                    .HasColumnName("address_student");

                entity.Property(e => e.BirthdayStudent)
                    .HasColumnType("datetime")
                    .HasColumnName("birthday_student");

                entity.Property(e => e.HotenStudent)
                    .HasMaxLength(100)
                    .HasColumnName("hoten_student");

                entity.Property(e => e.MailStudent)
                    .HasMaxLength(100)
                    .HasColumnName("mail_student");

                entity.Property(e => e.SdtStudent)
                    .HasMaxLength(12)
                    .HasColumnName("sdt_student")
                    .IsFixedLength();
            });

            modelBuilder.Entity<StudentAccount>(entity =>
            {
                entity.HasKey(e => e.IdStudentAccount)
                    .HasName("PK__student___00600CE46B0F9CD6");

                entity.ToTable("student_account");

                entity.Property(e => e.IdStudentAccount).HasColumnName("id_student_account");

                entity.Property(e => e.IdStudent).HasColumnName("id_student");

                entity.Property(e => e.KichHoat).HasColumnName("kich_hoat");

                entity.Property(e => e.PwdStudentAccount)
                    .HasMaxLength(50)
                    .HasColumnName("pwd_student_account");

                entity.Property(e => e.UidStudentAccount)
                    .HasMaxLength(50)
                    .HasColumnName("uid_student_account");

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.StudentAccounts)
                    .HasForeignKey(d => d.IdStudent)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__student_a__id_st__571DF1D5");
            });

            modelBuilder.Entity<Teacher>(entity =>
            {
                entity.HasKey(e => e.IdTeacher)
                    .HasName("PK__teacher__3BAEF8F925014219");

                entity.ToTable("teacher");

                entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");

                entity.Property(e => e.HinhanhTeacher)
                    .HasColumnType("image")
                    .HasColumnName("hinhanh_teacher");

                entity.Property(e => e.HotenTeacher)
                    .HasMaxLength(100)
                    .HasColumnName("hoten_teacher");

                entity.Property(e => e.MailTeacher)
                    .HasMaxLength(100)
                    .HasColumnName("mail_teacher");

                entity.Property(e => e.MotaTeacher)
                    .HasMaxLength(300)
                    .HasColumnName("mota_teacher");

                entity.Property(e => e.SdtTeacher)
                    .HasMaxLength(12)
                    .HasColumnName("sdt_teacher")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TeacherAccount>(entity =>
            {
                entity.HasKey(e => e.IdTeacherAccount)
                    .HasName("PK__teacher___338453BAC4B5008A");

                entity.ToTable("teacher_account");

                entity.Property(e => e.IdTeacherAccount).HasColumnName("id_teacher_account");

                entity.Property(e => e.IdTeacher).HasColumnName("id_teacher");

                entity.Property(e => e.PwdTeacherAccount)
                    .HasMaxLength(50)
                    .HasColumnName("pwd_teacher_account");

                entity.Property(e => e.UidTeacherAccount)
                    .HasMaxLength(50)
                    .HasColumnName("uid_teacher_account");

                entity.HasOne(d => d.IdTeacherNavigation)
                    .WithMany(p => p.TeacherAccounts)
                    .HasForeignKey(d => d.IdTeacher)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__teacher_a__id_te__5629CD9C");
            });

            modelBuilder.Entity<WeekDay>(entity =>
            {
                entity.HasKey(e => e.IdWd)
                    .HasName("PK__week_day__014878941FC18743");

                entity.ToTable("week_day");

                entity.Property(e => e.IdWd).HasColumnName("id_wd");

                entity.Property(e => e.NameDay)
                    .HasMaxLength(40)
                    .HasColumnName("name_day");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
