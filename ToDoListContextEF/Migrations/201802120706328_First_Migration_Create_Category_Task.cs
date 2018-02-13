namespace ToDoListContextEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class First_Migration_Create_Category_Task : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Notes = c.String(),
                        CategoryId = c.Int(nullable: false),
                        DateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tasks", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Tasks", new[] { "CategoryId" });
            DropTable("dbo.Tasks");
            DropTable("dbo.Categories");
        }
    }
}
