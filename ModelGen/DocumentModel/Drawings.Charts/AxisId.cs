namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Axis ID.
/// </summary>
public partial class AxisId: ModelElement<DXDC.AxisId>
{
  public AxisId(): base(){ }
  
  public AxisId(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AxisId(DXDC.AxisId openXmlElement): base(openXmlElement) { }
  
}
