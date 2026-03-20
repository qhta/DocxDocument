
namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLPart
{
  public void AddNode
  (CustomXMLNode Parent, string Name, string NamespaceURI, CustomXMLNode NextSibling,
    MsoCustomXMLNodeType NodeType, string NodeValue);
  public void Delete();
  public bool Load(string FilePath);
  public bool LoadXML(string XML);
  public CustomXMLNodes SelectNodes(string XPath);
  public CustomXMLNode SelectSingleNode(string XPath);
}
