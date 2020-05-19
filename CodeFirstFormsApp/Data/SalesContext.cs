using CodeFirstFormsApp.Models;
using CodeFirstFormsApp.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstFormsApp.Data
{
    class SalesContext : DbContext //DbContext lets us query DB and make changes.
    {
        public DbSet<Sale> Sales { get; set; } //This DbSet allows us to get all data from the Sales Table

        public DbSet<SalesPerson> People { get; set; }

        public DbSet<SalesRegion> Regions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) //This method override allows us to make changes to DB
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>(); //Gets rid of cascade on delete since we are using active column on sales person and region.
        }

        public override int SaveChanges() //Override allows us to implement logic before models are saved into database.
        {
            ChangeTracker.DetectChanges(); //Tracks changes

            var stateManager = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager; //33-47 detects deleted entities. If they are of type IActive change active status instead of delete.

            var deletedEntities = stateManager
                .GetObjectStateEntries(EntityState.Deleted)
                .Select(e => e.Entity)
                .OfType<IActive>()
                .ToArray();

            foreach (var deletedEntity in deletedEntities)
            {
                if (deletedEntities == null) continue;
                stateManager.ChangeObjectState(deletedEntity, EntityState.Modified);
                deletedEntity.Active = false;
            }

            var createdEntities = stateManager //48-60 Tracks added entities and populates details in DB
                .GetObjectStateEntries(EntityState.Added)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var createdEntity in createdEntities)
            {
                createdEntity.CreatedDate = DateTime.Now;
                createdEntity.CreatedBy = Environment.UserName;
                createdEntity.UpdatedDate = DateTime.Now;
                createdEntity.UpdateBy = Environment.UserName;
            }

            var updatedEntities = stateManager //62-74 Tracks updated entities and populates details in DB
                .GetObjectStateEntries(EntityState.Modified)
                .Select(e => e.Entity)
                .OfType<BaseModel>()
                .ToArray();

            foreach (var updatedEntity in updatedEntities)
            {
                updatedEntity.CreatedDate = DateTime.Now;
                updatedEntity.CreatedBy = Environment.UserName;
                updatedEntity.UpdatedDate = DateTime.Now;
                updatedEntity.UpdateBy = Environment.UserName;
            }

            return base.SaveChanges();
        }
    }
}
