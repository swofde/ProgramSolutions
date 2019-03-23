using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace ProgSolutions
{
    public class FirstClass
    {
    }

    public class Staff
    {
        [Key]
        public int StaffId { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public int PositionId { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
    }

    public class Position
    {
        [Key]
        public string PositionId { get; set; }
        public string PositionName { get; set; }
        public string PositionDescription { get; set; }
        public string PayPerion { get; set; }
        public string PayRate { get; set; }
    }

    public class Timesheet
    {
        [Key]
        public int TimesheetId { get; set; }
        public int StaffId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public float PayAmount { get; set; }
    }

    public class Role
    {
        [Key]
        [Editable(true)]
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }

    public class User
    {
        [Key]
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(100)]
        public string Password { get; set; }
        [StringLength(80)]
        public string FirstName { get; set; }
        [StringLength(80)]
        public string LastName { get; set; }
        public int RoleId { get; set; }
    }

    public class Runner
    {
        [Key]
        public int RunnerId { get; set; }
        [StringLength(100)]
        public string Email { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int CountryCode { get; set; }
    }

    public class Gender
    {
        [Key]
        [StringLength(10)]
        public string Gender_ { get; set; }
    }

    public class Country
    {
        [Key]
        public int CountryCode { get; set; }
        [StringLength(100)]
        public string CountryName { get; set; }
        [StringLength(100)]
        public string CountryFlag { get; set; }
    }

    public class Volunteer
    {
        [Key]
        public int VolunteerId { get; set; }
        [StringLength(80)]
        public string FirstName { get; set; }
        [StringLength(80)]
        public string LastName { get; set; }
        public int CountryCode { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
    }

    public class Charity
    {
        [Key]
        public int CharityId { get; set; }
        [StringLength(100)]
        public string CharityName { get; set; }
        [StringLength(2000)]
        public string ChrityDescription { get; set; }
        [StringLength(50)]
        public int CharityLogo { get; set; }
    }

    public class RaceKitOption
    {
        [Key]
        public int RaceKitOptionId { get; set; }
        [StringLength(80)]
        public string RaceKitOption_ { get; set; }
        public float Cost { get; set; }
    }

    public class RegistrationStatus
    {
        [Key]
        public short RegistrationStatusId { get; set; }
        [StringLength(80)]
        public string RegistrationStatus_ { get; set; }
    }

    public class Registration
    {
        [Key]
        public int RegistrationId { get; set; }
        public int RunnerId { get; set; }
        public DateTime RegistationDatetime { get; set; }
        public int RaceKitOptionId { get; set; }
        public short RegistrationStatusId { get; set; }
        public float Cost { get; set; }
        public int CharityId { get; set; }
        public float SponsorshipTarget { get; set; }
    }

    public class Sponsorship
    {
        [Key]
        public int SponsorShipId { get; set; }
        [StringLength(150)]
        public string SponsorName { get; set; }
        public int RegistrationId { get; set; }
        public float Amout { get; set; }
    }

    public class Marathon
    {
        [Key]
        public short MarathonId { get; set; }
        [StringLength(80)]
        public string MarathonName { get; set; }
        [StringLength(80)]
        public string CityName { get; set; }
        public int CountryCode { get; set; }
        public Int16 Yearheld { get; set; }
    }

    public class Event
    {
        [Key]
        public int EventId { get; set; }
        [StringLength(50)]
        public string EventName { get; set; }
        public int EventTypeId { get; set; }
        public short MarathonId { get; set; }
        public DateTime StartDateTime { get; set; }
        public float Cost { get; set; }
        public Int16 MaxParticipants { get; set; }
    }

    public class RegistrationEvent
    {
        [Key]
        public int RegistrationEventId { get; set; }
        public int RegistrationId { get; set; }
        public int EventId { get; set; }
        public Int16 BibNumber { get; set; }
        public int RaceTime { get; set; }
    }
}