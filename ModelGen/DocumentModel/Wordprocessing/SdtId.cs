namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a unique numerical ID for the nearest ancestor structured document tag. This ID shall be persisted through multiple sessions (i.e. shall not be changed once specified).
/// </summary>
public partial class SdtId: ModelElement<DXW.SdtId>
{
  public SdtId(): base(){ }
  
  public SdtId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtId(DXW.SdtId openXmlElement): base(openXmlElement) { }
  
}
