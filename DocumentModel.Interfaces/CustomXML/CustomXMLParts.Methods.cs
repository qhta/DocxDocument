namespace DocumentModel.CustomXml;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia"/>
public partial interface ICustomXMLParts
{
  /// <summary>
  /// Adds a custom XML part to the collection.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="SchemaCollection">The `SchemaCollection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.add?view=office-pia"/>
  public ICustomXMLPart Add(string XML, object SchemaCollection);
  /// <summary>
  /// Selects a custom XML part by ID.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbyid?view=office-pia"/>
  public ICustomXMLPart SelectByID(string Id);
  /// <summary>
  /// Selects custom XML parts by namespace URI.
  /// </summary>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbynamespace?view=office-pia"/>
  public ICustomXMLParts SelectByNamespace(string NamespaceURI);
}

