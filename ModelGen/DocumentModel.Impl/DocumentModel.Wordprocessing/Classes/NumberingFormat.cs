namespace DocumentModel.Wordprocessing;

/// <summary>
/// Footnote Numbering Format.
/// </summary>
public partial class NumberingFormatImpl: ModelElementImpl, NumberingFormat
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Wordprocessing.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.NumberingFormat?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NumberingFormatImpl(): base() {}
  
  public NumberingFormatImpl(DocumentFormat.OpenXml.Wordprocessing.NumberingFormat openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Numbering Format Type
  /// </summary>
  public DocumentModel.Wordprocessing.NumberFormatKind? Val
  {
    get => (DocumentModel.Wordprocessing.NumberFormatKind?)OpenXmlElement?.Val?.Value;
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
    get => (System.String?)OpenXmlElement?.Format?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Format = (System.String?)value;
    }
  }
  
}
