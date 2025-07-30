namespace Nexus.Domain.Entities;

public sealed class Institution : Owner
{
    public Institution(string name, string mnemonic, string sinacorId, string document) : base(sinacorId, document)
    {
        Name = name;
        Mnemonic = mnemonic;
    }

    public string Name { get; set; }
    public string Mnemonic { get; set; }
}
