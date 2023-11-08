namespace DocumentModel.Wordprocessing;


/// <summary>
///   Increase Priority Of Font Size During Font Substitution.
/// </summary>
public partial class SubFontBySize: ModelElement<DXW.SubFontBySize>
{
  public SubFontBySize(): base(){ }
  
  public SubFontBySize(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubFontBySize(DXW.SubFontBySize openXmlElement): base(openXmlElement) { }
  
}
