
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single custom XML part in a custom XML parts collection.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart?view=office-pia"/>
public interface ICustomXMLPart: IInteropObject
{
  /// <summary>
  /// Gets the root element of a bound region of data in a document.
  /// If the region is empty, this property returns <c>null</c>.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.documentelement?view=office-pia"/>
  public ICustomXMLNode DocumentElement { get; }

  /// <summary>
  /// Gets a string containing the GUID assigned to the current custom XML part.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.id?view=office-pia"/>
  public string Id { get; }

  /// <summary>
  /// Gets the unique address identifier for the namespace of the custom XML part.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }

  /// <summary>
  /// Gets or sets the schema collection attached to the bound region of data.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.schemacollection?view=office-pia"/>
  public ICustomXMLSchemaCollection SchemaCollection { get; set; }

  /// <summary>
  /// Gets the namespace prefix mappings used against the current custom XML part.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.namespacemanager?view=office-pia"/>
  public ICustomXMLPrefixMappings NamespaceManager { get; }

  /// <summary>
  /// Gets the XML representation of the current custom XML part.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.xml?view=office-pia"/>
  public string XML { get; }

  /// <summary>
  /// Gets XML validation errors for the part, if any exist.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.errors?view=office-pia"/>
  public ICustomXMLValidationErrors Errors { get; }

  /// <summary>
  /// Gets a value indicating whether the custom XML part is built-in.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.builtin?view=office-pia"/>
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
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.addnode?view=office-pia"/>
  public void AddNode
  (ICustomXMLNode Parent, string Name, string NamespaceURI, ICustomXMLNode NextSibling,
    CustomXMLNodeType NodeType, string NodeValue);

  /// <summary>
  /// Deletes the current custom XML part from the data store.
  /// If the part contains core properties, the operation is not performed.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.delete?view=office-pia"/>
  public void Delete();

  /// <summary>
  /// Populates this custom XML part from an existing file.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="filePath">Path of the source XML file.</param>
  /// <returns><c>true</c> when the part is loaded successfully; otherwise <c>false</c>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.load?view=office-pia"/>
  public bool Load(string filePath);

  /// <summary>
  /// Populates this custom XML part from an XML string.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="xML">The XML content to load.</param>
  /// <returns><c>true</c> when the XML is loaded successfully; otherwise <c>false</c>.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.loadxml?view=office-pia"/>
  public bool LoadXML(string xML);

  /// <summary>
  /// Selects a collection of nodes from this custom XML part using an XPath expression.
  /// </summary>
  /// <param name="xPath">The XPath expression.</param>
  /// <returns>A collection of matching nodes.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectnodes?view=office-pia"/>
  public ICustomXMLNodes SelectNodes(string xPath);

  /// <summary>
  /// Selects a single node in this custom XML part matching an XPath expression.
  /// </summary>
  /// <param name="xPath">The XPath expression.</param>
  /// <returns>The matching node, if found.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectsinglenode?view=office-pia"/>
  public ICustomXMLNode SelectSingleNode(string xPath);

  #endregion methods
}

