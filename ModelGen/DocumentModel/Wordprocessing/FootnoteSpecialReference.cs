namespace DocumentModel.Wordprocessing;


/// <summary>
///   Special Footnote List.
/// </summary>
public partial class FootnoteSpecialReference: ModelElement<DXW.FootnoteSpecialReference>
{
  public FootnoteSpecialReference(): base(){ }
  
  public FootnoteSpecialReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteSpecialReference(DXW.FootnoteSpecialReference openXmlElement): base(openXmlElement) { }
  
}
