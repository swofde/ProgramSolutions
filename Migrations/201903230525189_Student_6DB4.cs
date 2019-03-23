namespace ProgSolutions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student_6DB4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Positions",
                c => new
                    {
                        PositionId = c.String(nullable: false, maxLength: 128),
                        PositionName = c.String(),
                        PositionDescription = c.String(),
                        PayPerion = c.String(),
                        PayRate = c.String(),
                    })
                .PrimaryKey(t => t.PositionId);
            
            CreateTable(
                "dbo.Staffs",
                c => new
                    {
                        StaffId = c.Int(nullable: false, identity: true),
                        Firstname = c.String(),
                        LastName = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        PositionId = c.Int(nullable: false),
                        Email = c.String(),
                        Comments = c.String(),
                    })
                .PrimaryKey(t => t.StaffId);
            
            CreateTable(
                "dbo.Timesheets",
                c => new
                    {
                        TimesheetId = c.Int(nullable: false, identity: true),
                        StaffId = c.Int(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        EndDateTime = c.DateTime(nullable: false),
                        PayAmount = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.TimesheetId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Timesheets");
            DropTable("dbo.Staffs");
            DropTable("dbo.Positions");
        }
    }
}
