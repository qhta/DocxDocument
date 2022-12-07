namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the BorderType Class.
/// </summary>
public class BorderTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.BorderType>, BorderType
{
  /// <summary>
  /// Border Style
  /// </summary>
  public BorderKind? Val
  {
    get => (BorderKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.BorderValues?)value;
    }
  }
  
  /// <summary>
  /// Border Theme Color
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
