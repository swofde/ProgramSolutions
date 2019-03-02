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

    public class Role
    {
        [Key]
        public int RoleId { get; set; }
        [StringLength(50)]
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
        [StringLength(3)]
        public int CountryCode { get; set; }
    }

    public class Gender
    {
        [Key]
        [StringLength(10)]
        public string Gender { get; set; }
    }

    public class Country
    {
        [Key]
        [StringLength(3)]
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
        [StringLength(3)]
        public int CountryCode { get; set; }
        [StringLength(10)]
        public string Gender { get; set; }
    }

    public class Chrity
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
        public string RaceKitOption { get; set; }
        []
        public float Cost { get; set; }
    }
}
