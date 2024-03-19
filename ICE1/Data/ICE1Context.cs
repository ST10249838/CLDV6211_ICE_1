using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ICE1Project.Models;

namespace ICE1.Data
{
    public class ICE1Context : DbContext
    {
        public ICE1Context (DbContextOptions<ICE1Context> options)
            : base(options)
        {
        }

        public DbSet<ICE1Project.Models.TaskModel> TaskModel { get; set; } = default!;
    }
}
