
namespace DocumentModel.Interop.Core;

public partial interface CustomXMLNode
{
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
