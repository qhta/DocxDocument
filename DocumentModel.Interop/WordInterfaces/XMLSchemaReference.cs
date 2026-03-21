namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema that is attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference?view=word-pia"/>
public partial interface XMLSchemaReference : InteropObject
{
  /// <summary>
  /// Returns the namespace u r i.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Returns the location.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.location?view=word-pia"/>
  public string Location { get; }
}
