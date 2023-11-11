namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredRadarSeries Class.
/// </summary>
public partial class FilteredRadarSeries: ModelElement<DXO13DC.FilteredRadarSeries>
{
  public FilteredRadarSeries(): base(){ }
  
  public FilteredRadarSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredRadarSeries(DXO13DC.FilteredRadarSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RadarChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.RadarChartSeries? RadarChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.RadarChartSeries,DXO13DC.RadarChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.RadarChartSeries,DXO13DC.RadarChartSeries>(value);
    }
  }
  
}
