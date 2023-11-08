namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the nearest ancestor structured document tag shall be a rich text box when displayed in the document.
/// </summary>
public partial class SdtContentRichText: ModelElement<DXW.SdtContentRichText>
{
  public SdtContentRichText(): base(){ }
  
  public SdtContentRichText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtContentRichText(DXW.SdtContentRichText openXmlElement): base(openXmlElement) { }
  
}
