namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema within the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace?view=word-pia"/>
public partial interface XMLNamespace : InteropObject
{
  /// <summary>
  /// Returns the u r i.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.uri?view=word-pia"/>
  public string URI { get; }

  /// <summary>
  /// Returns the x s l transforms.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.xsltransforms?view=word-pia"/>
  public XSLTransforms XSLTransforms { get; }
}
