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
      var element = _Element?.GetFirstChild<DXO13DC.LineChartSeries>();
      if (element != null)
        return LineChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.LineChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineChartSeriesConverter.CreateOpenXmlElement<DXO13DC.LineChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
