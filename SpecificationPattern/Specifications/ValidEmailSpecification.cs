using SpecificationPattern.Models;

namespace SpecificationPattern.Specifications
{
    public class ValidEmailSpecification : Specification<Customer>
    {
        public override bool IsSatisfiedBy(Customer customer)
        {
            return !string.IsNullOrEmpty(customer.Email) && customer.Email.Contains('@');
        }
    }
}
