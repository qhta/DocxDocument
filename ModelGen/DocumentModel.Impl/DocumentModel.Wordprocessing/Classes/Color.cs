namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Color Class.
/// </summary>
public class ColorImpl: ModelElementImpl, Color
{
  public DocumentFormat.OpenXml.Office2013.Word.Color? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Word.Color?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Run Content Color
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// Run Content Theme Color
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
  /// Run Content Theme Color Tint
  /// </summary>
  public String? ThemeTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Run Content Theme Color Shade
  /// </summary>
  public String? ThemeShade
  {
    get;
    set;
  }
  
}
