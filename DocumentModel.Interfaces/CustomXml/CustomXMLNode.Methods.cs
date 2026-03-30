
namespace DocumentModel.CustomXml;

/// <summary>
/// Represents an XML node in a document's custom XML tree.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode?view=office-pia"/>
public partial interface CustomXMLNode: IModelObject
{
  /// <summary>
  /// Invokes `AppendChildNode`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.appendchildnode?view=office-pia"/>
  public void AppendChildNode
  (string Name, string NamespaceURI,
    XMLNodeType NodeType, string NodeValue);
  /// <summary>
  /// Adds a subtree as the last child under the current element node.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.appendchildsubtree?view=office-pia"/>
  public void AppendChildSubtree(string XML);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.delete?view=office-pia"/>
  public void Delete();
  /// <summary>
  /// Returns true if the current element node has child element nodes.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.haschildnodes?view=office-pia"/>
  public bool HasChildNodes();
  /// <summary>
  /// Invokes `InsertNodeBefore`.
  /// </summary>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <param name="NextSibling">The `NextSibling` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.insertnodebefore?view=office-pia"/>
  public void InsertNodeBefore
  (string Name, string NamespaceURI,
    XMLNodeType NodeType, string NodeValue,
    CustomXMLNode NextSibling);
  /// <summary>
  /// Invokes `InsertSubtreeBefore`.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="NextSibling">The `NextSibling` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.insertsubtreebefore?view=office-pia"/>
  public void InsertSubtreeBefore(string XML, CustomXMLNode NextSibling);
  /// <summary>
  /// Invokes `RemoveChild`.
  /// </summary>
  /// <param name="Child">The `Child` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.removechild?view=office-pia"/>
  public void RemoveChild(CustomXMLNode Child);
  /// <summary>
  /// Invokes `ReplaceChildNode`.
  /// </summary>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <param name="Name">The `Name` parameter.</param>
  /// <param name="NamespaceURI">The `NamespaceURI` parameter.</param>
  /// <param name="NodeType">The `NodeType` parameter.</param>
  /// <param name="NodeValue">The `NodeValue` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.replacechildnode?view=office-pia"/>
  public void ReplaceChildNode
  (CustomXMLNode OldNode, string Name, string NamespaceURI,
    XMLNodeType NodeType, string NodeValue);
  /// <summary>
  /// Invokes `ReplaceChildSubtree`.
  /// </summary>
  /// <param name="XML">The `XML` parameter.</param>
  /// <param name="OldNode">The `OldNode` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.replacechildsubtree?view=office-pia"/>
  public void ReplaceChildSubtree(string XML, CustomXMLNode OldNode);
  /// <summary>
  /// Invokes `SelectNodes`.
  /// </summary>
  /// <param name="XPath">The `XPath` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.selectnodes?view=office-pia"/>
  public CustomXMLNodes SelectNodes(string XPath);
  /// <summary>
  /// Invokes `SelectSingleNode`.
  /// </summary>
  /// <param name="XPath">The `XPath` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.customxmlnode.selectsinglenode?view=office-pia"/>
  public CustomXMLNode SelectSingleNode(string XPath);
}

