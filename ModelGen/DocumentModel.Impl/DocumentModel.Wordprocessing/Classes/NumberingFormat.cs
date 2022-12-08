namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public class NumberingFormatImpl: ModelElementImpl, NumberingFormat
{
  public DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
  
  /// <summary>
  /// format, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Format
  {
    get;
    set;
  }
  
}
