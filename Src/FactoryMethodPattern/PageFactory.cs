using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class PageFactory
    {
        public List<Page> Pages { get; set; }

        protected PageFactory()
        {
            Pages = new List<Page>();
            this.CreatePages();
        }
        public abstract void CreatePages();

        public string Print()
        {
            StringBuilder str = new StringBuilder();
            foreach (var page in Pages)
            {
                str.Append($"{page.Print()}\n");
            }
            return str.ToString();
        }
    }

    public class WebsiteFactory : PageFactory
    {

        public override void CreatePages()
        {
            Pages.Add(new HomePage());
            Pages.Add(new AboutPage());
        }
    }

    public class ResumeFactory : PageFactory
    {

        public override void CreatePages()
        {
            Pages.Add(new SkillPage());
        }
    }

}