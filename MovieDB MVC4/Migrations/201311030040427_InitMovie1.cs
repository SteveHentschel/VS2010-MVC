namespace MovieDB_MVC4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMovie1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 4000),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(nullable: false, maxLength: 4000),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Rating = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
