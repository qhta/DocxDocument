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
      var element = _Element?.GetFirstChild<DXO13DC.BarChartSeries>();
      if (element != null)
        return BarChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.BarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BarChartSeriesConverter.CreateOpenXmlElement<DXO13DC.BarChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
