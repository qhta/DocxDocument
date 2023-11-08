namespace DocumentModel.Wordprocessing;


/// <summary>
///   Footnote Reference Mark.
/// </summary>
public partial class FootnoteReferenceMark: ModelElement<DXW.FootnoteReferenceMark>
{
  public FootnoteReferenceMark(): base(){ }
  
  public FootnoteReferenceMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FootnoteReferenceMark(DXW.FootnoteReferenceMark openXmlElement): base(openXmlElement) { }
  
}
