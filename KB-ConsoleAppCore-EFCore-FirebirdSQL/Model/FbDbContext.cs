using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace KB_ConsoleAppCore_EFCore_FirebirdSQL.Model
{
  public class FbDbContext : DbContext
  {
    public DbSet<EntFyzOsoba> FyzOsoba { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseFirebird(@"datasource=localhost;database=C:\Users\zajic\source\repos\KB-ConsoleAppCore-EFCore-FirebirdSQL\SolutionItems\FBDatabase\FB_Database.FDB;user=sysdba;password=masterkey");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      base.OnModelCreating(modelBuilder);

      modelBuilder.Entity("KB_ConsoleAppCore_EFCore_FirebirdSQL.Model.EntFyzOsoba", b =>
      {
        b.Property("ID").HasColumnName("ID");
        b.Property("DATETIME").HasColumnName("DATETIME").IsConcurrencyToken();
        b.Property("LOGIN").HasColumnName("LOGIN");
        b.Property("OSOBATYP_ID").HasColumnName("OSOBATYP_ID");
        b.Property("FYZOSOBA_PRIJMENI").HasColumnName("FYZOSOBA_PRIJMENI");
        b.Property("FYZOSOBA_JMENO").HasColumnName("FYZOSOBA_JMENO");
        b.Property("FYZOSOBA_DAT_NAR").HasColumnName("FYZOSOBA_DAT_NAR");
        b.Property("POZNAMKA").HasColumnName("FYZOSOBA_POZN");
        b.HasKey("ID");
        b.ToTable("V_FYZ_OSOBA");
      });
    }
  }
}
