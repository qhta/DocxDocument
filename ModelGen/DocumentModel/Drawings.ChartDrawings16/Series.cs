namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the Series Class.
/// </summary>
public partial class Series: ModelElement<DXO16DCD.Series>
{
  public Series(): base(){ }
  
  public Series(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Series(DXO16DCD.Series openXmlElement): base(openXmlElement) { }
  
  
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
  
  
  /// <summary>
  ///   ownerIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? OwnerIdx
  {
    get
    {
      return _Element?.OwnerIdx?.Value;
    }
    set
    {
      _ExistingElement.OwnerIdx = value;
    }
  }
  
  
  /// <summary>
  ///   uniqueId, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public String? UniqueId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.UniqueId);
    }
    set
    {
      _ExistingElement.UniqueId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   formatIdx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? FormatIdx
  {
    get
    {
      return _Element?.FormatIdx?.Value;
    }
    set
    {
      _ExistingElement.FormatIdx = value;
    }
  }
  
  
  /// <summary>
  ///   Text.
  /// </summary>
  [DataMember]
  public DMDCD16.Text? Text
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Text>();
      if (element != null)
        return TextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Text>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextConverter.CreateOpenXmlElement<DXO16DCD.Text>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
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
  
  
  /// <summary>
  ///   ValueColors.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColors? ValueColors
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ValueColors>();
      if (element != null)
        return ValueColorsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ValueColors>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorsConverter.CreateOpenXmlElement<DXO16DCD.ValueColors>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ValueColorPositions.
  /// </summary>
  [DataMember]
  public DMDCD16.ValueColorPositions? ValueColorPositions
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ValueColorPositions>();
      if (element != null)
        return ValueColorPositionsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ValueColorPositions>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ValueColorPositionsConverter.CreateOpenXmlElement<DXO16DCD.ValueColorPositions>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDCD16.DataLabels? DataLabels
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.DataLabels>();
      if (element != null)
        return DataLabelsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.DataLabels>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = DataLabelsConverter.CreateOpenXmlElement<DXO16DCD.DataLabels>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public UInt32? DataId
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO16DCD.DataId>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO16DCD.DataId,System.UInt32>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDCD16.SeriesLayoutProperties? SeriesLayoutProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.SeriesLayoutProperties>();
      if (element != null)
        return SeriesLayoutPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.SeriesLayoutProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SeriesLayoutPropertiesConverter.CreateOpenXmlElement<DXO16DCD.SeriesLayoutProperties>(value);
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
