namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Point Count.
/// </summary>
public partial class PointCount: ModelElement<DXDC.PointCount>
{
  public PointCount(): base(){ }
  
  public PointCount(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PointCount(DXDC.PointCount openXmlElement): base(openXmlElement) { }
  
}
