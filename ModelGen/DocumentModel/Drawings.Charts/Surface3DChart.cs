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
  
  
  /// <summary>
  ///   VaryColors.
  /// </summary>
  [DataMember]
  public DMDC.VaryColors? VaryColors
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.VaryColors>();
      if (element != null)
        return VaryColorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.VaryColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = VaryColorsConverter.CreateOpenXmlElement<DXDC.VaryColors>(value);
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
  public DMDC.Surface3DChartExtensionList? Surface3DChartExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Surface3DChartExtensionList>();
      if (element != null)
        return Surface3DChartExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Surface3DChartExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Surface3DChartExtensionListConverter.CreateOpenXmlElement<DXDC.Surface3DChartExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
