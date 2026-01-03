namespace DocumentModel;

/// <summary>Represents the list value attributes (xsd:list).</summary>
public interface ListOf<T> : ICollection<T>, IEquatable<ListOf<T>>
  where T : IConvertible
{
}