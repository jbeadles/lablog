namespace LABlog.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSlugToPost : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Slug", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "Slug");
        }
    }
}
