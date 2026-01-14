namespace DocumentModel;

/// <summary>
/// Defines a contract for objects that provide a collection of alternative names or identifiers.
/// </summary>
public interface AliasedObject
{
  /// <summary>
  /// Gets a collection of alternative names or identifiers associated with the object.
  /// </summary>
  public IEnumerable<string>? Aliases { get; }
}