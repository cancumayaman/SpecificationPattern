using SpecificationPattern.Models;

namespace SpecificationPattern.Specifications
{
    public class FullNameIsNotEmptySpecification : Specification<Customer>
    {
        public override bool IsSatisfiedBy(Customer customer)
        {
            return !string.IsNullOrWhiteSpace(customer.FullName);
        }
    }
}
