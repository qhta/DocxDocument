namespace DocumentModel.Wordprocessing;


/// <summary>
///   Distance between Horizontal Gridlines.
/// </summary>
public partial class DisplayHorizontalDrawingGrid: ModelElement<DXW.DisplayHorizontalDrawingGrid>
{
  public DisplayHorizontalDrawingGrid(): base(){ }
  
  public DisplayHorizontalDrawingGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayHorizontalDrawingGrid(DXW.DisplayHorizontalDrawingGrid openXmlElement): base(openXmlElement) { }
  
}
