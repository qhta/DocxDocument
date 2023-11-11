namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredLineSeriesExtension Class.
/// </summary>
public partial class FilteredLineSeriesExtension: ModelElement<DXO13DC.FilteredLineSeriesExtension>
{
  public FilteredLineSeriesExtension(): base(){ }
  
  public FilteredLineSeriesExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredLineSeriesExtension(DXO13DC.FilteredLineSeriesExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   LineChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.LineChartSeries? LineChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.LineChartSeries,DXO13DC.LineChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.LineChartSeries,DXO13DC.LineChartSeries>(value);
    }
  }
  
}
