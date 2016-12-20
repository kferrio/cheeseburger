namespace Cheeseburger.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TargetClasses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TargetFields",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TargetClass_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TargetClasses", t => t.TargetClass_Id)
                .Index(t => t.TargetClass_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TargetFields", "TargetClass_Id", "dbo.TargetClasses");
            DropIndex("dbo.TargetFields", new[] { "TargetClass_Id" });
            DropTable("dbo.TargetFields");
            DropTable("dbo.TargetClasses");
        }
    }
}
