namespace DocumentModel.Drawings.ChartDrawing;


/// <summary>
///   Relative X Coordinate.
/// </summary>
public partial class XPosition: ModelElement<DXDCD.XPosition>
{
  public XPosition(): base(){ }
  
  public XPosition(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public XPosition(DXDCD.XPosition openXmlElement): base(openXmlElement) { }
  
}
