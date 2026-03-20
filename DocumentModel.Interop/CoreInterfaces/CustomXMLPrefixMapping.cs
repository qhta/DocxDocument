
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLPrefixMapping` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a namespace prefix mapping.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping?view=office-pia
/// </remarks>
public partial interface CustomXMLPrefixMapping: InteropObject
{
  /// <summary>
  /// Gets the `Prefix` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.prefix?view=office-pia
  /// </remarks>
  public string Prefix { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.namespaceuri?view=office-pia
  /// </remarks>
  public string NamespaceURI { get; }
}
