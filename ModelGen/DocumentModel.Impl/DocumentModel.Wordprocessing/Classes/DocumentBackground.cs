namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public class DocumentBackgroundImpl: ModelElementImpl, DocumentBackground
{
  public DocumentFormat.OpenXml.Wordprocessing.DocumentBackground? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DocumentBackground?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// color
  /// </summary>
  public String? Color
  {
    get;
    set;
  }
  
  /// <summary>
  /// themeColor
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
  /// themeTint
  /// </summary>
  public String? ThemeTint
  {
    get;
    set;
  }
  
  /// <summary>
  /// themeShade
  /// </summary>
  public String? ThemeShade
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background
  {
    get;
    set;
  }
  
}
