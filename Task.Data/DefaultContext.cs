using Form.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Task.Data
{
    public class DefaultContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                base.OnConfiguring(optionsBuilder.UseSqlServer(GetSqlServerConnection()));
            }
        }
        public DbSet<Forms> Forms {  get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionType> QuestionType { get; set; }  
        public DbSet<Option> Option { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SelectedAnswer> SelectedAnswer { get; set; }
        private static string GetSqlServerConnection()
        {
            SqlConnectionStringBuilder builder = new()
            {
                ConnectTimeout = 0,
                DataSource = "DESKTOP-EBJT3NE\\SQLEXPRESS",
                UserID = "sa",
                Password = "Avni@003",
                InitialCatalog = "Form",
                TrustServerCertificate = true,
                MultipleActiveResultSets = true,
                IntegratedSecurity = true
            };
            return builder.ConnectionString;  
        }
    }
}
