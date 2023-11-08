namespace DocumentModel.Word13;


/// <summary>
///   This element specifies the color on which to base the visual elements of a structured document tag.
/// </summary>
public partial class Color: ModelElement<DXO13W.Color>
{
  public Color(): base(){ }
  
  public Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Color(DXO13W.Color openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Run Content Color
  /// </summary>
  [DataMember]
  public String? Val
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Val);
    }
    set
    {
      _ExistingElement.Val = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   Run Content Theme Color Tint
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
  ///   Run Content Theme Color Shade
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
  
}
