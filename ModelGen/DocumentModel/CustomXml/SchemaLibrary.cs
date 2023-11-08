namespace DocumentModel.CustomXml;


/// <summary>
///   Embedded Custom XML Schema Supplementary Data.
/// </summary>
public partial class SchemaLibrary: ModelElement<DXCXSR.SchemaLibrary>
{
  public SchemaLibrary(): base(){ }
  
  public SchemaLibrary(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SchemaLibrary(DXCXSR.SchemaLibrary openXmlElement): base(openXmlElement) { }
  
}
