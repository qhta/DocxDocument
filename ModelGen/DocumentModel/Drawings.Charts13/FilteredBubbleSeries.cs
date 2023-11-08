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
      var element = _Element?.GetFirstChild<DXO13DC.BubbleChartSeries>();
      if (element != null)
        return BubbleChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.BubbleChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BubbleChartSeriesConverter.CreateOpenXmlElement<DXO13DC.BubbleChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
