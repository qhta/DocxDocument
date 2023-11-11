namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the SurfaceChartExtension Class.
/// </summary>
public partial class SurfaceChartExtension: ModelElement<DXDC.SurfaceChartExtension>
{
  public SurfaceChartExtension(): base(){ }
  
  public SurfaceChartExtension(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChartExtension(DXDC.SurfaceChartExtension openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   URI
  /// </summary>
  [DataMember]
  public String? Uri
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Uri);
    }
    set
    {
      _ExistingElement.Uri = StringValueConverter.CreateStringValue(value);
    }
  }
  
  [DataMember]
  public DMDC13.FilteredSurfaceSeries? FilteredSurfaceSeries
  {
    get
    {
      return _Element?.GetObject<DMDC13.FilteredSurfaceSeries,DXO13DC.FilteredSurfaceSeries>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC13.FilteredSurfaceSeries,DXO13DC.FilteredSurfaceSeries>(value);
    }
  }
  
}
