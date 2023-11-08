namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Point List.
/// </summary>
public partial class PointList: ModelElement<DXDDD.PointList>
{
  public PointList(): base(){ }
  
  public PointList(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PointList(DXDDD.PointList openXmlElement): base(openXmlElement) { }
  
}
