namespace ProgSolutions.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student_6DB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryCode = c.Int(nullable: false, identity: true),
                        CountryName = c.String(maxLength: 100),
                        CountryFlag = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.CountryCode);
            
            CreateTable(
                "dbo.Events",
                c => new
                    {
                        EventId = c.Int(nullable: false, identity: true),
                        EventName = c.String(maxLength: 50),
                        EventTypeId = c.Int(nullable: false),
                        MarathonId = c.Short(nullable: false),
                        StartDateTime = c.DateTime(nullable: false),
                        Cost = c.Single(nullable: false),
                        MaxParticipants = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.EventId);
            
            CreateTable(
                "dbo.Genders",
                c => new
                    {
                        Gender_ = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Gender_);
            
            CreateTable(
                "dbo.Marathons",
                c => new
                    {
                        MarathonId = c.Short(nullable: false, identity: true),
                        MarathonName = c.String(maxLength: 80),
                        CityName = c.String(maxLength: 80),
                        CountryCode = c.Int(nullable: false),
                        Yearheld = c.Short(nullable: false),
                    })
                .PrimaryKey(t => t.MarathonId);
            
            CreateTable(
                "dbo.RaceKitOptions",
                c => new
                    {
                        RaceKitOptionId = c.Int(nullable: false, identity: true),
                        RaceKitOption_ = c.String(maxLength: 80),
                        Cost = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.RaceKitOptionId);
            
            CreateTable(
                "dbo.RegistrationEvents",
                c => new
                    {
                        RegistrationEventId = c.Int(nullable: false, identity: true),
                        RegistrationId = c.Int(nullable: false),
                        EventId = c.Int(nullable: false),
                        BibNumber = c.Short(nullable: false),
                        RaceTime = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationEventId);
            
            CreateTable(
                "dbo.Registrations",
                c => new
                    {
                        RegistrationId = c.Int(nullable: false, identity: true),
                        RunnerId = c.Int(nullable: false),
                        RegistationDatetime = c.DateTime(nullable: false),
                        RaceKitOptionId = c.Int(nullable: false),
                        RegistrationStatusId = c.Short(nullable: false),
                        Cost = c.Single(nullable: false),
                        CharityId = c.Int(nullable: false),
                        SponsorshipTarget = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.RegistrationId);
            
            CreateTable(
                "dbo.RegistrationStatus",
                c => new
                    {
                        RegistrationStatusId = c.Short(nullable: false, identity: true),
                        RegistrationStatus_ = c.String(maxLength: 80),
                    })
                .PrimaryKey(t => t.RegistrationStatusId);
            
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        RoleId = c.Int(nullable: false, identity: true),
                        RoleName = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.RoleId);
            
            CreateTable(
                "dbo.Runners",
                c => new
                    {
                        RunnerId = c.Int(nullable: false, identity: true),
                        Email = c.String(maxLength: 100),
                        Gender = c.String(maxLength: 10),
                        DateOfBirth = c.DateTime(nullable: false),
                        CountryCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RunnerId);
            
            CreateTable(
                "dbo.Sponsorships",
                c => new
                    {
                        SponsorShipId = c.Int(nullable: false, identity: true),
                        SponsorName = c.String(maxLength: 150),
                        RegistrationId = c.Int(nullable: false),
                        Amout = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.SponsorShipId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Email = c.String(nullable: false, maxLength: 100),
                        Password = c.String(maxLength: 100),
                        FirstName = c.String(maxLength: 80),
                        LastName = c.String(maxLength: 80),
                        RoleId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Email);
            
            CreateTable(
                "dbo.Volunteers",
                c => new
                    {
                        VolunteerId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 80),
                        LastName = c.String(maxLength: 80),
                        CountryCode = c.Int(nullable: false),
                        Gender = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.VolunteerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Volunteers");
            DropTable("dbo.Users");
            DropTable("dbo.Sponsorships");
            DropTable("dbo.Runners");
            DropTable("dbo.Roles");
            DropTable("dbo.RegistrationStatus");
            DropTable("dbo.Registrations");
            DropTable("dbo.RegistrationEvents");
            DropTable("dbo.RaceKitOptions");
            DropTable("dbo.Marathons");
            DropTable("dbo.Genders");
            DropTable("dbo.Events");
            DropTable("dbo.Countries");
        }
    }
}
