namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Chart Space.
/// </summary>
public partial class ChartSpace: ModelElement<DXDC.ChartSpace>
{
  public ChartSpace(): base(){ }
  
  public ChartSpace(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartSpace(DXDC.ChartSpace openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Date1904.
  /// </summary>
  [DataMember]
  public DMDC.Date1904? Date1904
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Date1904>();
      if (element != null)
        return Date1904Converter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Date1904>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = Date1904Converter.CreateOpenXmlElement<DXDC.Date1904>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   EditingLanguage.
  /// </summary>
  [DataMember]
  public String? EditingLanguage
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.GetFirstChild<DXDC.EditingLanguage>()?.Val);
    }
    set
    {
      StringValueConverter.SetValue<DXDC.EditingLanguage>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   RoundedCorners.
  /// </summary>
  [DataMember]
  public DMDC.RoundedCorners? RoundedCorners
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.RoundedCorners>();
      if (element != null)
        return RoundedCornersConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.RoundedCorners>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RoundedCornersConverter.CreateOpenXmlElement<DXDC.RoundedCorners>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public Byte? Style
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXO10DC.Style>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXO10DC.Style,System.Byte>(openXmlElement, value);
    }
  }
  
  [DataMember]
  public DMDC.ColorMapOverride? ColorMapOverride
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ColorMapOverride>();
      if (element != null)
        return ColorMapOverrideConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ColorMapOverride>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMapOverrideConverter.CreateOpenXmlElement<DXDC.ColorMapOverride>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.PivotSource? PivotSource
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PivotSource>();
      if (element != null)
        return PivotSourceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PivotSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PivotSourceConverter.CreateOpenXmlElement<DXDC.PivotSource>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Protection? Protection
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Protection>();
      if (element != null)
        return ProtectionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Protection>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ProtectionConverter.CreateOpenXmlElement<DXDC.Protection>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.Chart? Chart
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.Chart>();
      if (element != null)
        return ChartConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.Chart>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartConverter.CreateOpenXmlElement<DXDC.Chart>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ShapeProperties? ShapeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXDC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.TextProperties? TextProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.TextProperties>();
      if (element != null)
        return TextPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.TextProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextPropertiesConverter.CreateOpenXmlElement<DXDC.TextProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ExternalData? ExternalData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ExternalData>();
      if (element != null)
        return ExternalDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ExternalData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExternalDataConverter.CreateOpenXmlElement<DXDC.ExternalData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.PrintSettings? PrintSettings
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PrintSettings>();
      if (element != null)
        return PrintSettingsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PrintSettings>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PrintSettingsConverter.CreateOpenXmlElement<DXDC.PrintSettings>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.UserShapesReference? UserShapesReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.UserShapesReference>();
      if (element != null)
        return UserShapesReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.UserShapesReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UserShapesReferenceConverter.CreateOpenXmlElement<DXDC.UserShapesReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDC.ChartSpaceExtensionList? ChartSpaceExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.ChartSpaceExtensionList>();
      if (element != null)
        return ChartSpaceExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.ChartSpaceExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ChartSpaceExtensionListConverter.CreateOpenXmlElement<DXDC.ChartSpaceExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
