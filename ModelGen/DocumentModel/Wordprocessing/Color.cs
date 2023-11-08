namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the color which shall be used to display the contents of this run in the document.
/// </summary>
public partial class Color: ModelElement<DXW.Color>
{
  public Color(): base(){ }
  
  public Color(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Color(DXW.Color openXmlElement): base(openXmlElement) { }
  
  
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
