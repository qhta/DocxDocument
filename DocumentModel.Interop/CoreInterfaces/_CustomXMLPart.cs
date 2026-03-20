
namespace DocumentModel.Interop.Core;

public partial interface _CustomXMLPart: InteropObject
{
  public CustomXMLNode DocumentElement { get; }
  public string Id { get; }
  public string NamespaceURI { get; }
  public CustomXMLSchemaCollection SchemaCollection { get; set; }
  public CustomXMLPrefixMappings NamespaceManager { get; }
  public string XML { get; }
  public CustomXMLValidationErrors Errors { get; }
  public bool BuiltIn { get; }
}
