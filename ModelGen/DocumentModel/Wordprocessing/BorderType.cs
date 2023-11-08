namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the BorderType Class.
/// </summary>
public partial class BorderType: ModelElement<DXW.BorderType>
{
  public BorderType(): base(){ }
  
  public BorderType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BorderType(DXW.BorderType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Border Color
  /// </summary>
  [DataMember]
  public String? Color
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Color);
    }
    set
    {
      _ExistingElement.Color = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Border Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeTint
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeTint);
    }
    set
    {
      _ExistingElement.ThemeTint = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Border Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeShade
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeShade);
    }
    set
    {
      _ExistingElement.ThemeShade = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Border Width
  /// </summary>
  [DataMember]
  public UInt32? Size
  {
    get
    {
      return _Element?.Size?.Value;
    }
    set
    {
      _ExistingElement.Size = value;
    }
  }
  
  
  /// <summary>
  ///   Border Spacing Measurement
  /// </summary>
  [DataMember]
  public UInt32? Space
  {
    get
    {
      return _Element?.Space?.Value;
    }
    set
    {
      _ExistingElement.Space = value;
    }
  }
  
  
  /// <summary>
  ///   Border Shadow
  /// </summary>
  [DataMember]
  public Boolean? Shadow
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Shadow);
    }
    set
    {
      _ExistingElement.Shadow = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
  
  /// <summary>
  ///   Create Frame Effect
  /// </summary>
  [DataMember]
  public Boolean? Frame
  {
    get
    {
      return BooleanValueConverter.GetValue(_Element?.Frame);
    }
    set
    {
      _ExistingElement.Frame = BooleanValueConverter.CreateOnOffValue(value);
    }
  }
  
}
