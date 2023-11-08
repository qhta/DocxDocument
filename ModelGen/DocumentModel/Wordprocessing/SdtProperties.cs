namespace DocumentModel.Wordprocessing;


/// <summary>
///   Structured Document Tag Properties.
/// </summary>
public partial class SdtProperties: ModelElement<DXW.SdtProperties>
{
  public SdtProperties(): base(){ }
  
  public SdtProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtProperties(DXW.SdtProperties openXmlElement): base(openXmlElement) { }
  
}
