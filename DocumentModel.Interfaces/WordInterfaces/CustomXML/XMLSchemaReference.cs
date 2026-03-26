namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents an individual schema that is attached to a document.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference?view=word-pia"/>
public partial interface XMLSchemaReference : InteropObject
{
  /// <summary>
  /// Returns a String that represents the Uniform Resource Identifier (URI) of the schema namespace for the
  /// specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.namespaceuri?view=word-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Returns a String indicating the location of the specified XML schema.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlschemareference.location?view=word-pia"/>
  public string Location { get; }
}
