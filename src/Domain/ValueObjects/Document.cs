using System.Text.RegularExpressions;

namespace Nexus.Domain.ValueObjects;

public sealed class Document
{
    public string Value { get; }

    public Document(string value)
    {
        if (string.IsNullOrEmpty(value))
        {
            throw new ArgumentException("Document value cannot be null or empty.", nameof(value));
        }

        Value = OnlyNumbers(value);
    }

    private static string OnlyNumbers(string input) => Regex.Replace(input, "[^0-9]", "");

    public static implicit operator string(Document document)
    {
        return document.Value;
    }
}
