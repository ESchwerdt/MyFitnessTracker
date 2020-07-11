namespace FitnessLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Activities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(unicode: false),
                        ActivityStart = c.DateTime(nullable: false, precision: 0),
                        ActivityDuration = c.Time(nullable: false, precision: 0),
                        ActivityDistance = c.Double(nullable: false),
                        ActivityNotes = c.String(unicode: false),
                        ActivityType_Id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ActivityTypes", t => t.ActivityType_Id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.ActivityType_Id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.ActivityTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActivityName = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        EmailAddress = c.String(unicode: false),
                        Location = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Activities", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Activities", "ActivityType_Id", "dbo.ActivityTypes");
            DropIndex("dbo.Activities", new[] { "User_Id" });
            DropIndex("dbo.Activities", new[] { "ActivityType_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.ActivityTypes");
            DropTable("dbo.Activities");
        }
    }
}
