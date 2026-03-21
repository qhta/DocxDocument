namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion?view=word-pia"/>
public partial interface XMLChildNodeSuggestion : InteropObject
{
  /// <summary>
  /// Returns the base name.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// Returns the namespace u r i.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Returns the x m l schema reference.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.xmlschemareference?view=word-pia"/>
  public XMLSchemaReference XMLSchemaReference { get; }
}
