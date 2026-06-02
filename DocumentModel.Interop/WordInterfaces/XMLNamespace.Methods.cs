namespace DocumentModel.Interop.Word;

/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace?view=word-pia"/>
public partial interface IXMLNamespace
{
  /// <summary>
  /// Gets the location of the XML namespace.
  /// </summary>
  /// <param name="AllUsers">true to return the location for all users; otherwise, false.</param>
  /// <returns>The location as a string.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.location?view=word-pia"/>
  public string Location(bool AllUsers);

  /// <summary>
  /// Gets the default XSL transform for the XML namespace.
  /// </summary>
  /// <param name="AllUsers">true to return the transform for all users; otherwise, false.</param>
  /// <returns>The default <see cref="XSLTransform"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace.defaulttransform?view=word-pia"/>
  public XSLTransform DefaultTransform(bool AllUsers);
}
