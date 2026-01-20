namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an abstract base class for defining a strongly-typed relationship element within a document model.
/// </summary>
/// <remarks>This class provides common properties for relationship elements, such as the relationship identifier
/// and target URI. It is intended to be inherited by concrete relationship types that map to specific document
/// relationships.</remarks>
/// <typeparam name="T">The type of the underlying relationship element represented by this class. Must be a type derived from
/// DXW.RelationshipType.</typeparam>
public abstract class RelationshipType<T> : ModelElement<T>
  where T :DXW.RelationshipType
{
  /// <summary>
  /// Gets the underlying Document instance associated with this object.
  /// </summary>

  /// <summary>
  /// Unique identifier for the relationship.
  /// </summary>
  public string? Id
  {
    get => _Id;
    set => UpdateField(ref _Id, value, nameof(Id));
  }
  private string? _Id;

}