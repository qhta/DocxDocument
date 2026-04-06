namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents a single registered Extensible Stylesheet Language Transformation (XSLT).
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xsltransform?view=word-pia"/>
public partial interface IXSLTransform : IModelObject
{
  /// <summary>
  /// Returns a value containing the GUID assigned to the current XSLTransform object.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xsltransform.id?view=word-pia"/>
  public string ID { get; }
}
