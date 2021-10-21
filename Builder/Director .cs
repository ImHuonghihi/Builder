namespace Builder
{
    public class Director 
    {
        public IBuilder builder;
        // A series of steps-in real life, steps are complex.
        
        public void Construct(IBuilder Builder)
        {
            builder = Builder;
            builder.StartUpOperations();
            builder.BuildBody();
            builder.InsertWheels();
            builder.AddHeadlights();
            builder.EndOperations();
        }
    }
}