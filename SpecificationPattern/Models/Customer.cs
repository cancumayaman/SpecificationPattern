﻿namespace SpecificationPattern.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
