using Builder_Pattern;

Guitar acousticGuitar = new AcousticGuitarBuilder()
    .AddHead("Slotted")
    .AddNeck("V Soft")
    .AddBody("Classical")
    .AddStrings()
    .GetGuitar();

Guitar electricGuitar = new ElectricGuitarBuilder()
    .AddBody("Firebird")
    .AddHead("11 Degree Angled")
    .AddNeck("V Hard")
    .AddStrings()
    .GetGuitar();

Console.WriteLine(acousticGuitar.About());
Console.WriteLine(electricGuitar.About());