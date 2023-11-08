namespace DocumentModel.Wordprocessing;


/// <summary>
///   Automatically Hyphenate Document Contents When Displayed.
/// </summary>
public partial class AutoHyphenation: ModelElement<DXW.AutoHyphenation>
{
  public AutoHyphenation(): base(){ }
  
  public AutoHyphenation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AutoHyphenation(DXW.AutoHyphenation openXmlElement): base(openXmlElement) { }
  
}
