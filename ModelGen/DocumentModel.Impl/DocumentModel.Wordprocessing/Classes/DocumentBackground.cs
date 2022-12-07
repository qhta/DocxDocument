namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public class DocumentBackgroundImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.DocumentBackground>, DocumentBackground
{
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
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background
  {
    get;
    set;
  }
  
}
