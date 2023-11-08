namespace DocumentModel.ExtendedProperties;


/// <summary>
///   Document Security.
/// </summary>
public partial class DocumentSecurity: ModelElement<DXEP.DocumentSecurity>
{
  public DocumentSecurity(): base(){ }
  
  public DocumentSecurity(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DocumentSecurity(DXEP.DocumentSecurity openXmlElement): base(openXmlElement) { }
  
}
