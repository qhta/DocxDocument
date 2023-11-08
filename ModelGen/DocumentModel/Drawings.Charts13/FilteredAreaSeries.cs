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
      var element = _Element?.GetFirstChild<DXO13DC.AreaChartSeries>();
      if (element != null)
        return AreaChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.AreaChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AreaChartSeriesConverter.CreateOpenXmlElement<DXO13DC.AreaChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
