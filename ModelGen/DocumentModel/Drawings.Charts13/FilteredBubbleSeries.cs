namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredBubbleSeries Class.
/// </summary>
public partial class FilteredBubbleSeries: ModelElement<DXO13DC.FilteredBubbleSeries>
{
  public FilteredBubbleSeries(): base(){ }
  
  public FilteredBubbleSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredBubbleSeries(DXO13DC.FilteredBubbleSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   BubbleChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.BubbleChartSeries? BubbleChartSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.BubbleChartSeries,DXO13DC.BubbleChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.BubbleChartSeries,DXO13DC.BubbleChartSeries>(value);
    }
  }
  
}
