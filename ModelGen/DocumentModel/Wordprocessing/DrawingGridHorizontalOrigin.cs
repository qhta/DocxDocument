namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drawing Grid Horizontal Origin Point.
/// </summary>
public partial class DrawingGridHorizontalOrigin: ModelElement<DXW.DrawingGridHorizontalOrigin>
{
  public DrawingGridHorizontalOrigin(): base(){ }
  
  public DrawingGridHorizontalOrigin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DrawingGridHorizontalOrigin(DXW.DrawingGridHorizontalOrigin openXmlElement): base(openXmlElement) { }
  
}
