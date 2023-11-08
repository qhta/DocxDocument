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
      var element = _Element?.GetFirstChild<DXO13DC.ScatterChartSeries>();
      if (element != null)
        return ScatterChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.ScatterChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterChartSeriesConverter.CreateOpenXmlElement<DXO13DC.ScatterChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
