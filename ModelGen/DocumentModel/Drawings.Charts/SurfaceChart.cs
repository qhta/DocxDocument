namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Surface Charts.
/// </summary>
public partial class SurfaceChart: ModelElement<DXDC.SurfaceChart>
{
  public SurfaceChart(): base(){ }
  
  public SurfaceChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChart(DXDC.SurfaceChart openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Wireframe.
  /// </summary>
  [DataMember]
  public DMDC.Wireframe? Wireframe
  {
    get
    {
      return _Element?.GetObject<DMDC.Wireframe,DXDC.Wireframe>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Wireframe,DXDC.Wireframe>(value);
    }
  }
  
  [DataMember]
  public DMDC.BandFormats? BandFormats
  {
    get
    {
      return _Element?.GetObject<DMDC.BandFormats,DXDC.BandFormats>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.BandFormats,DXDC.BandFormats>(value);
    }
  }
  
  [DataMember]
  public DMDC.SurfaceChartExtensionList? SurfaceChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.SurfaceChartExtensionList,DXDC.SurfaceChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.SurfaceChartExtensionList,DXDC.SurfaceChartExtensionList>(value);
    }
  }
  
}
