namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredAreaSeries Class.
/// </summary>
public partial class FilteredAreaSeries: ModelElement<DXO13DC.FilteredAreaSeries>
{
  public FilteredAreaSeries(): base(){ }
  
  public FilteredAreaSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredAreaSeries(DXO13DC.FilteredAreaSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   AreaChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.AreaChartSeries? AreaChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.AreaChartSeries,DXO13DC.AreaChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.AreaChartSeries,DXO13DC.AreaChartSeries>(value);
    }
  }
  
}
