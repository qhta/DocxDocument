namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the RoundedCorners Class.
/// </summary>
public partial class RoundedCorners: ModelElement<DXDC.RoundedCorners>
{
  public RoundedCorners(): base(){ }
  
  public RoundedCorners(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RoundedCorners(DXDC.RoundedCorners openXmlElement): base(openXmlElement) { }
  
}
