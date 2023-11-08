namespace DocumentModel.Word13;


/// <summary>
///   This element specifies that the parent structured document tag is a repeated item. The parent structured document tag MUST be contained within a Repeating Section Structured Document tag and MUST be either Block-Level, Row-Level, or Cell-Level.
/// </summary>
public partial class SdtRepeatedSectionItem: ModelElement<DXO13W.SdtRepeatedSectionItem>
{
  public SdtRepeatedSectionItem(): base(){ }
  
  public SdtRepeatedSectionItem(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtRepeatedSectionItem(DXO13W.SdtRepeatedSectionItem openXmlElement): base(openXmlElement) { }
  
}
