namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public class NumberingFormatImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.NumberingFormat>, NumberingFormat
{
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public NumberFormatKind? Val
  {
    get => (NumberFormatKind?)OpenXmlElement?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Val = (DocumentFormat.OpenXml.Wordprocessing.NumberFormatValues?)value;
    }
  }
  
}
