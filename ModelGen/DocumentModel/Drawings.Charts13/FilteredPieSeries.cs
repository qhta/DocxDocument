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
      var element = _Element?.GetFirstChild<DXO13DC.PieChartSeries>();
      if (element != null)
        return PieChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.PieChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PieChartSeriesConverter.CreateOpenXmlElement<DXO13DC.PieChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
