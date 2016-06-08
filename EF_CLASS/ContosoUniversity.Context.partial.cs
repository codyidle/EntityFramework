using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CLASS
{
    public partial class ContosoUniversityEntities : DbContext
    {
        public override int SaveChanges()
        {
            var entities = this.ChangeTracker.Entries();
            foreach (var entry in entities)
            {
                if (entry.Entity is Course && entry.State == EntityState.Modified)
                {
                    entry.CurrentValues.SetValues(new
                    {
                        ModifyTime = DateTime.Now
                    });
                }
            }


            return base.SaveChanges();
        }
    }
}