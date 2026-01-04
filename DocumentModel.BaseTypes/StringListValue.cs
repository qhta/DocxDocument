#nullable enable
using System.Diagnostics;
namespace DocumentModel;

/// <summary>Represents the list value attributes (xsd:list).</summary>
public interface StringListValue : ICollection<string>, IEnumerable, IEquatable<StringListValue>
{
}