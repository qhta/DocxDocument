namespace DocumentModel.CustomXml;


/// <summary>
///   Set of Associated XML Schemas.
/// </summary>
public partial class SchemaReferences: ModelElement<DXCXDP.SchemaReferences>
{
  public SchemaReferences(): base(){ }
  
  public SchemaReferences(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SchemaReferences(DXCXDP.SchemaReferences openXmlElement): base(openXmlElement) { }
  
}
