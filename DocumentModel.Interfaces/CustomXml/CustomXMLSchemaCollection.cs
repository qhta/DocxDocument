
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLSchemaCollection` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschemacollection?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLSchema objects attached to a data stream.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschemacollection?view=office-pia"/>
public partial interface ICustomXMLSchemaCollection: IModelCollection<ICustomXMLSchema>
{
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
}

