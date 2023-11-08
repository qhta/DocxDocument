namespace DocumentModel.Vml;


/// <summary>
///   New Shape Defaults.
/// </summary>
public partial class ShapeDefaults: ModelElement<DXVO.ShapeDefaults>
{
  public ShapeDefaults(): base(){ }
  
  public ShapeDefaults(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ShapeDefaults(DXVO.ShapeDefaults openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shape ID Optional Storage
  /// </summary>
  [DataMember]
  public Int64? MaxShapeId
  {
    get
    {
      return _Element?.MaxShapeId?.Value;
    }
    set
    {
      _ExistingElement.MaxShapeId = value;
    }
  }
  
  
  /// <summary>
  ///   style
  /// </summary>
  [DataMember]
  public String? Style
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Style);
    }
    set
    {
      _ExistingElement.Style = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Fill Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? BeFilled
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Default Fill Color
  /// </summary>
  [DataMember]
  public String? FillColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.FillColor);
    }
    set
    {
      _ExistingElement.FillColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shape Stroke Toggle
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? IsStroke
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Shape Stroke Color
  /// </summary>
  [DataMember]
  public String? StrokeColor
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.StrokeColor);
    }
    set
    {
      _ExistingElement.StrokeColor = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Allow in Table Cell
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowInCell
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [DataMember]
  public DM.TrueFalseValue? AllowOverlap
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DX.TrueFalseValue>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DX.TrueFalseValue,DocumentFormat.OpenXml.TrueFalseValue>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Fill.
  /// </summary>
  [DataMember]
  public DMVML.Fill? Fill
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.Fill>();
      if (element != null)
        return FillConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.Fill>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FillConverter.CreateOpenXmlElement<DXV.Fill>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   ImageData.
  /// </summary>
  [DataMember]
  public DMVML.ImageData? ImageData
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.ImageData>();
      if (element != null)
        return ImageDataConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.ImageData>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ImageDataConverter.CreateOpenXmlElement<DXV.ImageData>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Stroke.
  /// </summary>
  [DataMember]
  public DMVML.Stroke? Stroke
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.Stroke>();
      if (element != null)
        return StrokeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.Stroke>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StrokeConverter.CreateOpenXmlElement<DXV.Stroke>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TextBox.
  /// </summary>
  [DataMember]
  public DMVML.TextBox? TextBox
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.TextBox>();
      if (element != null)
        return TextBoxConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.TextBox>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TextBoxConverter.CreateOpenXmlElement<DXV.TextBox>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shadow.
  /// </summary>
  [DataMember]
  public DMVML.Shadow? Shadow
  {
    get
    {
      var element = _Element?.GetFirstChild<DXV.Shadow>();
      if (element != null)
        return ShadowConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXV.Shadow>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadowConverter.CreateOpenXmlElement<DXV.Shadow>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Skew.
  /// </summary>
  [DataMember]
  public DMVML.Skew? Skew
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.Skew>();
      if (element != null)
        return SkewConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.Skew>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SkewConverter.CreateOpenXmlElement<DXVO.Skew>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Extrusion.
  /// </summary>
  [DataMember]
  public DMVML.Extrusion? Extrusion
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.Extrusion>();
      if (element != null)
        return ExtrusionConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.Extrusion>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtrusionConverter.CreateOpenXmlElement<DXVO.Extrusion>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Callout.
  /// </summary>
  [DataMember]
  public DMVML.Callout? Callout
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.Callout>();
      if (element != null)
        return CalloutConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.Callout>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CalloutConverter.CreateOpenXmlElement<DXVO.Callout>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Shape Protections.
  /// </summary>
  [DataMember]
  public DMVML.Lock? Lock
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.Lock>();
      if (element != null)
        return LockConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.Lock>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LockConverter.CreateOpenXmlElement<DXVO.Lock>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Most Recently Used Colors.
  /// </summary>
  [DataMember]
  public DMVML.ColorMostRecentlyUsed? ColorMostRecentlyUsed
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.ColorMostRecentlyUsed>();
      if (element != null)
        return ColorMostRecentlyUsedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.ColorMostRecentlyUsed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMostRecentlyUsedConverter.CreateOpenXmlElement<DXVO.ColorMostRecentlyUsed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   UI Default Colors.
  /// </summary>
  [DataMember]
  public DMVML.ColorMenu? ColorMenu
  {
    get
    {
      var element = _Element?.GetFirstChild<DXVO.ColorMenu>();
      if (element != null)
        return ColorMenuConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXVO.ColorMenu>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ColorMenuConverter.CreateOpenXmlElement<DXVO.ColorMenu>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
