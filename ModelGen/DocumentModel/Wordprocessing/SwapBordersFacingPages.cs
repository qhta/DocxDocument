namespace DocumentModel.Wordprocessing;


/// <summary>
///   Swap Paragraph Borders on Odd Numbered Pages.
/// </summary>
public partial class SwapBordersFacingPages: ModelElement<DXW.SwapBordersFacingPages>
{
  public SwapBordersFacingPages(): base(){ }
  
  public SwapBordersFacingPages(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SwapBordersFacingPages(DXW.SwapBordersFacingPages openXmlElement): base(openXmlElement) { }
  
}
