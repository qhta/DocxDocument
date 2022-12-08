namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public class UnderlineImpl: ModelElementImpl, Underline
{
  public DocumentFormat.OpenXml.Wordprocessing.Underline? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.Underline?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Underline Style
  /// </summary>
  public UnderlineKind? Val
  {
    get => (UnderlineKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.UnderlineValues?)value;
    }
  }
  
  /// <summary>
  /// Underline Color
  /// </summary>
  public String? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// Underline Theme Color
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
  /// Underline Theme Color Tint
  /// </summary>
  public String? ThemeTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// Underline Theme Color Shade
  /// </summary>
  public String? ThemeShade
  {
    get;
    set;
  }
  
}
