namespace DocumentModel.Drawings;


/// <summary>
///   Scheme Color
/// </summary>
public partial class SchemeColorValues: ModelElement<DXD.SchemeColorValues>
{
  public SchemeColorValues(): base(){ }
  
  public SchemeColorValues(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SchemeColorValues(DXD.SchemeColorValues openXmlElement): base(openXmlElement) { }
  
}
