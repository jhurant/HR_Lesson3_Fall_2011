using System;
namespace HR_Lesson3_Fall_2011.web.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public DateTime DateHired { get; set; }
    }
}