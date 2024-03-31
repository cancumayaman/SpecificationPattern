// See https://aka.ms/new-console-template for more information
using SpecificationPattern.Models;
using SpecificationPattern.Specifications;

Console.WriteLine("Hello, World!");

var customer = new Customer()
{
    Id = 1,
    FirstName = "Can",
    LastName = "Yaman",
    Age = 25,
    Department = "IT",
    Email = "testmail.com"
};

var isSatisfiedBy = CustomerSpecificationFactory.CreateCustomerSpecifications().IsSatisfiedBy(customer);
Console.WriteLine(isSatisfiedBy ? "Success" : "Fail");

Console.ReadKey();