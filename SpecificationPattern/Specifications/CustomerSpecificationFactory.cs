using SpecificationPattern.Models;

namespace SpecificationPattern.Specifications
{
    public static class CustomerSpecificationFactory
    {
        public static Specification<Customer> CreateCustomerSpecifications()
        {
            var fullNameIsNotEmptySpec = new FullNameIsNotEmptySpecification();
            var customerIsAdultSpec = new CustomerIsAdultSpecification(18);
            var validEmailSpec = new ValidEmailSpecification();

            return fullNameIsNotEmptySpec.And(customerIsAdultSpec).Or(validEmailSpec);
        }
    }
}
