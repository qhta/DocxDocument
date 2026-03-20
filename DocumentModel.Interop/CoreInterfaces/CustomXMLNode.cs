
namespace DocumentModel.Interop.Core;

public interface CustomXMLNode: InteropObject
{
  public CustomXMLNodes Attributes { get; }
  public string BaseName { get; }
  public CustomXMLNodes ChildNodes { get; }
  public CustomXMLNode FirstChild { get; }
  public CustomXMLNode LastChild { get; }
  public string NamespaceURI { get; }
  public CustomXMLNode NextSibling { get; }
  public MsoCustomXMLNodeType NodeType { get; }
  public string NodeValue { get; set; }
  public object OwnerDocument { get; }
  public CustomXMLPart OwnerPart { get; }
  public CustomXMLNode PreviousSibling { get; }
  public CustomXMLNode ParentNode { get; }
  public string Text { get; set; }
  public string XPath { get; }
  public string XML { get; }

  public void AppendChildNode
  (string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  public void AppendChildSubtree(string XML);
  public void Delete();
  public bool HasChildNodes();

  public void InsertNodeBefore
  (string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue,
    CustomXMLNode NextSibling);

  public void InsertSubtreeBefore(string XML, CustomXMLNode NextSibling);
  public void RemoveChild(CustomXMLNode Child);

  public void ReplaceChildNode
  (CustomXMLNode OldNode, string Name, string NamespaceURI,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  public void ReplaceChildSubtree(string XML, CustomXMLNode OldNode);
  public CustomXMLNodes SelectNodes(string XPath);
  public CustomXMLNode SelectSingleNode(string XPath);
}
