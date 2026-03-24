using System.Collections;

namespace DocumentModel.Interfaces;

/// <summary>
/// Represents a collection of CustomXMLSchema objects attached to a data stream.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection?view=office-pia"/>
public partial interface _CustomXMLSchemaCollection: InteropCollection<CustomXMLSchema>
{
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlschemacollection.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
}

