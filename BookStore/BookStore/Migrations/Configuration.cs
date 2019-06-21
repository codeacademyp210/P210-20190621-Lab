namespace BookStore.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BookStore.DAL.BookContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookStore.DAL.BookContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Categories.AddOrUpdate( a => a.Id, 
                new Models.Category { Id = 1, Name = "Biography"},
                new Models.Category { Id = 2, Name = "Fantasy"},
                new Models.Category { Id = 3, Name = "Food"},
                new Models.Category { Id = 4, Name = "Children"}
                );
        }
    }
}
