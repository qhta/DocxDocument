
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents the `CustomXMLPrefixMapping` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a namespace prefix mapping.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping?view=office-pia"/>
public partial interface ICustomXMLPrefixMapping : IModelObject
{
  /// <summary>
  /// Gets the `Prefix` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.prefix?view=office-pia"/>
  public string Prefix { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmapping.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
}

