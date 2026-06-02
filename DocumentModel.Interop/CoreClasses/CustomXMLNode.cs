
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents an XML node in a document's custom XML tree.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode?view=office-pia"/>
public partial class CustomXMLNode: InteropObject
{
  /// <summary>
  /// Gets or sets the `Attributes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.attributes?view=office-pia"/>
  public CustomXMLNodes Attributes { get; }
  /// <summary>
  /// Gets the `BaseName` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.basename?view=office-pia"/>
  public string BaseName { get; }
  /// <summary>
  /// Gets the `ChildNodes` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.childnodes?view=office-pia"/>
  public CustomXMLNodes ChildNodes { get; }
  /// <summary>
  /// Gets the `FirstChild` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.firstchild?view=office-pia"/>
  public CustomXMLNode FirstChild { get; }
  /// <summary>
  /// Gets the `LastChild` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.lastchild?view=office-pia"/>
  public CustomXMLNode LastChild { get; }
  /// <summary>
  /// Gets the `NamespaceURI` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.namespaceuri?view=office-pia"/>
  public string NamespaceURI { get; }
  /// <summary>
  /// Gets the `NextSibling` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nextsibling?view=office-pia"/>
  public CustomXMLNode NextSibling { get; }
  /// <summary>
  /// Gets the `NodeType` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodetype?view=office-pia"/>
  public CustomXMLNodeType NodeType { get; }
  /// <summary>
  /// Gets or sets the `NodeValue` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.nodevalue?view=office-pia"/>
  public string NodeValue { get; set; }
  /// <summary>
  /// Gets the `OwnerDocument` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerdocument?view=office-pia"/>
  public object OwnerDocument { get; }
  /// <summary>
  /// Gets the `OwnerPart` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.ownerpart?view=office-pia"/>
  public CustomXMLPart OwnerPart { get; }
  /// <summary>
  /// Gets the `PreviousSibling` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.previoussibling?view=office-pia"/>
  public CustomXMLNode PreviousSibling { get; }
  /// <summary>
  /// Gets the `ParentNode` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.parentnode?view=office-pia"/>
  public CustomXMLNode ParentNode { get; }
  /// <summary>
  /// Gets or sets the `Text` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.text?view=office-pia"/>
  public string Text { get; set; }
  /// <summary>
  /// Gets the `XPath` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xpath?view=office-pia"/>
  public string XPath { get; }
  /// <summary>
  /// Gets the `XML` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.xml?view=office-pia"/>
  public string XML { get; }


  #region methods

/// <summary>
  /// Invokes `AppendChildNode`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.appendchildnode?view=office-pia"/>
  public void AppendChildNode
  (string Name, string NamespaceURI,
    CustomXMLNodeType NodeType, string NodeValue) { throw new NotImplementedException(); }
  /// <summary>
  /// Adds a subtree as the last child under the current element node.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.appendchildsubtree?view=office-pia"/>
  public void AppendChildSubtree(string XML) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Returns true if the current element node has child element nodes.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.haschildnodes?view=office-pia"/>
  public bool HasChildNodes() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertNodeBefore`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <param name="NextSibling">The `NextSibling` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.insertnodebefore?view=office-pia"/>
  public void InsertNodeBefore
  (string Name, string NamespaceURI,
    CustomXMLNodeType NodeType, string NodeValue,
    CustomXMLNode NextSibling) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `InsertSubtreeBefore`.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="NextSibling">The `NextSibling` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.insertsubtreebefore?view=office-pia"/>
  public void InsertSubtreeBefore(string XML, CustomXMLNode NextSibling) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `RemoveChild`.
  /// </summary>
  /// <param name="Child">The `Child` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.removechild?view=office-pia"/>
  public void RemoveChild(CustomXMLNode Child) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ReplaceChildNode`.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.replacechildnode?view=office-pia"/>
  public void ReplaceChildNode
  (CustomXMLNode OldNode, string Name, string NamespaceURI,
    CustomXMLNodeType NodeType, string NodeValue) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ReplaceChildSubtree`.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.replacechildsubtree?view=office-pia"/>
  public void ReplaceChildSubtree(string XML, CustomXMLNode OldNode) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SelectNodes`.
  /// </summary>
  /// <param name="XPath">The `XPath` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.selectnodes?view=office-pia"/>
  public CustomXMLNodes SelectNodes(string XPath) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `SelectSingleNode`.
  /// </summary>
  /// <param name="XPath">The `XPath` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.selectsinglenode?view=office-pia"/>
  public CustomXMLNode SelectSingleNode(string XPath) { throw new NotImplementedException(); }

  #endregion methods
}

