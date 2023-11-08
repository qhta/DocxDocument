namespace DocumentModel.Wordprocessing;


/// <summary>
///   Emulate Word 6.x/95/97 Footnote Placement.
/// </summary>
public partial class FootnoteLayoutLikeWord8: ModelElement<DXW.FootnoteLayoutLikeWord8>
{
  public FootnoteLayoutLikeWord8(): base(){ }
  
  public FootnoteLayoutLikeWord8(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteLayoutLikeWord8(DXW.FootnoteLayoutLikeWord8 openXmlElement): base(openXmlElement) { }
  
}
