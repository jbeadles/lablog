namespace LABlog.Web.Migrations
{
    using LABlog.Web.Data;
    using LABlog.Web.Models.Entities;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LABlog.Web.Data.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Posts.AddOrUpdate(
                p => p.Id,
                new Post { Id = 1, Title = "Test Post", Body = "Test Post Body" , Abstract = "Test Post...", Slug = "test-post", Created = DateTime.Now, PostedBy = "Seed Method", CategoryId = 1, Published = true }
            );
        }
    }
}
