namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the DocumentConformance enumeration.
/// </summary>
public partial class DocumentConformance: ModelElement<DXW.DocumentConformance>
{
  public DocumentConformance(): base(){ }
  
  public DocumentConformance(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentConformance(DXW.DocumentConformance openXmlElement): base(openXmlElement) { }
  
}
