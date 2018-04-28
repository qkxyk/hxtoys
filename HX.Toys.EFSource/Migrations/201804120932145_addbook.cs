namespace HX.Toys.EFSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addbook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Book",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        BookName = c.String(),
                        AddTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Book");
        }
    }
}
