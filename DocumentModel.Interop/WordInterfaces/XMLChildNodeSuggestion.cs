namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
public partial interface XMLChildNodeSuggestion : InteropObject
{
  /// <summary>
  /// The base name.
  /// </summary>
  public string BaseName { get; }

  /// <summary>
  /// The namespace uri.
  /// </summary>
  public string NamespaceURI { get; }

  /// <summary>
  /// The xmlschema reference.
  /// </summary>
  public XMLSchemaReference XMLSchemaReference { get; }
}
