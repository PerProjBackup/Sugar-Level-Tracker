using SugarLevelTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarLevelTracker.Data
{
  public class SugarLevelDbContext : DbContext
  {
    public SugarLevelDbContext() : base("SugarLvlTrckConnectionString") {}

    public static SugarLevelDbContext Create()
    {
      return new SugarLevelDbContext();
    }

    public DbSet<SugarLevel> SugarLevels { get; set; }
  }
}
