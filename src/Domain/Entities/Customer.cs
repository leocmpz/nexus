namespace Nexus.Domain.Entities;

public sealed class Customer : Owner
{
    public Customer(string apiId, string sinacorId, string document) : base(sinacorId, document)
    {
        ApiId = apiId;
    }

    public string ApiId { get; set; }
}