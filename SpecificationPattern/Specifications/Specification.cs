
namespace SpecificationPattern.Specifications
{
    public abstract class Specification<T>
    {
        public abstract bool IsSatisfiedBy(T entity);

        public Specification<T> And(Specification<T> other)
        {
            return new AndSpecification<T>(this, other);
        }

        public Specification<T> Or(Specification<T> other)
        {
            return new OrSpecification<T>(this, other);
        }
    }


}
