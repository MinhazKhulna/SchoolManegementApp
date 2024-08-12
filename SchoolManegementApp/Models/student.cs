using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;


namespace SchoolManegementApp.Models
{
    public class student
    {
        [Key]
        public int id { get; set; }        
        public int studentId { get; set; }
        public string studentName { get; set; }
        public string studentAddress { get; set; }
        public DateAndTime dateOfBirth { get; set; }
        public int studentClass { get; set; }
        public DateAndTime admissionDate { get; set; }
        public string email { get; set; }
        public String fatherName { get; set; }
        public String motherName { get; set; }
        public String mobileNumber { get; set; }
        public String studentGender { get; set; }
        public String imageName { get; set; }
       


    }
}
