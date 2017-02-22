namespace Builder
{
    public class AudiBuilder : Builder
    {
        private readonly Product _product;

        public AudiBuilder()
        {
            _product = new Product();
        }
        public override void BuildPartOne()
        {
            _product.Specifications.Add("Name", "Audi Car");
        }

        public override void BuildPartTwo()
        {
            _product.Specifications.Add("Color", "Red");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}