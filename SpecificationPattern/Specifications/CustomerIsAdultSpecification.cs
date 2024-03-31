using SpecificationPattern.Models;

namespace SpecificationPattern.Specifications
{
    public class CustomerIsAdultSpecification(int threshold) : Specification<Customer>
    {
        private readonly int _threshold = threshold;

        public override bool IsSatisfiedBy(Customer customer)
        {
            return customer.Age > _threshold;
        }
    }
}
