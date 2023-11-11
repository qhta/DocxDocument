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
      return _Element?.GetObject<DMDC13.SurfaceChartSeries,DXO13DC.SurfaceChartSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.SurfaceChartSeries,DXO13DC.SurfaceChartSeries>(value);
    }
  }
  
}
