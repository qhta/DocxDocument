namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies an Outer Shadow Effect.
/// </summary>
public partial class OuterShadow: ModelElement<DXD.OuterShadow>
{
  public OuterShadow(): base(){ }
  
  public OuterShadow(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public OuterShadow(DXD.OuterShadow openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies the blur radius of the shadow.
  /// </summary>
  [DataMember]
  public Int64? BlurRadius
  {
    get
    {
      return _Element?.BlurRadius?.Value;
    }
    set
    {
      _ExistingElement.BlurRadius = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the how far to offset the shadow.
  /// </summary>
  [DataMember]
  public Int64? Distance
  {
    get
    {
      return _Element?.Distance?.Value;
    }
    set
    {
      _ExistingElement.Distance = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the direction to offset the shadow.
  /// </summary>
  [DataMember]
  public Int32? Direction
  {
    get
    {
      return _Element?.Direction?.Value;
    }
    set
    {
      _ExistingElement.Direction = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the horizontal scaling factor; negative scaling causes a flip.
  /// </summary>
  [DataMember]
  public Int32? HorizontalRatio
  {
    get
    {
      return _Element?.HorizontalRatio?.Value;
    }
    set
    {
      _ExistingElement.HorizontalRatio = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the vertical scaling factor; negative scaling causes a flip.
  /// </summary>
  [DataMember]
  public Int32? VerticalRatio
  {
    get
    {
      return _Element?.VerticalRatio?.Value;
    }
    set
    {
      _ExistingElement.VerticalRatio = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the horizontal skew angle.
  /// </summary>
  [DataMember]
  public Int32? HorizontalSkew
  {
    get
    {
      return _Element?.HorizontalSkew?.Value;
    }
    set
    {
      _ExistingElement.HorizontalSkew = value;
    }
  }
  
  
  /// <summary>
  ///   Specifies the vertical skew angle.
  /// </summary>
  [DataMember]
  public Int32? VerticalSkew
  {
    get
    {
      return _Element?.VerticalSkew?.Value;
    }
    set
    {
      _ExistingElement.VerticalSkew = value;
    }
  }
  
  
  /// <summary>
  ///   Rotate With Shape
  /// </summary>
  [DataMember]
  public Boolean? RotateWithShape
  {
    get
    {
      return _Element?.RotateWithShape?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.RotateWithShape = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.RotateWithShape = null;
    }
  }
  
  
  /// <summary>
  ///   RGB Color Model - Percentage Variant.
  /// </summary>
  [DataMember]
  public DMD.RgbColorModelPercentage? RgbColorModelPercentage
  {
    get
    {
      return _Element?.GetObject<DMD.RgbColorModelPercentage,DXD.RgbColorModelPercentage>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RgbColorModelPercentage,DXD.RgbColorModelPercentage>(value);
    }
  }
  
  
  /// <summary>
  ///   RGB Color Model - Hex Variant.
  /// </summary>
  [DataMember]
  public DMD.RgbColorModelHex? RgbColorModelHex
  {
    get
    {
      return _Element?.GetObject<DMD.RgbColorModelHex,DXD.RgbColorModelHex>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.RgbColorModelHex,DXD.RgbColorModelHex>(value);
    }
  }
  
  
  /// <summary>
  ///   Hue, Saturation, Luminance Color Model.
  /// </summary>
  [DataMember]
  public DMD.HslColor? HslColor
  {
    get
    {
      return _Element?.GetObject<DMD.HslColor,DXD.HslColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.HslColor,DXD.HslColor>(value);
    }
  }
  
  
  /// <summary>
  ///   System Color.
  /// </summary>
  [DataMember]
  public DMD.SystemColor? SystemColor
  {
    get
    {
      return _Element?.GetObject<DMD.SystemColor,DXD.SystemColor>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.SystemColor,DXD.SystemColor>(value);
    }
  }
  
  
  /// <summary>
  ///   Scheme Color.
  /// </summary>
  [DataMember]
  public DMD.SchemeColorKind? SchemeColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.SchemeColor");
    }
  }
  
  
  /// <summary>
  ///   Preset Color.
  /// </summary>
  [DataMember]
  public DMD.PresetColorKind? PresetColor
  {
    get
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertyGetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
    set
    {
      throw new NotImplementedException("Not implemented in GenerateEnumPropertySetCode: propertyType is DocumentFormat.OpenXml.Drawing.PresetColor");
    }
  }
  
}
