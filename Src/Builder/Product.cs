using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Product
    {
        public Product()
        {
            Specifications = new Dictionary<string, string>();
        }
        public Dictionary<string, string> Specifications { get; set; }

        public string Print()
        {
            StringBuilder str = new StringBuilder();
            foreach (KeyValuePair<string, string> specification in Specifications)
            {
                str.Append($"{specification.Key}, {specification.Value}\n");
            }
            return str.ToString();
        }
    }
}