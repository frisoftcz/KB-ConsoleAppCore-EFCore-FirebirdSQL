using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using KB_ConsoleAppCore_EFCore_FirebirdSQL.Model;

namespace KB_ConsoleAppCore_EFCore_FirebirdSQL
{
  class Program
  {
    static void Main(string[] args)
    {
      using (var db = new FbDbContext())
      {
        var data1 = db.Set<EntFyzOsoba>()
          .ToList();
        foreach (var item in data1)
        {
          Console.WriteLine($"{item.ID}: {item.FYZOSOBA_PRIJMENI} ({item.DATETIME})");
        }

        var data2 = db.FyzOsoba.ToList();
        foreach (var item in data2)
        {
          Console.WriteLine($"{item.ID}: {item.FYZOSOBA_PRIJMENI} ({item.DATETIME})");
        }


        EntFyzOsoba fyzOsoba = db.FyzOsoba
          .Where(x => x.ID == "20181111180000000001")
          .FirstOrDefault<EntFyzOsoba>();

        Console.ReadLine();

        try
        {
          fyzOsoba.FYZOSOBA_PRIJMENI = "Vomáčka";
          fyzOsoba.DATETIME = DateTime.Now;
          db.SaveChanges();
        }
        catch (DbUpdateConcurrencyException ex)
        {
          Console.WriteLine("Záznam byl změěnn jiným uživatelem.");
          foreach (var entry in ex.Entries)
          {
            Console.WriteLine(entry.Metadata.Name);
          }
        }
      }
      Console.ReadLine();
    }
  }
}
