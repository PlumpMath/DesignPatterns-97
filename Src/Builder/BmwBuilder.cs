namespace Builder
{
    public class BmwBuilder : Builder
    {
        private readonly Product _product;

        public BmwBuilder()
        {
            _product = new Product();
        }
        public override void BuildPartOne()
        {
            _product.Specifications.Add("Name", "Bmw Car");
        }

        public override void BuildPartTwo()
        {
            _product.Specifications.Add("Color", "White");
        }

        public override Product GetProduct()
        {
            return _product;
        }
    }
}