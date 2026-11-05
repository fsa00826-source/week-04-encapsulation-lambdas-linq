Archive archive = new Archive();
archive.Add("A-1");
archive.Add("A-2");
archive.Add("A-3");

Console.WriteLine($"Før clear blir kjørt: {archive.Count}");

List<string> outsideList = archive.GetEntries();
outsideList.Clear();

Console.WriteLine($"Etter clear har blitt kjørt: {archive.Count}");

// TODO del A: Clear outsideList og observer archive.Count.


// TODO del B: Fiks GetEntries(), og prøv eksperimentet på nytt.

Console.WriteLine($"Archive count: {archive.Count}");
