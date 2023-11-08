namespace DocumentModel.Wordprocessing;


/// <summary>
///   Drawing Grid Vertical Origin Point.
/// </summary>
public partial class DrawingGridVerticalOrigin: ModelElement<DXW.DrawingGridVerticalOrigin>
{
  public DrawingGridVerticalOrigin(): base(){ }
  
  public DrawingGridVerticalOrigin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public DrawingGridVerticalOrigin(DXW.DrawingGridVerticalOrigin openXmlElement): base(openXmlElement) { }
  
}
