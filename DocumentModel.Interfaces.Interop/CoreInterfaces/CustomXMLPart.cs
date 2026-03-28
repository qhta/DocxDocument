
namespace DocumentModel.Interop.Core;

public interface CustomXMLPart: InteropObject
{
  public CustomXMLNode DocumentElement { get; }
  public string Id { get; }
  public string NamespaceURI { get; }
  public CustomXMLSchemaCollection SchemaCollection { get; set; }
  public CustomXMLPrefixMappings NamespaceManager { get; }
  public string XML { get; }

  void AddNode
  (CustomXMLNode Parent, string Name, string NamespaceURI, CustomXMLNode NextSibling,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  public void Delete();
  public bool Load(string FilePath);
  public bool LoadXML(string XML);
  public CustomXMLNodes SelectNodes(string XPath);
  public CustomXMLNode SelectSingleNode(string XPath);
  public CustomXMLValidationErrors Errors { get; }
  public bool BuiltIn { get; }
}
