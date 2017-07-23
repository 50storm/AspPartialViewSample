using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcClient.Models
{
  public class MvcClientContext : DbContext
  {
    public DbSet<Member> Members { get; set; }
    public DbSet<Article> Articles { get; set; }

  }
}