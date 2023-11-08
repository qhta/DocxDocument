namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredRadarSeries Class.
/// </summary>
public partial class FilteredRadarSeries: ModelElement<DXO13DC.FilteredRadarSeries>
{
  public FilteredRadarSeries(): base(){ }
  
  public FilteredRadarSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredRadarSeries(DXO13DC.FilteredRadarSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   RadarChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.RadarChartSeries? RadarChartSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.RadarChartSeries>();
      if (element != null)
        return RadarChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.RadarChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RadarChartSeriesConverter.CreateOpenXmlElement<DXO13DC.RadarChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
