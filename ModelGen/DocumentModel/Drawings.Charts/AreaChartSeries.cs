namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Area Chart Series.
/// </summary>
public partial class AreaChartSeries: ModelElement<DXDC.AreaChartSeries>
{
  public AreaChartSeries(): base(){ }
  
  public AreaChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AreaChartSeries(DXDC.AreaChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  
  [DataMember]
  public DMDC.DataLabels? DataLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXDC.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
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
  
  [DataMember]
  public DMDC.AreaSerExtensionList? AreaSerExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.AreaSerExtensionList>();
      if (element != null)
        return AreaSerExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.AreaSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AreaSerExtensionListConverter.CreateOpenXmlElement<DXDC.AreaSerExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
