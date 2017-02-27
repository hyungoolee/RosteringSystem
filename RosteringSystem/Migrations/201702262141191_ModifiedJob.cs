namespace RosteringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModifiedJob : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Job", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Job", "Name", c => c.String());
        }
    }
}
