using System.Text;

namespace Builder_Pattern
{
    public class Guitar
    {
        IList<string> parts;

        public Guitar()
        {
            parts = new List<string>();
        }

        public void Add(string part)
        {
            parts.Add(part);
        }

        public string About()
        {
            StringBuilder sb = new StringBuilder();

            foreach(string part in parts)
            {
                sb.AppendLine(part);
            }
            return sb.ToString();
        }
    }
}
