namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema that is attached to a document.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference?view=word-pia"/>
public partial interface XMLSchemaReference : InteropObject
{
  /// <summary>
  /// The namespace uri.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// The location.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.location?view=word-pia"/>
  public string Location { get; }
}
