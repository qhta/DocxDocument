namespace DocumentModel.Interop.Word;

/// <summary>
/// This object, member, or enumeration is deprecated and is not intended to be used in your code.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion?view=word-pia"/>
public partial interface XMLChildNodeSuggestion : InteropObject
{
  /// <summary>
  /// The base name.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.basename?view=word-pia"/>
  public string BaseName { get; }

  /// <summary>
  /// The namespace uri.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// The xmlschema reference.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlchildnodesuggestion.xmlschemareference?view=word-pia"/>
  public XMLSchemaReference XMLSchemaReference { get; }
}
