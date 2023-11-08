namespace DocumentModel.Wordprocessing;


/// <summary>
///   Do Not Use Space Before On First Line After a Page Break.
/// </summary>
public partial class SuppressSpacingBeforeAfterPageBreak: ModelElement<DXW.SuppressSpacingBeforeAfterPageBreak>
{
  public SuppressSpacingBeforeAfterPageBreak(): base(){ }
  
  public SuppressSpacingBeforeAfterPageBreak(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SuppressSpacingBeforeAfterPageBreak(DXW.SuppressSpacingBeforeAfterPageBreak openXmlElement): base(openXmlElement) { }
  
}
