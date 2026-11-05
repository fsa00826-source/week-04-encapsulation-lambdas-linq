DroneVault vault = new DroneVault();
vault.Add(new Drone("Delta"));
vault.Add(new Drone("Echo"));

List<Drone> copy = vault.GetDrones();

// TODO: Eksperimenter med RemoveAt og deretter endring av Name.

copy.RemoveAt(0);
Console.WriteLine($"Vault count etter RemoveAt: {vault.Count}");


copy[0].Name = "Endret";
Console.WriteLine($"Vault etter Navn-endring: {vault.Count}");
vault.PrintAll();
