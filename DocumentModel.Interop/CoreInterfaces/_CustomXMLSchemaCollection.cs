using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of CustomXMLSchema objects attached to a data stream.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection?view=office-pia
/// </remarks>
public partial interface _CustomXMLSchemaCollection: InteropDictionary<string, CustomXMLSchema>
{
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.namespaceuri?view=office-pia
  /// </remarks>
  public string NamespaceURI { get; }
}
