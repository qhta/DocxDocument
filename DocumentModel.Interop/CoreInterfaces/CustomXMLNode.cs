
namespace DocumentModel.Interop.Core;

public partial interface CustomXMLNode: InteropObject
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
}
