
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
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping?view=office-pia"/>
public partial interface CustomXMLPrefixMapping: InteropObject
{
  /// <summary>
  /// Gets the `Prefix` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.prefix?view=office-pia"/>
  public string Prefix { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
}

