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
  public Boolean? BeFilled
  {
    get
    {
      return _Element?.BeFilled?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BeFilled = value;
      else
        _ExistingElement.BeFilled = null;
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
  public Boolean? IsStroke
  {
    get
    {
      return _Element?.IsStroke?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.IsStroke = value;
      else
        _ExistingElement.IsStroke = null;
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
  public Boolean? AllowInCell
  {
    get
    {
      return _Element?.AllowInCell?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowInCell = value;
      else
        _ExistingElement.AllowInCell = null;
    }
  }
  
  
  /// <summary>
  ///   allowoverlap
  /// </summary>
  [DataMember]
  public Boolean? AllowOverlap
  {
    get
    {
      return _Element?.AllowOverlap?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.AllowOverlap = value;
      else
        _ExistingElement.AllowOverlap = null;
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
      return _Element?.GetObject<DMVML.Fill,DXV.Fill>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Fill,DXV.Fill>(value);
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
      return _Element?.GetObject<DMVML.ImageData,DXV.ImageData>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.ImageData,DXV.ImageData>(value);
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
      return _Element?.GetObject<DMVML.Stroke,DXV.Stroke>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Stroke,DXV.Stroke>(value);
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
      return _Element?.GetObject<DMVML.TextBox,DXV.TextBox>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.TextBox,DXV.TextBox>(value);
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
      return _Element?.GetObject<DMVML.Shadow,DXV.Shadow>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Shadow,DXV.Shadow>(value);
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
      return _Element?.GetObject<DMVML.Skew,DXVO.Skew>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Skew,DXVO.Skew>(value);
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
      return _Element?.GetObject<DMVML.Extrusion,DXVO.Extrusion>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Extrusion,DXVO.Extrusion>(value);
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
      return _Element?.GetObject<DMVML.Callout,DXVO.Callout>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Callout,DXVO.Callout>(value);
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
      return _Element?.GetObject<DMVML.Lock,DXVO.Lock>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.Lock,DXVO.Lock>(value);
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
      return _Element?.GetObject<DMVML.ColorMostRecentlyUsed,DXVO.ColorMostRecentlyUsed>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.ColorMostRecentlyUsed,DXVO.ColorMostRecentlyUsed>(value);
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
      return _Element?.GetObject<DMVML.ColorMenu,DXVO.ColorMenu>();
    }
    set
    {
      _ExistingElement.SetObject<DMVML.ColorMenu,DXVO.ColorMenu>(value);
    }
  }
  
}
