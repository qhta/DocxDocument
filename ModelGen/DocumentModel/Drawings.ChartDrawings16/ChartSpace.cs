namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the ChartSpace Class.
/// </summary>
public partial class ChartSpace: ModelElement<DXO16DCD.ChartSpace>
{
  public ChartSpace(): base(){ }
  
  public ChartSpace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpace(DXO16DCD.ChartSpace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ChartData.
  /// </summary>
  [DataMember]
  public DMDCD16.ChartData? ChartData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ChartData>();
      if (element != null)
        return ChartDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ChartData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartDataConverter.CreateOpenXmlElement<DXO16DCD.ChartData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Chart.
  /// </summary>
  [DataMember]
  public DMDCD16.Chart? Chart
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.Chart>();
      if (element != null)
        return ChartConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.Chart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartConverter.CreateOpenXmlElement<DXO16DCD.Chart>(value);
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
  ///   TxPrTextBody.
  /// </summary>
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
  
  
  /// <summary>
  ///   ColorMappingType.
  /// </summary>
  [DataMember]
  public DMDCD16.ColorMappingType? ColorMappingType
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.ColorMappingType>();
      if (element != null)
        return ColorMappingTypeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.ColorMappingType>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMappingTypeConverter.CreateOpenXmlElement<DXO16DCD.ColorMappingType>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   FormatOverrides.
  /// </summary>
  [DataMember]
  public DMDCD16.FormatOverrides? FormatOverrides
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.FormatOverrides>();
      if (element != null)
        return FormatOverridesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.FormatOverrides>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatOverridesConverter.CreateOpenXmlElement<DXO16DCD.FormatOverrides>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   PrintSettings.
  /// </summary>
  [DataMember]
  public DMDCD16.PrintSettings? PrintSettings
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO16DCD.PrintSettings>();
      if (element != null)
        return PrintSettingsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PrintSettings>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintSettingsConverter.CreateOpenXmlElement<DXO16DCD.PrintSettings>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
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
