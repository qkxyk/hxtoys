namespace HX.Toys.EFSource.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DBInit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Student",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        SurName = c.String(),
                        Classroom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Student");
        }
    }
}
