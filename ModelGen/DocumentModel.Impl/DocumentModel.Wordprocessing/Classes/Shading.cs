namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Shading Class.
/// </summary>
public class ShadingImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Shading>, Shading
{
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
  
}
