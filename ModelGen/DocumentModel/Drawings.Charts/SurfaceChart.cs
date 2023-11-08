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
      var element = _Element?.GetFirstChild<DXDC.Wireframe>();
      if (element != null)
        return WireframeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Wireframe>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = WireframeConverter.CreateOpenXmlElement<DXDC.Wireframe>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.BandFormats? BandFormats
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.BandFormats>();
      if (element != null)
        return BandFormatsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.BandFormats>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BandFormatsConverter.CreateOpenXmlElement<DXDC.BandFormats>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.SurfaceChartExtensionList? SurfaceChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.SurfaceChartExtensionList>();
      if (element != null)
        return SurfaceChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SurfaceChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceChartExtensionListConverter.CreateOpenXmlElement<DXDC.SurfaceChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
