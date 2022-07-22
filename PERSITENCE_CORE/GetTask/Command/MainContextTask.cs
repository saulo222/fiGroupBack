using DOMAIN_CORE.Class;
using Microsoft.EntityFrameworkCore;
using PERSITENCE_CORE.Aggregates;

namespace PERSITENCE_CORE.GetTask.Command
{
    public class MainContextTask : DbContext, IContextWorkUnit
    {


        public MainContextTask(DbContextOptions<MainContextTask> options)
            : base(options)
        {
        }

        DbSet<Tasks> _Property;


        public DbSet<Tasks> Property
        {
            get { return _Property ?? (_Property = base.Set<Tasks>()); }
        }


        public void SetDetached<Entity>(Entity item) where Entity : class
        {
            Entry(item).State = EntityState.Detached;
        }


        public int Save()
        {
            return base.SaveChangesAsync().GetAwaiter().GetResult();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new TaskConfig());
   
        }
    }
}
