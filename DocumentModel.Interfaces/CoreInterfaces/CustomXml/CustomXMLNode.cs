
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an XML node in a document's custom XML tree.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode?view=office-pia"/>
public partial interface CustomXMLNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Attributes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.attributes?view=office-pia"/>
  public CustomXMLNodes Attributes { get; }
  /// <summary>
  /// Gets the `BaseName` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.basename?view=office-pia"/>
  public string BaseName { get; }
  /// <summary>
  /// Gets the `ChildNodes` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.childnodes?view=office-pia"/>
  public CustomXMLNodes ChildNodes { get; }
  /// <summary>
  /// Gets the `FirstChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.firstchild?view=office-pia"/>
  public CustomXMLNode FirstChild { get; }
  /// <summary>
  /// Gets the `LastChild` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.lastchild?view=office-pia"/>
  public CustomXMLNode LastChild { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
  /// <summary>
  /// Gets the `NextSibling` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nextsibling?view=office-pia"/>
  public CustomXMLNode NextSibling { get; }
  /// <summary>
  /// Gets the `NodeType` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodetype?view=office-pia"/>
  public CustomXMLNodeType NodeType { get; }
  /// <summary>
  /// Gets or sets the `NodeValue` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodevalue?view=office-pia"/>
  public string NodeValue { get; set; }
  /// <summary>
  /// Gets the `OwnerDocument` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerdocument?view=office-pia"/>
  public object OwnerDocument { get; }
  /// <summary>
  /// Gets the `OwnerPart` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerpart?view=office-pia"/>
  public CustomXMLPart OwnerPart { get; }
  /// <summary>
  /// Gets the `PreviousSibling` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.previoussibling?view=office-pia"/>
  public CustomXMLNode PreviousSibling { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.parentnode?view=office-pia"/>
  public CustomXMLNode ParentNode { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `XPath` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xpath?view=office-pia"/>
  public string XPath { get; }
  /// <summary>
  /// Gets the `XML` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xml?view=office-pia"/>
  public string XML { get; }
}

