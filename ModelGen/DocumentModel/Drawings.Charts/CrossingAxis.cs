namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Crossing Axis ID.
/// </summary>
public partial class CrossingAxis: ModelElement<DXDC.CrossingAxis>
{
  public CrossingAxis(): base(){ }
  
  public CrossingAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CrossingAxis(DXDC.CrossingAxis openXmlElement): base(openXmlElement) { }
  
}
