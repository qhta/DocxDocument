namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Crossing Value.
/// </summary>
public partial class CrossesAt: ModelElement<DXDC.CrossesAt>
{
  public CrossesAt(): base(){ }
  
  public CrossesAt(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CrossesAt(DXDC.CrossesAt openXmlElement): base(openXmlElement) { }
  
}
