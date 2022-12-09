namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public class ShadingImpl: ModelElementImpl, Shading
{
  public DocumentFormat.OpenXml.Wordprocessing.Shading? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Shading?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Shading Pattern
  /// </summary>
  public ShadingPatternKind? Val
  {
    get => (ShadingPatternKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.ShadingPatternValues?)value;
    }
  }
  
  /// <summary>
  /// Shading Pattern Color
  /// </summary>
  public String? Color
  {
    get => (String?)OpenXmlElement?.Color?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Color = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shading Pattern Theme Color
  /// </summary>
  public ThemeColorKind? ThemeColor
  {
    get => (ThemeColorKind?)OpenXmlElement?.ThemeColor?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeColor = (DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues?)value;
    }
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Tint
  /// </summary>
  public String? ThemeTint
  {
    get => (String?)OpenXmlElement?.ThemeTint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeTint = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shading Pattern Theme Color Shade
  /// </summary>
  public String? ThemeShade
  {
    get => (String?)OpenXmlElement?.ThemeShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeShade = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shading Background Color
  /// </summary>
  public String? Fill
  {
    get => (String?)OpenXmlElement?.Fill?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Fill = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shading Background Theme Color
  /// </summary>
  public ThemeColorKind? ThemeFill
  {
    get => (ThemeColorKind?)OpenXmlElement?.ThemeFill?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeFill = (DocumentFormat.OpenXml.Wordprocessing.ThemeColorValues?)value;
    }
  }
  
  /// <summary>
  /// Shading Background Theme Color Tint
  /// </summary>
  public String? ThemeFillTint
  {
    get => (String?)OpenXmlElement?.ThemeFillTint?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeFillTint = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Shading Background Theme Color Shade
  /// </summary>
  public String? ThemeFillShade
  {
    get => (String?)OpenXmlElement?.ThemeFillShade?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ThemeFillShade = (System.String?)value;
    }
  }
  
}
