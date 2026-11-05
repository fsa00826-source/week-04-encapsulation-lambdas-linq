List<Artifact> artifacts = new List<Artifact>
{
    new Artifact("Echo Stone", "Moon", 73),
    new Artifact("Broken Compass", "Earth", 12),
    new Artifact("Glass Seed", "Mars", 48),
    new Artifact("Signal Cube", "Moon", 91),
    new Artifact("Dust Crown", "Mars", 65),
    new Artifact("Cold Lens", "Europa", 28)
};

IEnumerable<Artifact> highRisk = artifacts.Where(a => a.Risk >= 60);
IEnumerable<Artifact> fromMoon = artifacts.Where(a => a.Origin == "Moon");
IEnumerable<Artifact> containsE = artifacts.Where(
    a => a.Name.Contains("e", StringComparison.OrdinalIgnoreCase));

Console.WriteLine("--- Risk >= 60 ---");
foreach (Artifact a in highRisk)
{
    Console.WriteLine($"{a.Name} ({a.Risk})");
}

Console.WriteLine("--- Fra Moon ---");
foreach (Artifact a in fromMoon)
{
    Console.WriteLine(a.Name);
}

Console.WriteLine("--- Inneholder 'e' ---");
foreach (Artifact a in containsE)
{
    Console.WriteLine(a.Name);
}
// TODO: Lag tre separate Where-queries.
