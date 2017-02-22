namespace Builder
{
    public class Director
    {
        public Director(Builder builder)
        {
            builder.BuildPartOne();
            builder.BuildPartTwo();
        }
    }
}