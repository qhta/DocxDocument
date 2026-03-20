
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a node in a custom XML part.
/// A node can be an element, attribute, comment, or processing instruction.
/// The CustomXMLNode object is the root of the custom XML object model.
/// It provides methods and properties for working with the nodes in a custom XML part.
/// </summary>
public interface CustomXMLNode: InteropObject
{
  /// <summary>
  /// Gets a CustomXMLNode collection representing the attributes of the current element in the current node. 
  /// </summary>
  public CustomXMLNodes Attributes { get; }
  /// <summary>
  /// Gets the base name of the node without the namespace prefix, if one exists,
  /// in the Document Object Model (DOM).
  /// </summary>
  public string BaseName { get; }
  /// <summary>
  /// Gets the unique address identifier for the namespace of the CustomXMLNode object.
  /// </summary>
  public string NamespaceURI { get; }
  /// <summary>
  /// Gets a CustomXMLNodes collection containing all the child elements of the current node.
  /// </summary>
  public CustomXMLNodes ChildNodes { get; }
  /// <summary>
  /// Gets a CustomXMLNode object corresponding to the first child element of the current node.
  /// </summary>
  public CustomXMLNode? FirstChild { get; }
  /// <summary>
  /// Gets a CustomXMLNode object corresponding to the last child element of the current node.
  /// </summary>
  public CustomXMLNode LastChild { get; }
  /// <summary>
  /// Gets the next sibling node (element, comment, or processing instruction) of the current node.
  /// </summary>
  public CustomXMLNode? NextSibling { get; }
  public MsoCustomXMLNodeType NodeType { get; }
  public string NodeValue { get; set; }
  public object OwnerDocument { get; }
  public CustomXMLPart OwnerPart { get; }
  public CustomXMLNode PreviousSibling { get; }
  public CustomXMLNode ParentNode { get; }
  public string Text { get; set; }
  public string XPath { get; }
  public string XML { get; }

  void AppendChildNode
  (string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  public void AppendChildSubtree(string XML);
  public void Delete();
  public bool HasChildNodes();

  void InsertNodeBefore
  (string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue,
    CustomXMLNode NextSibling);

  public void InsertSubtreeBefore(string XML, CustomXMLNode NextSibling);
  public void RemoveChild(CustomXMLNode Child);

  void ReplaceChildNode
  (CustomXMLNode OldNode, string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  public void ReplaceChildSubtree(string XML, CustomXMLNode OldNode);
  public CustomXMLNodes SelectNodes(string XPath);
  public CustomXMLNode SelectSingleNode(string XPath);
}
