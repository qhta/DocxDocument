namespace DocumentModel.Wordprocessing;


/// <summary>
///   Always Move Paragraph Mark to Page after a Page Break.
/// </summary>
public partial class SplitPageBreakAndParagraphMark: ModelElement<DXW.SplitPageBreakAndParagraphMark>
{
  public SplitPageBreakAndParagraphMark(): base(){ }
  
  public SplitPageBreakAndParagraphMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SplitPageBreakAndParagraphMark(DXW.SplitPageBreakAndParagraphMark openXmlElement): base(openXmlElement) { }
  
}
