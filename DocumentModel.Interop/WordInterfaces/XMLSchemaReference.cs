namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema that is attached to a document.
/// </summary>
public partial interface XMLSchemaReference : InteropObject
{
  /// <summary>
  /// The namespace uri.
  /// </summary>
  public string NamespaceURI { get; }

  /// <summary>
  /// The location.
  /// </summary>
  public string Location { get; }
}
