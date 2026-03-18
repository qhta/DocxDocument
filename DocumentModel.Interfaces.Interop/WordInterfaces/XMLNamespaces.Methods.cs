namespace DocumentModel.Interop;

public partial interface XMLNamespaces
{
  /// <summary>
  /// Adds a new XML namespace to the collection.
  /// </summary>
  /// <param name="Path">The path to the XML schema file.</param>
  /// <param name="NamespaceURI">The namespace URI to associate with the schema.</param>
  /// <param name="Alias">The alias for the namespace.</param>
  /// <param name="InstallForAllUsers">true to install for all users; otherwise, false.</param>
  /// <returns>The created <see cref="XMLNamespace"/> object.</returns>
  public XMLNamespace Add(string Path, object NamespaceURI, object Alias, bool InstallForAllUsers);

  /// <summary>
  /// Installs an XML manifest at the specified path.
  /// </summary>
  /// <param name="Path">The path to the manifest file.</param>
  /// <param name="InstallForAllUsers">true to install for all users; otherwise, false.</param>
  public void InstallManifest(string Path, bool InstallForAllUsers);
}
