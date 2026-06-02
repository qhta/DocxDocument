namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema within the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace?view=word-pia"/>
public partial interface IXMLNamespace : IInteropObject
{
  /// <summary>
  /// Returns a String that represents the Uniform Resource Identifier (URI) of the associated namespace.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.uri?view=word-pia"/>
  public string URI { get; }

  /// <summary>
  /// Returns a XSLTransforms collection that represents the Extensible Stylesheet Language Transformation (XSLT)
  /// files specified for use with a schema.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.xsltransforms?view=word-pia"/>
  public XSLTransforms XSLTransforms { get; }
}
