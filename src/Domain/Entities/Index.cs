using Nexus.Domain.Abstractions;

namespace Nexus.Domain.Entities;

public sealed class Index : Entity
{
    public Index(string name) : base()
    {
        Name = name;
    }

    public string Name { get; set; }
}
