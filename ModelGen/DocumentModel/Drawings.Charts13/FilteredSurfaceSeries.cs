namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the FilteredSurfaceSeries Class.
/// </summary>
public partial class FilteredSurfaceSeries: ModelElement<DXO13DC.FilteredSurfaceSeries>
{
  public FilteredSurfaceSeries(): base(){ }
  
  public FilteredSurfaceSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FilteredSurfaceSeries(DXO13DC.FilteredSurfaceSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SurfaceChartSeries.
  /// </summary>
  [DataMember]
  public DMDC13.SurfaceChartSeries? SurfaceChartSeries
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO13DC.SurfaceChartSeries>();
      if (element != null)
        return SurfaceChartSeriesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO13DC.SurfaceChartSeries>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceChartSeriesConverter.CreateOpenXmlElement<DXO13DC.SurfaceChartSeries>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
