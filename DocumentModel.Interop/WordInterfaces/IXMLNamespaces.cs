namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLNamespace objects that represents the entire collection of schemas in the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces?view=word-pia"/>
public interface IXMLNamespaces : IInteropObject, IInteropCollection<IXMLNamespace>
{


  #region methods

/// <summary>
  /// Adds a new XML namespace to the collection.
  /// </summary>
  /// <param name="path">The path to the XML schema file.</param>
  /// <param name="namespaceURI">The namespace URI to associate with the schema.</param>
  /// <param name="alias">The alias for the namespace.</param>
  /// <param name="installForAllUsers">true to install for all users; otherwise, false.</param>
  /// <returns>The created <see cref="IXMLNamespace"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces.add?view=word-pia"/>
  public IXMLNamespace Add(string path, object namespaceURI, object alias, bool installForAllUsers);

  /// <summary>
  /// Installs an XML manifest at the specified path.
  /// </summary>
  /// <param name="path">The path to the manifest file.</param>
  /// <param name="installForAllUsers">true to install for all users; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces.installmanifest?view=word-pia"/>
  public void InstallManifest(string path, bool installForAllUsers);

  #endregion methods
}
