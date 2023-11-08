namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the font size which shall be applied to the base text of this phonetic guide text when displayed. If this element disagrees with the run properties on the phonetic guide base text rubyBase element, then this property shall be ignored and the sz element in that run shall determine the size of the phonetic guide base text.
/// </summary>
public partial class PhoneticGuideBaseTextSize: ModelElement<DXW.PhoneticGuideBaseTextSize>
{
  public PhoneticGuideBaseTextSize(): base(){ }
  
  public PhoneticGuideBaseTextSize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PhoneticGuideBaseTextSize(DXW.PhoneticGuideBaseTextSize openXmlElement): base(openXmlElement) { }
  
}
