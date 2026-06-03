using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of _CustomXMLPart objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts?view=office-pia"/>
public partial class CustomXMLParts: InteropCollection<CustomXMLPart>
{


  #region methods

/// <summary>
  /// Adds a custom XML part to the collection.
  /// </summary>
  /// <param name="xML">The `XML` parameter.</param>
  /// <param name="schemaCollection">The `SchemaCollection` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.add?view=office-pia"/>
  public CustomXMLPart Add(string xML, object schemaCollection) { throw new NotImplementedException(); }
  /// <summary>
  /// Selects a custom XML part by ID.
  /// </summary>
  /// <param name="id">The `Id` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbyid?view=office-pia"/>
  public CustomXMLPart SelectByID(string id) { throw new NotImplementedException(); }
  /// <summary>
  /// Selects custom XML parts by namespace URI.
  /// </summary>
  /// <param name="namespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlparts.selectbynamespace?view=office-pia"/>
  public CustomXMLParts SelectByNamespace(string namespaceURI) { throw new NotImplementedException(); }

  #endregion methods
}

