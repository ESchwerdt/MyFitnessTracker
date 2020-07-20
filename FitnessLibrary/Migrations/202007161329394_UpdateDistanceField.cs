namespace FitnessLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateDistanceField : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Activities", "ActivityDistance", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Activities", "ActivityDistance", c => c.Double(nullable: false));
        }
    }
}
