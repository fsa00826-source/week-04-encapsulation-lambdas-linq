List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};

IEnumerable<string> names = artifacts.Select(a => a.Name);
IEnumerable<int> risks = artifacts.Select(a => a.Risk);
IEnumerable<string> labels = artifacts.Select(a => $"{a.Name} ({a.Origin})");

Console.WriteLine("--- Navn ---");
foreach (string name in names)
{
    Console.WriteLine(name);
}
Console.WriteLine("--- Risk ---");
foreach (int risk in risks)
{
    Console.WriteLine(risk);
}
Console.WriteLine("--- Labels ---");
foreach (string label in labels)
{
    Console.WriteLine(label);
}

