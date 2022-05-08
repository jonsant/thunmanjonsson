namespace Builder_Pattern
{
    public interface IGuitarBuilder
    {
        IGuitarBuilder AddBody(string bodyType);
        IGuitarBuilder AddNeck(string neckShape);
        IGuitarBuilder AddHead(string headType);
        IGuitarBuilder AddStrings(int nrOfStrings = 6);
        Guitar GetGuitar();
    }
}
