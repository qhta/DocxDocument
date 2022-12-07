namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Underline Class.
/// </summary>
public class UnderlineImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Underline>, Underline
{
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
  
}
