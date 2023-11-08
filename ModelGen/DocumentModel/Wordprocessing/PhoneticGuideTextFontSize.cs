namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the font size which shall be applied to the phonetic guide text in the contents of this run when displayed.
/// </summary>
public partial class PhoneticGuideTextFontSize: ModelElement<DXW.PhoneticGuideTextFontSize>
{
  public PhoneticGuideTextFontSize(): base(){ }
  
  public PhoneticGuideTextFontSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PhoneticGuideTextFontSize(DXW.PhoneticGuideTextFontSize openXmlElement): base(openXmlElement) { }
  
}
