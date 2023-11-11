namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredBarSeries Class.
/// </summary>
public partial class FilteredBarSeries: ModelElement<DXO13DC.FilteredBarSeries>
{
  public FilteredBarSeries(): base(){ }
  
  public FilteredBarSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredBarSeries(DXO13DC.FilteredBarSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BarChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.BarChartSeries? BarChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.BarChartSeries,DXO13DC.BarChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.BarChartSeries,DXO13DC.BarChartSeries>(value);
    }
  }
  
}
