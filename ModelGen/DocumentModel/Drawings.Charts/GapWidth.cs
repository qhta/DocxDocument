namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Gap Width.
/// </summary>
public partial class GapWidth: ModelElement<DXDC.GapWidth>
{
  public GapWidth(): base(){ }
  
  public GapWidth(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GapWidth(DXDC.GapWidth openXmlElement): base(openXmlElement) { }
  
}
