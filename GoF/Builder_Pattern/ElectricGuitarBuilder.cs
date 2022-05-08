namespace Builder_Pattern
{
    public class ElectricGuitarBuilder : IGuitarBuilder
    {
        Guitar guitar;

        public ElectricGuitarBuilder()
        {
            guitar = new Guitar();
        }
        public IGuitarBuilder AddBody(string bodyType)
        {
            guitar.Add($"Body: {bodyType}");
            return this;
        }

        public IGuitarBuilder AddNeck(string neckShape)
        {
            guitar.Add($"Neck: {neckShape}");
            return this;
        }

        public IGuitarBuilder AddHead(string headType)
        {
            guitar.Add($"Head: {headType}");
            return this;
        }

        public IGuitarBuilder AddStrings(int nrOfStrings)
        {
            guitar.Add($"Nr of strings: {nrOfStrings}");
            return this;
        }

        public Guitar GetGuitar()
        {
            return guitar;
        }
    }
}
