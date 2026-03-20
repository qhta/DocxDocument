
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLSchema` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a schema in a custom XML schema collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema?view=office-pia
/// </remarks>
public partial interface CustomXMLSchema: InteropObject
{
  /// <summary>
  /// Gets the `Location` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.location?view=office-pia
  /// </remarks>
  public string Location { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlschema.namespaceuri?view=office-pia
  /// </remarks>
  public string NamespaceURI { get; }
}
