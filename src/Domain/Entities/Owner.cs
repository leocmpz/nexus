using Nexus.Domain.Abstractions;
using Nexus.Domain.ValueObjects;

namespace Nexus.Domain.Entities;

public abstract class Owner : Entity
{
    protected Owner(string sinacorId, string document) : base()
    {
        SinacorId = sinacorId;
        Document = new Document(document);
    }

    public string SinacorId { get; set; }
    public Document Document { get; set; }
}
