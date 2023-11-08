namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the ScatterChartSeries Class.
/// </summary>
public partial class ScatterChartSeries: ModelElement<DXDC.ScatterChartSeries>
{
  public ScatterChartSeries(): base(){ }
  
  public ScatterChartSeries(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ScatterChartSeries(DXDC.ScatterChartSeries openXmlElement): base(openXmlElement) { }
  
  
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
  ///   Marker.
  /// </summary>
  [DataMember]
  public DMDC.Marker? Marker
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Marker>();
      if (element != null)
        return MarkerConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Marker>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MarkerConverter.CreateOpenXmlElement<DXDC.Marker>(value);
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
  public DMDC.XValues? XValues
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.XValues>();
      if (element != null)
        return XValuesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.XValues>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = XValuesConverter.CreateOpenXmlElement<DXDC.XValues>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.YValues? YValues
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.YValues>();
      if (element != null)
        return YValuesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.YValues>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = YValuesConverter.CreateOpenXmlElement<DXDC.YValues>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Smooth? Smooth
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Smooth>();
      if (element != null)
        return SmoothConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Smooth>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SmoothConverter.CreateOpenXmlElement<DXDC.Smooth>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ScatterSerExtensionList? ScatterSerExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ScatterSerExtensionList>();
      if (element != null)
        return ScatterSerExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ScatterSerExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ScatterSerExtensionListConverter.CreateOpenXmlElement<DXDC.ScatterSerExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
