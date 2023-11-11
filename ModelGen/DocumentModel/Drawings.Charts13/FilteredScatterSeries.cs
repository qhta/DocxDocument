namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredScatterSeries Class.
/// </summary>
public partial class FilteredScatterSeries: ModelElement<DXO13DC.FilteredScatterSeries>
{
  public FilteredScatterSeries(): base(){ }
  
  public FilteredScatterSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredScatterSeries(DXO13DC.FilteredScatterSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ScatterChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.ScatterChartSeries? ScatterChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.ScatterChartSeries,DXO13DC.ScatterChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.ScatterChartSeries,DXO13DC.ScatterChartSeries>(value);
    }
  }
  
}
