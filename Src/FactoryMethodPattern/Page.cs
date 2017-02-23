namespace FactoryMethodPattern
{
    public abstract class Page
    {
        public string Title { get; set; }

        public string Print()
        {
            return $"Type: {this.GetType()}, Title {Title}";
        }
    }

    public class SkillPage : Page
    {
        public SkillPage()
        {
            Title = "Skill Page";
        }
    }

    public class HomePage : Page
    {
        public HomePage()
        {
            Title = "Home Page";
        }
    }

    public class AboutPage : Page
    {
        public AboutPage()
        {
            Title = "About Page";
        }
    }







}