
namespace DocumentModel.Interop.Core;

public interface _CustomXMLPart: InteropObject
{
  CustomXMLNode DocumentElement { get; }
  string Id { get; }
  string NamespaceURI { get; }
  CustomXMLSchemaCollection SchemaCollection { get; set; }
  CustomXMLPrefixMappings NamespaceManager { get; }
  string XML { get; }

  void AddNode
  (CustomXMLNode Parent, string Name, string NamespaceURI, CustomXMLNode NextSibling,
    MsoCustomXMLNodeType NodeType, string NodeValue);

  void Delete();
  bool Load(string FilePath);
  bool LoadXML(string XML);
  CustomXMLNodes SelectNodes(string XPath);
  CustomXMLNode SelectSingleNode(string XPath);
  CustomXMLValidationErrors Errors { get; }
  bool BuiltIn { get; }
}