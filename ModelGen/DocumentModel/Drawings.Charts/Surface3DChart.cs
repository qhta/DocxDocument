namespace DocumentModel.Drawings.Charts;


/// <summary>
///   3D Surface Charts.
/// </summary>
public partial class Surface3DChart: ModelElement<DXDC.Surface3DChart>
{
  public Surface3DChart(): base(){ }
  
  public Surface3DChart(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Surface3DChart(DXDC.Surface3DChart openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get
    {
      return _Element?.GetObject<DMDC.VaryColors,DXDC.VaryColors>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.VaryColors,DXDC.VaryColors>(value);
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
  public DMDC.Surface3DChartExtensionList? Surface3DChartExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDC.Surface3DChartExtensionList,DXDC.Surface3DChartExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.Surface3DChartExtensionList,DXDC.Surface3DChartExtensionList>(value);
    }
  }
  
}
