namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public partial class ParagraphPropertiesImpl: ModelElementImpl, ParagraphProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Math.ParagraphProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.ParagraphProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesImpl(): base() {}
  
  public ParagraphPropertiesImpl(DocumentFormat.OpenXml.Math.ParagraphProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public DocumentModel.Math.JustificationKind? Justification
  {
    get => (DocumentModel.Math.JustificationKind?)OpenXmlElement?.Justification?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Justification != null)
        {
          if (value is not null)
            OpenXmlElement.Justification.Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value;
          else
            OpenXmlElement.Justification = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Justification = new DocumentFormat.OpenXml.Math.Justification{ Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value };
        }
      }
    }
  }
  
}
