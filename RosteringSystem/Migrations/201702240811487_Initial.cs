namespace RosteringSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Shift",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        JobId = c.Int(),
                        Capacity = c.Int(nullable: false),
                        RoleId = c.Int(),
                        Vacancy = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Job", t => t.JobId)
                .ForeignKey("dbo.Role", t => t.RoleId)
                .Index(t => t.JobId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Role",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Staff",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Role", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.StaffShift",
                c => new
                    {
                        StaffId = c.Int(nullable: false),
                        ShiftId = c.Int(nullable: false),
                        TimeAssigned = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => new { t.StaffId, t.ShiftId })
                .ForeignKey("dbo.Shift", t => t.ShiftId, cascadeDelete: true)
                .ForeignKey("dbo.Staff", t => t.StaffId, cascadeDelete: true)
                .Index(t => t.StaffId)
                .Index(t => t.ShiftId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shift", "RoleId", "dbo.Role");
            DropForeignKey("dbo.StaffShift", "StaffId", "dbo.Staff");
            DropForeignKey("dbo.StaffShift", "ShiftId", "dbo.Shift");
            DropForeignKey("dbo.Staff", "RoleId", "dbo.Role");
            DropForeignKey("dbo.Shift", "JobId", "dbo.Job");
            DropIndex("dbo.StaffShift", new[] { "ShiftId" });
            DropIndex("dbo.StaffShift", new[] { "StaffId" });
            DropIndex("dbo.Staff", new[] { "RoleId" });
            DropIndex("dbo.Shift", new[] { "RoleId" });
            DropIndex("dbo.Shift", new[] { "JobId" });
            DropTable("dbo.StaffShift");
            DropTable("dbo.Staff");
            DropTable("dbo.Role");
            DropTable("dbo.Shift");
            DropTable("dbo.Job");
        }
    }
}
