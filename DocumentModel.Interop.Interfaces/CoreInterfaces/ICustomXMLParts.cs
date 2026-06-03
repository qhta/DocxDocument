using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia"/>
public interface ICustomXMLParts: IInteropCollection<ICustomXMLPart>
{


  #region methods

/// <summary>
  /// Adds a custom XML part to the collection.
  /// </summary>
  /// <param name="xML">The `XML` parameter.</param>
  /// <param name="schemaCollection">The `SchemaCollection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.add?view=office-pia"/>
  public ICustomXMLPart Add(string xML, object schemaCollection);
  /// <summary>
  /// Selects a custom XML part by ID.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbyid?view=office-pia"/>
  public ICustomXMLPart SelectByID(string id);
  /// <summary>
  /// Selects custom XML parts by namespace URI.
  /// </summary>
  /// <param name="namespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbynamespace?view=office-pia"/>
  public ICustomXMLParts SelectByNamespace(string namespaceURI);

  #endregion methods
}

