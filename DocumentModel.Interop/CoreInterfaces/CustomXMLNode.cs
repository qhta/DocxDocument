
namespace DocumentModel.Interop.Core;

public interface CustomXMLNode: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  CustomXMLNodes Attributes { get; }
  string BaseName { get; }
  CustomXMLNodes ChildNodes { get; }
  CustomXMLNode FirstChild { get; }
  CustomXMLNode LastChild { get; }
  string NamespaceURI { get; }
  CustomXMLNode NextSibling { get; }
  MsoCustomXMLNodeType NodeType { get; }
  string NodeValue { get; set; }
  object OwnerDocument { get; }
  CustomXMLPart OwnerPart { get; }
  CustomXMLNode PreviousSibling { get; }
  CustomXMLNode ParentNode { get; }
  string Text { get; set; }
  string XPath { get; }
  string XML { get; }

  void AppendChildNode
  (string Name = "", string NamespaceURI = "",
    MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement, string NodeValue = "");

  void AppendChildSubtree(string XML);
  void Delete();
  bool HasChildNodes();

  void InsertNodeBefore
  (string Name = "", string NamespaceURI = "",
    MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement, string NodeValue = "",
    CustomXMLNode NextSibling = null);

  void InsertSubtreeBefore(string XML, CustomXMLNode NextSibling = null);
  void RemoveChild(CustomXMLNode Child);

  void ReplaceChildNode
  (CustomXMLNode OldNode, string Name = "", string NamespaceURI = "",
    MsoCustomXMLNodeType NodeType = MsoCustomXMLNodeType.msoCustomXMLNodeElement, string NodeValue = "");

  void ReplaceChildSubtree(string XML, CustomXMLNode OldNode);
  CustomXMLNodes SelectNodes(string XPath);
  CustomXMLNode SelectSingleNode(string XPath);
}