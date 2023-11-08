namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the shading applied to the contents of the paragraph.
/// </summary>
public partial class Shading: ModelElement<DXW.Shading>
{
  public Shading(): base(){ }
  
  public Shading(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shading(DXW.Shading openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shading Pattern Color
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
  ///   Shading Pattern Theme Color Tint
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
  ///   Shading Pattern Theme Color Shade
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
  ///   Shading Background Color
  /// </summary>
  [DataMember]
  public String? Fill
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Fill);
    }
    set
    {
      _ExistingElement.Fill = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shading Background Theme Color Tint
  /// </summary>
  [DataMember]
  public String? ThemeFillTint
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeFillTint);
    }
    set
    {
      _ExistingElement.ThemeFillTint = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Shading Background Theme Color Shade
  /// </summary>
  [DataMember]
  public String? ThemeFillShade
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ThemeFillShade);
    }
    set
    {
      _ExistingElement.ThemeFillShade = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
