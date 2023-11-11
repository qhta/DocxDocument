namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredPieSeries Class.
/// </summary>
public partial class FilteredPieSeries: ModelElement<DXO13DC.FilteredPieSeries>
{
  public FilteredPieSeries(): base(){ }
  
  public FilteredPieSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredPieSeries(DXO13DC.FilteredPieSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   PieChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.PieChartSeries? PieChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.PieChartSeries,DXO13DC.PieChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.PieChartSeries,DXO13DC.PieChartSeries>(value);
    }
  }
  
}
