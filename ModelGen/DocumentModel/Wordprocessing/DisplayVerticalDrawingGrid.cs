namespace DocumentModel.Wordprocessing;


/// <summary>
///   Distance between Vertical Gridlines.
/// </summary>
public partial class DisplayVerticalDrawingGrid: ModelElement<DXW.DisplayVerticalDrawingGrid>
{
  public DisplayVerticalDrawingGrid(): base(){ }
  
  public DisplayVerticalDrawingGrid(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DisplayVerticalDrawingGrid(DXW.DisplayVerticalDrawingGrid openXmlElement): base(openXmlElement) { }
  
}
