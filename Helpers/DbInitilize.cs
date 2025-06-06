using BugBase.DTOs;
using System;
using System.Data.Entity;

namespace BugBase.Helpers
{
    public class DbInitilize : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            context.Bugs.Add(new Bug("1", "2", "3", DateTime.Now, true));
            base.Seed(context);
        }
    }
}
