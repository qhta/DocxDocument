
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single custom XML part in a custom XML parts collection.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart?view=office-pia"/>
public partial class _CustomXMLPart: InteropObject
{
  /// <summary>
  /// Gets the root element of a bound region of data in a document.
  /// If the region is empty, this property returns <c>null</c>.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.documentelement?view=office-pia"/>
  public CustomXMLNode DocumentElement { get; }

  /// <summary>
  /// Gets a string containing the GUID assigned to the current custom XML part.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.id?view=office-pia"/>
  public string Id { get; }

  /// <summary>
  /// Gets the unique address identifier for the namespace of the custom XML part.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Gets or sets the schema collection attached to the bound region of data.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.schemacollection?view=office-pia"/>
  public CustomXMLSchemaCollection SchemaCollection { get; set; }

  /// <summary>
  /// Gets the namespace prefix mappings used against the current custom XML part.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespacemanager?view=office-pia"/>
  public CustomXMLPrefixMappings NamespaceManager { get; }

  /// <summary>
  /// Gets the XML representation of the current custom XML part.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.xml?view=office-pia"/>
  public string XML { get; }

  /// <summary>
  /// Gets XML validation errors for the part, if any exist.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.errors?view=office-pia"/>
  public CustomXMLValidationErrors Errors { get; }

  /// <summary>
  /// Gets a value indicating whether the custom XML part is built-in.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.builtin?view=office-pia"/>
  public bool BuiltIn { get; }


  #region methods

/// <summary>
  /// Adds a node to the XML tree.
  /// </summary>
  /// <param name="Parent">The parent node under which to add the new node.</param>
  /// <param name="Name">The node name.</param>
  /// <param name="NamespaceURI">The namespace URI for the node.</param>
  /// <param name="NextSibling">The sibling node before which to insert the node.</param>
  /// <param name="NodeType">The custom XML node type.</param>
  /// <param name="NodeValue">The node value.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.addnode?view=office-pia"/>
  public void AddNode
  (CustomXMLNode Parent, string Name, string NamespaceURI, CustomXMLNode NextSibling,
    CustomXMLNodeType NodeType, string NodeValue)
  { throw new NotImplementedException(); }

  /// <summary>
  /// Deletes the current custom XML part from the data store.
  /// If the part contains core properties, the operation is not performed.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  /// <summary>
  /// Populates this custom XML part from an existing file.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="FilePath">Path of the source XML file.</param>
  /// <returns><c>true</c> when the part is loaded successfully; otherwise <c>false</c>.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.load?view=office-pia"/>
  public bool Load(string FilePath) { throw new NotImplementedException(); }

  /// <summary>
  /// Populates this custom XML part from an XML string.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="XML">The XML content to load.</param>
  /// <returns><c>true</c> when the XML is loaded successfully; otherwise <c>false</c>.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.loadxml?view=office-pia"/>
  public bool LoadXML(string XML) { throw new NotImplementedException(); }

  /// <summary>
  /// Selects a collection of nodes from this custom XML part using an XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression.</param>
  /// <returns>A collection of matching nodes.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectnodes?view=office-pia"/>
  public CustomXMLNodes SelectNodes(string XPath) { throw new NotImplementedException(); }

  /// <summary>
  /// Selects a single node in this custom XML part matching an XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression.</param>
  /// <returns>The matching node, if found.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectsinglenode?view=office-pia"/>
  public CustomXMLNode SelectSingleNode(string XPath) { throw new NotImplementedException(); }

  #endregion methods
}

