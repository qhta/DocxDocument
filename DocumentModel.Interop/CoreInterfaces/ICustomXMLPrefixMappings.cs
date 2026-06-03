using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `CustomXMLPrefixMappings` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia` for Office interop details.
/// </remarks>
/// <summary>
/// Represents a collection of CustomXMLPrefixMapping objects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings?view=office-pia"/>
public interface ICustomXMLPrefixMappings: IInteropCollection<ICustomXMLPrefixMapping>
{


  #region methods

/// <summary>
  /// Adds a namespace and prefix mapping to the collection.
  /// </summary>
  /// <param name="prefix">The `Prefix` parameter.</param>
  /// <param name="namespaceURI">The `NamespaceURI` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.addnamespace?view=office-pia"/>
  public void AddNamespace(string prefix, string namespaceURI);
  /// <summary>
  /// Looks up a namespace URI by prefix.
  /// </summary>
  /// <param name="prefix">The `Prefix` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.lookupnamespace?view=office-pia"/>
  public string LookupNamespace(string prefix);
  /// <summary>
  /// Looks up a prefix by namespace URI.
  /// </summary>
  /// <param name="namespaceURI">The `NamespaceURI` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlprefixmappings.lookupprefix?view=office-pia"/>
  public string LookupPrefix(string namespaceURI);

  #endregion methods
}

