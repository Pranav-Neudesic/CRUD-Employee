﻿namespace CRUD_WebApplication.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public DateTime? DateOfJoining { get; set; }
    }
}
