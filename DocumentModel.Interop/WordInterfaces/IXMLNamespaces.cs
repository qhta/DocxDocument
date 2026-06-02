namespace DocumentModel.Interop.Word;

/// <summary>
/// A collection of XMLNamespace objects that represents the entire collection of schemas in the Schema Library.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces?view=word-pia"/>
public partial interface IXMLNamespaces : IInteropObject, IInteropCollection<XMLNamespace>
{


  #region methods

/// <summary>
  /// Adds a new XML namespace to the collection.
  /// </summary>
  /// <param name="Path">The path to the XML schema file.</param>
  /// <param name="NamespaceURI">The namespace URI to associate with the schema.</param>
  /// <param name="Alias">The alias for the namespace.</param>
  /// <param name="InstallForAllUsers">true to install for all users; otherwise, false.</param>
  /// <returns>The created <see cref="XMLNamespace"/> object.</returns>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces.add?view=word-pia"/>
  public XMLNamespace Add(string Path, object NamespaceURI, object Alias, bool InstallForAllUsers);

  /// <summary>
  /// Installs an XML manifest at the specified path.
  /// </summary>
  /// <param name="Path">The path to the manifest file.</param>
  /// <param name="InstallForAllUsers">true to install for all users; otherwise, false.</param>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.xmlnamespaces.installmanifest?view=word-pia"/>
  public void InstallManifest(string Path, bool InstallForAllUsers);

  #endregion methods
}
