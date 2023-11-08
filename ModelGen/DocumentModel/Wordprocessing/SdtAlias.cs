namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the friendly name associated with the current structured document tag. The string representing the friendly name shall be stored on this element's val attribute.
/// </summary>
public partial class SdtAlias: ModelElement<DXW.SdtAlias>
{
  public SdtAlias(): base(){ }
  
  public SdtAlias(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtAlias(DXW.SdtAlias openXmlElement): base(openXmlElement) { }
  
}
