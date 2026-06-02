namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents an individual schema within the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespace?view=word-pia"/>
public interface IXMLNamespace : IInteropObject
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


  #region methods

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

  #endregion methods
}
