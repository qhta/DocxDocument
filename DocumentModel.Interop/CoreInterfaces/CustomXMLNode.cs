
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an XML node in a document's custom XML tree.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode?view=office-pia
/// </remarks>
public partial interface CustomXMLNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Attributes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.attributes?view=office-pia
  /// </remarks>
  public CustomXMLNodes Attributes { get; }
  /// <summary>
  /// Gets the `BaseName` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.basename?view=office-pia
  /// </remarks>
  public string BaseName { get; }
  /// <summary>
  /// Gets the `ChildNodes` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.childnodes?view=office-pia
  /// </remarks>
  public CustomXMLNodes ChildNodes { get; }
  /// <summary>
  /// Gets the `FirstChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.firstchild?view=office-pia
  /// </remarks>
  public CustomXMLNode FirstChild { get; }
  /// <summary>
  /// Gets the `LastChild` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.lastchild?view=office-pia
  /// </remarks>
  public CustomXMLNode LastChild { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.namespaceuri?view=office-pia
  /// </remarks>
  public string NamespaceURI { get; }
  /// <summary>
  /// Gets the `NextSibling` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nextsibling?view=office-pia
  /// </remarks>
  public CustomXMLNode NextSibling { get; }
  /// <summary>
  /// Gets the `NodeType` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodetype?view=office-pia
  /// </remarks>
  public MsoCustomXMLNodeType NodeType { get; }
  /// <summary>
  /// Gets or sets the `NodeValue` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodevalue?view=office-pia
  /// </remarks>
  public string NodeValue { get; set; }
  /// <summary>
  /// Gets the `OwnerDocument` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerdocument?view=office-pia
  /// </remarks>
  public object OwnerDocument { get; }
  /// <summary>
  /// Gets the `OwnerPart` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerpart?view=office-pia
  /// </remarks>
  public CustomXMLPart OwnerPart { get; }
  /// <summary>
  /// Gets the `PreviousSibling` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.previoussibling?view=office-pia
  /// </remarks>
  public CustomXMLNode PreviousSibling { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.parentnode?view=office-pia
  /// </remarks>
  public CustomXMLNode ParentNode { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.text?view=office-pia
  /// </remarks>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `XPath` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xpath?view=office-pia
  /// </remarks>
  public string XPath { get; }
  /// <summary>
  /// Gets the `XML` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xml?view=office-pia
  /// </remarks>
  public string XML { get; }
}
