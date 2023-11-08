namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Relative Y Coordinate.
/// </summary>
public partial class YPosition: ModelElement<DXDCD.YPosition>
{
  public YPosition(): base(){ }
  
  public YPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public YPosition(DXDCD.YPosition openXmlElement): base(openXmlElement) { }
  
}
