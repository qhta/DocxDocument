namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the PageNumberType Class.
/// </summary>
public class PageNumberTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.PageNumberType>, PageNumberType
{
  /// <summary>
  /// Page Number Format
  /// </summary>
  public NumberFormatKind? Format
  {
    get => (NumberFormatKind?)OpenXmlElement?.Format?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Format = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
  /// <summary>
  /// Chapter Separator Character
  /// </summary>
  public ChapterSeparatorKind? ChapterSeparator
  {
    get => (ChapterSeparatorKind?)OpenXmlElement?.ChapterSeparator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ChapterSeparator = (DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues?)value;
    }
  }
  
}
