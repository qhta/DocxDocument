namespace DocumentModel.CustomXml;

/// <summary>
/// Represents a collection of CustomXMLSchema objects attached to a data stream.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection?view=office-pia"/>
public partial interface ICustomXMLSchemaCollection
{
  /// <summary>
  /// Adds a schema to the custom XML schema collection.
  /// </summary>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="Alias">The `Alias` parameter.</param>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <param name="InstallForAllUsers">The `InstallForAllUsers` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.add?view=office-pia"/>
  public ICustomXMLSchema Add
    (string NamespaceURI, string Alias, string FileName, bool InstallForAllUsers);
  /// <summary>
  /// Adds all schemas from another schema collection.
  /// </summary>
  /// <param name="SchemaCollection">The `SchemaCollection` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.addcollection?view=office-pia"/>
  public void AddCollection(ICustomXMLSchemaCollection SchemaCollection);
  /// <summary>
  /// Validates the custom XML schema collection.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.validate?view=office-pia"/>
  public bool Validate();
}

