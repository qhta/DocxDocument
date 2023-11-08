namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a picture when displayed in the document.
/// </summary>
public partial class SdtContentPicture: ModelElement<DXW.SdtContentPicture>
{
  public SdtContentPicture(): base(){ }
  
  public SdtContentPicture(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentPicture(DXW.SdtContentPicture openXmlElement): base(openXmlElement) { }
  
}
