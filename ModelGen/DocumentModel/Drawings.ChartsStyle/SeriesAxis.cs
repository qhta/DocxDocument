namespace DocumentModel.Drawings.ChartsStyle;


/// <summary>
///   Defines the SeriesAxis Class.
/// </summary>
public partial class SeriesAxis: ModelElement<DXO13DCS.SeriesAxis>
{
  public SeriesAxis(): base(){ }
  
  public SeriesAxis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SeriesAxis(DXO13DCS.SeriesAxis openXmlElement): base(openXmlElement) { }
  
}
