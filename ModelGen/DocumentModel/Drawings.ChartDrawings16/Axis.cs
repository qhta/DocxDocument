namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Axis Class.
/// </summary>
public partial class Axis: ModelElement<DXO16DCD.Axis>
{
  public Axis(): base(){ }
  
  public Axis(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Axis(DXO16DCD.Axis openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Id
  {
    get
    {
      return _Element?.Id?.Value;
    }
    set
    {
      _ExistingElement.Id = value;
    }
  }
  
  
  /// <summary>
  ///   hidden, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Boolean? Hidden
  {
    get
    {
      return _Element?.Hidden?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Hidden = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Hidden = null;
    }
  }
  
  [DataMember]
  public DMDCD16.CategoryAxisScaling? CategoryAxisScaling
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.CategoryAxisScaling>();
      if (element != null)
        return CategoryAxisScalingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.CategoryAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CategoryAxisScalingConverter.CreateOpenXmlElement<DXO16DCD.CategoryAxisScaling>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ValueAxisScaling? ValueAxisScaling
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ValueAxisScaling>();
      if (element != null)
        return ValueAxisScalingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ValueAxisScaling>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueAxisScalingConverter.CreateOpenXmlElement<DXO16DCD.ValueAxisScaling>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.AxisTitle? AxisTitle
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.AxisTitle>();
      if (element != null)
        return AxisTitleConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.AxisTitle>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisTitleConverter.CreateOpenXmlElement<DXO16DCD.AxisTitle>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.AxisUnits? AxisUnits
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.AxisUnits>();
      if (element != null)
        return AxisUnitsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.AxisUnits>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AxisUnitsConverter.CreateOpenXmlElement<DXO16DCD.AxisUnits>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.MajorGridlinesGridlines? MajorGridlinesGridlines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MajorGridlinesGridlines>();
      if (element != null)
        return MajorGridlinesGridlinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MajorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO16DCD.MajorGridlinesGridlines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.MinorGridlinesGridlines? MinorGridlinesGridlines
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MinorGridlinesGridlines>();
      if (element != null)
        return MinorGridlinesGridlinesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MinorGridlinesGridlines>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorGridlinesGridlinesConverter.CreateOpenXmlElement<DXO16DCD.MinorGridlinesGridlines>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.MajorTickMarksTickMarks? MajorTickMarksTickMarks
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MajorTickMarksTickMarks>();
      if (element != null)
        return MajorTickMarksTickMarksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MajorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MajorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO16DCD.MajorTickMarksTickMarks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.MinorTickMarksTickMarks? MinorTickMarksTickMarks
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.MinorTickMarksTickMarks>();
      if (element != null)
        return MinorTickMarksTickMarksConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.MinorTickMarksTickMarks>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MinorTickMarksTickMarksConverter.CreateOpenXmlElement<DXO16DCD.MinorTickMarksTickMarks>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.TickLabels? TickLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.TickLabels>();
      if (element != null)
        return TickLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.TickLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TickLabelsConverter.CreateOpenXmlElement<DXO16DCD.TickLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.NumberFormat? NumberFormat
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.NumberFormat>();
      if (element != null)
        return NumberFormatConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.NumberFormat>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberFormatConverter.CreateOpenXmlElement<DXO16DCD.NumberFormat>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO16DCD.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.TxPrTextBody? TxPrTextBody
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (element != null)
        return TxPrTextBodyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.TxPrTextBody>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TxPrTextBodyConverter.CreateOpenXmlElement<DXO16DCD.TxPrTextBody>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO16DCD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
