namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be of type citation.
/// </summary>
public partial class SdtContentCitation: ModelElement<DXW.SdtContentCitation>
{
  public SdtContentCitation(): base(){ }
  
  public SdtContentCitation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentCitation(DXW.SdtContentCitation openXmlElement): base(openXmlElement) { }
  
}
