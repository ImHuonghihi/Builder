namespace Builder
{
    public class Car : IBuilder
    {
        private Product product;
        private string brandName;

        public Car (string brand)
        {
            product = new Product();
            brandName = brand;
        }

        public void AddHeadlights()
        {
            product.Add("2 Headlights are added");
        }

        public void BuildBody()
        {
            product.Add("This is a body of a Car");
        }

        public void EndOperations()
        {
            //Nothing in this case
        }

        public Product GetVehicle()
        {
            return product;
        }

        public void InsertWheels()
        {
            product.Add("4 wheels are added");
        }

        public void StartUpOperations()
        {
            product.Add(string.Format("Car Model name :{0}",this.brandName));
        }
    }
}