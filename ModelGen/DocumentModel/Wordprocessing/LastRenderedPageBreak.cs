namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that this position delimited the end of a page when this document was last saved by an application which paginates its content.
/// </summary>
public partial class LastRenderedPageBreak: ModelElement<DXW.LastRenderedPageBreak>
{
  public LastRenderedPageBreak(): base(){ }
  
  public LastRenderedPageBreak(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LastRenderedPageBreak(DXW.LastRenderedPageBreak openXmlElement): base(openXmlElement) { }
  
}
