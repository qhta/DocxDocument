namespace DocumentModel.Drawings;


/// <summary>
///   This element defines a gradient stop. A gradient stop consists of a position where the stop appears in the color band.
/// </summary>
public partial class GradientStop: ModelElement<DXD.GradientStop>
{
  public GradientStop(): base(){ }
  
  public GradientStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public GradientStop(DXD.GradientStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Specifies where this gradient stop should appear in the color band. This position is specified in the range, which corresponds to the beginning and the end of the color band respectively.
  /// </summary>
  [DataMember]
  public Int32? Position
  {
    get
    {
      return _Element?.Position?.Value;
    }
    set
    {
      _ExistingElement.Position = value;
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
