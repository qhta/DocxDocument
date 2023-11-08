namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the SurfaceChartSeries Class.
/// </summary>
public partial class SurfaceChartSeries: ModelElement<DXO13DC.SurfaceChartSeries>
{
  public SurfaceChartSeries(): base(){ }
  
  public SurfaceChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SurfaceChartSeries(DXO13DC.SurfaceChartSeries openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Index.
  /// </summary>
  [DataMember]
  public DMDC.Index? Index
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Index>();
      if (element != null)
        return IndexConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Index>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = IndexConverter.CreateOpenXmlElement<DXDC.Index>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Order.
  /// </summary>
  [DataMember]
  public DMDC.Order? Order
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Order>();
      if (element != null)
        return OrderConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Order>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OrderConverter.CreateOpenXmlElement<DXDC.Order>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Series Text.
  /// </summary>
  [DataMember]
  public DMDC.SeriesText? SeriesText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.SeriesText>();
      if (element != null)
        return SeriesTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SeriesText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesTextConverter.CreateOpenXmlElement<DXDC.SeriesText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ChartShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC.ChartShapeProperties? ChartShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartShapeProperties>();
      if (element != null)
        return ChartShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartShapePropertiesConverter.CreateOpenXmlElement<DXDC.ChartShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PictureOptions.
  /// </summary>
  [DataMember]
  public DMDC.PictureOptions? PictureOptions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PictureOptions>();
      if (element != null)
        return PictureOptionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PictureOptions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PictureOptionsConverter.CreateOpenXmlElement<DXDC.PictureOptions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   CategoryAxisData.
  /// </summary>
  [DataMember]
  public DMDC.CategoryAxisData? CategoryAxisData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.CategoryAxisData>();
      if (element != null)
        return CategoryAxisDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.CategoryAxisData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisDataConverter.CreateOpenXmlElement<DXDC.CategoryAxisData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Values.
  /// </summary>
  [DataMember]
  public DMDC.Values? Values
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Values>();
      if (element != null)
        return ValuesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Values>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValuesConverter.CreateOpenXmlElement<DXDC.Values>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Bubble3D.
  /// </summary>
  [DataMember]
  public DMDC.Bubble3D? Bubble3D
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Bubble3D>();
      if (element != null)
        return Bubble3DConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Bubble3D>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Bubble3DConverter.CreateOpenXmlElement<DXDC.Bubble3D>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   SurfaceSerExtensionList.
  /// </summary>
  [DataMember]
  public DMDC.SurfaceSerExtensionList? SurfaceSerExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.SurfaceSerExtensionList>();
      if (element != null)
        return SurfaceSerExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.SurfaceSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SurfaceSerExtensionListConverter.CreateOpenXmlElement<DXDC.SurfaceSerExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
