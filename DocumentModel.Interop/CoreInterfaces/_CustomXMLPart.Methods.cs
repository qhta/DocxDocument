
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a single custom XML part in a custom XML parts collection.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart?view=office-pia
/// </remarks>
public partial interface _CustomXMLPart
{
  /// <summary>
  /// Adds a node to the XML tree.
  /// </summary>
  /// <param name="Parent">The parent node under which to add the new node.</param>
  /// <param name="Name">The node name.</param>
  /// <param name="NamespaceURI">The namespace URI for the node.</param>
  /// <param name="NextSibling">The sibling node before which to insert the node.</param>
  /// <param name="NodeType">The custom XML node type.</param>
  /// <param name="NodeValue">The node value.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.addnode?view=office-pia
  /// </remarks>
  public void AddNode
  (CustomXMLNode Parent, string Name, string NamespaceURI, CustomXMLNode NextSibling,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  /// <summary>
  /// Deletes the current custom XML part from the data store.
  /// If the part contains core properties, the operation is not performed.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.delete?view=office-pia
  /// </remarks>
  public void Delete();

  /// <summary>
  /// Populates this custom XML part from an existing file.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="FilePath">Path of the source XML file.</param>
  /// <returns><c>true</c> when the part is loaded successfully; otherwise <c>false</c>.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.load?view=office-pia
  /// </remarks>
  public bool Load(string FilePath);

  /// <summary>
  /// Populates this custom XML part from an XML string.
  /// Returns <c>true</c> if the load succeeds.
  /// </summary>
  /// <param name="XML">The XML content to load.</param>
  /// <returns><c>true</c> when the XML is loaded successfully; otherwise <c>false</c>.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.loadxml?view=office-pia
  /// </remarks>
  public bool LoadXML(string XML);

  /// <summary>
  /// Selects a collection of nodes from this custom XML part using an XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression.</param>
  /// <returns>A collection of matching nodes.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectnodes?view=office-pia
  /// </remarks>
  public CustomXMLNodes SelectNodes(string XPath);

  /// <summary>
  /// Selects a single node in this custom XML part matching an XPath expression.
  /// </summary>
  /// <param name="XPath">The XPath expression.</param>
  /// <returns>The matching node, if found.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core._customxmlpart.selectsinglenode?view=office-pia
  /// </remarks>
  public CustomXMLNode SelectSingleNode(string XPath);
}
