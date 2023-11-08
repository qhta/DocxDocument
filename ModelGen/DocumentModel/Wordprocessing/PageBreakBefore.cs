namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that the contents of this paragraph are rendered on the start of a new page.
/// </summary>
public partial class PageBreakBefore: ModelElement<DXW.PageBreakBefore>
{
  public PageBreakBefore(): base(){ }
  
  public PageBreakBefore(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageBreakBefore(DXW.PageBreakBefore openXmlElement): base(openXmlElement) { }
  
}
