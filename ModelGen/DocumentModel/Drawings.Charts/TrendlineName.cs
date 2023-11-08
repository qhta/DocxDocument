namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Trendline Name.
/// </summary>
public partial class TrendlineName: ModelElement<DXDC.TrendlineName>
{
  public TrendlineName(): base(){ }
  
  public TrendlineName(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TrendlineName(DXDC.TrendlineName openXmlElement): base(openXmlElement) { }
  
}
