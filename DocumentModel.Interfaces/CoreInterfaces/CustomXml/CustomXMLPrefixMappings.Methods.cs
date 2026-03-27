using System.Collections;

namespace DocumentModel.Application;

/// <summary>
/// Represents a collection of CustomXMLPrefixMapping objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia"/>
public partial interface CustomXMLPrefixMappings: InteropObject
{
  /// <summary>
  /// Adds a namespace and prefix mapping to the collection.
  /// </summary>
  /// <param name="Prefix">The `Prefix` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.addnamespace?view=office-pia"/>
  public void AddNamespace(string Prefix, string NamespaceURI);
  /// <summary>
  /// Looks up a namespace URI by prefix.
  /// </summary>
  /// <param name="Prefix">The `Prefix` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.lookupnamespace?view=office-pia"/>
  public string LookupNamespace(string Prefix);
  /// <summary>
  /// Looks up a prefix by namespace URI.
  /// </summary>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.lookupprefix?view=office-pia"/>
  public string LookupPrefix(string NamespaceURI);
}

