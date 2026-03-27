using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia"/>
public partial interface _CustomXMLParts
{
  /// <summary>
  /// Adds a custom XML part to the collection.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="SchemaCollection">The `SchemaCollection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.add?view=office-pia"/>
  public CustomXMLPart Add(string XML, object SchemaCollection);
  /// <summary>
  /// Selects a custom XML part by ID.
  /// </summary>
  /// <param name="Id">The `Id` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbyid?view=office-pia"/>
  public CustomXMLPart SelectByID(string Id);
  /// <summary>
  /// Selects custom XML parts by namespace URI.
  /// </summary>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbynamespace?view=office-pia"/>
  public CustomXMLParts SelectByNamespace(string NamespaceURI);
}

