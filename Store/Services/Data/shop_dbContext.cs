using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using Store.Models;

namespace Store.Data
{
    public partial class shop_dbContext : DbContext
    {
        public shop_dbContext() { }

        internal bool FindByUser(CustomerModel user)
        {
            bool success = false;
            string connection_string = "server=localhost;database=shop_db;uid=root;pwd=Marchelo11092004!;";
            string Query = $"SELECT CustomerEmail, CustomerPassword FROM customertable WHERE CustomerEmail = @Email AND CustomerPassword = @Password";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand com = new MySqlCommand(Query, con);
            com.Parameters.Add("@Email", MySqlDbType.VarChar, 50).Value = user.CustomerEmail;
            com.Parameters.Add("@Password", MySqlDbType.Text).Value = user.CustomerPassword;
            try
            {
                con.Open();
                MySqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows)
                    success = true;
                else
                    success = false;

                dr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            con.Close();
            return success;
        }

        internal bool InsertUser(CustomerModel user)
        {
            string connection_string = "server=localhost;database=shop_db;uid=root;pwd=Marchelo11092004!;";
            string Query = $"INSERT INTO customertable(CustomerEmail, CustomerPassword) VALUES (@Email, @Password)";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand com = new MySqlCommand(Query, con);
            com.Parameters.Add("@Email", MySqlDbType.VarChar, 50).Value = user.CustomerEmail;
            com.Parameters.Add("@Password", MySqlDbType.Text).Value = user.CustomerPassword;

            if (!HasEmail(user.CustomerEmail))
            {
                con.Open();
                com.ExecuteNonQuery();
                con.Close();
                return true;
            }
            else
                return false;
        }
        internal bool HasEmail(string email)
        {
            bool success = false;
            string connection_string = "server=localhost;database=shop_db;uid=root;pwd=Marchelo11092004!;";
            string Query = $"SELECT CustomerEmail FROM customertable";
            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand com = new MySqlCommand(Query, con);
            con.Open();
            MySqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                if (dr.GetValue(0).Equals(email))
                {
                    success = true;
                    break;
                }
            }
            con.Close();
            return success;
        }
      
        public shop_dbContext(DbContextOptions<shop_dbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<CategoryModel> Categorytables { get; set; } = null!;
        public virtual DbSet<CustomerModel> Customertables { get; set; } = null!;
        public virtual DbSet<OrderdetailsModel> Orderdetailstables { get; set; } = null!;
        public virtual DbSet<OrdersModel> Orderstables { get; set; } = null!;
        public virtual DbSet<PackageModel> Packagetables { get; set; } = null!;
        public virtual DbSet<ProductModel> Producttables { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySql("user id=root;password=Marchelo11092004!;host=localhost;database=shop_db", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.0.29-mysql"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            modelBuilder.Entity<CategoryModel>(entity =>
            {
                entity.HasKey(e => e.CategoryId)
                    .HasName("PRIMARY");

                entity.ToTable("categorytable");

                entity.HasIndex(e => e.CategoryId, "CategoryId")
                    .IsUnique();

                entity.Property(e => e.CategoryId).ValueGeneratedNever();

                entity.Property(e => e.CategoryName).HasMaxLength(30);
            });

            modelBuilder.Entity<CustomerModel>(entity =>
            {
                entity.HasKey(e => e.CustomerId)
                    .HasName("PRIMARY");

                entity.ToTable("customertable");

                entity.HasIndex(e => e.CustomerId, "CustomerId")
                    .IsUnique();

                entity.Property(e => e.CustomerAddress).HasColumnType("text");

                entity.Property(e => e.CustomerEmail).HasMaxLength(50);

                entity.Property(e => e.CustomerFullName).HasMaxLength(40);

                entity.Property(e => e.CustomerPassword).HasColumnType("text");

                entity.Property(e => e.CustomerPhone).HasColumnType("text");
            });

            modelBuilder.Entity<OrderdetailsModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("orderdetailstable");

                entity.HasIndex(e => e.OrderId, "Ord_FK");

                entity.HasIndex(e => e.ProductId, "Prod2_FK");

                entity.Property(e => e.OrderPrice).HasPrecision(10, 2);

                entity.HasOne(d => d.Order)
                    .WithMany()
                    .HasForeignKey(d => d.OrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Ord_FK");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Prod2_FK");
            });

            modelBuilder.Entity<OrdersModel>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PRIMARY");

                entity.ToTable("orderstable");

                entity.HasIndex(e => e.CustomerId, "Cust_FK");

                entity.HasIndex(e => e.OrderId, "OrderId")
                    .IsUnique();

                entity.Property(e => e.OrderId).ValueGeneratedNever();

                entity.Property(e => e.OrderAddress).HasColumnType("text");

                entity.Property(e => e.OrderEmail).HasColumnType("text");

                entity.Property(e => e.OrderStatus).HasColumnType("text");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orderstables)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cust_FK");
            });

            modelBuilder.Entity<PackageModel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("packagetable");

                entity.HasIndex(e => e.ProductId, "Prod_FK");

                entity.Property(e => e.ExpirationDate).HasColumnName("Expiration_date");

                entity.Property(e => e.PackageSource)
                    .HasMaxLength(40)
                    .HasColumnName("Package_source");

                entity.Property(e => e.PackagedDate).HasColumnName("Packaged_date");

                entity.HasOne(d => d.Product)
                    .WithMany()
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Prod_FK");
            });

            modelBuilder.Entity<ProductModel>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PRIMARY");

                entity.ToTable("producttable");

                entity.HasIndex(e => e.CategoryId, "Cat_FK");

                entity.HasIndex(e => e.ProductId, "ProductId")
                    .IsUnique();

                entity.Property(e => e.ProductId).ValueGeneratedNever();

                entity.Property(e => e.ProductDescription).HasColumnType("text");

                entity.Property(e => e.ProductImage).HasColumnType("text");

                entity.Property(e => e.ProductName).HasMaxLength(40);

                entity.Property(e => e.ProductPrice).HasPrecision(10, 2);

                entity.Property(e => e.ProductWeight).HasPrecision(8, 2);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Producttables)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Cat_FK");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
