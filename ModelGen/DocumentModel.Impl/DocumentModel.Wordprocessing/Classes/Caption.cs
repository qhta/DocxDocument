namespace DocumentModel.Wordprocessing;

/// <summary>
/// Single Caption Type Definition.
/// </summary>
public class CaptionImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.Caption>, Caption
{
  /// <summary>
  /// Automatic Caption Placement
  /// </summary>
  public CaptionPositionKind? Position
  {
    get => (CaptionPositionKind?)OpenXmlElement?.Position?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Position = (DocumentFormat.OpenXml.Wordprocessing.CaptionPositionValues?)value;
    }
  }
  
  /// <summary>
  /// Caption Numbering Format
  /// </summary>
  public NumberFormatKind? NumberFormat
  {
    get => (NumberFormatKind?)OpenXmlElement?.NumberFormat?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.NumberFormat = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
  /// <summary>
  /// Chapter Number/Item Index Separator
  /// </summary>
  public ChapterSeparatorKind? Separator
  {
    get => (ChapterSeparatorKind?)OpenXmlElement?.Separator?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Separator = (DocumentFormat.OpenXml.Wordprocessing.ChapterSeparatorValues?)value;
    }
  }
  
}
