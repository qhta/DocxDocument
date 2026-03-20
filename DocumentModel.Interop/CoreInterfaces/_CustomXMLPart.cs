
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single custom XML part in a custom XML parts collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart?view=office-pia
/// </remarks>
public partial interface _CustomXMLPart: InteropObject
{
  /// <summary>
  /// Gets the root element of a bound region of data in a document.
  /// If the region is empty, this property returns <c>null</c>.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.documentelement?view=office-pia
  /// </remarks>
  public CustomXMLNode DocumentElement { get; }

  /// <summary>
  /// Gets a string containing the GUID assigned to the current custom XML part.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.id?view=office-pia
  /// </remarks>
  public string Id { get; }

  /// <summary>
  /// Gets the unique address identifier for the namespace of the custom XML part.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespaceuri?view=office-pia
  /// </remarks>
  public string NamespaceURI { get; }

  /// <summary>
  /// Gets or sets the schema collection attached to the bound region of data.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.schemacollection?view=office-pia
  /// </remarks>
  public CustomXMLSchemaCollection SchemaCollection { get; set; }

  /// <summary>
  /// Gets the namespace prefix mappings used against the current custom XML part.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespacemanager?view=office-pia
  /// </remarks>
  public CustomXMLPrefixMappings NamespaceManager { get; }

  /// <summary>
  /// Gets the XML representation of the current custom XML part.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.xml?view=office-pia
  /// </remarks>
  public string XML { get; }

  /// <summary>
  /// Gets XML validation errors for the part, if any exist.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.errors?view=office-pia
  /// </remarks>
  public CustomXMLValidationErrors Errors { get; }

  /// <summary>
  /// Gets a value indicating whether the custom XML part is built-in.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.builtin?view=office-pia
  /// </remarks>
  public bool BuiltIn { get; }
}
