namespace DocumentModel.Math;

/// <summary>
/// Office Math Paragraph Properties.
/// </summary>
public class ParagraphPropertiesImpl: ModelElementImpl, ParagraphProperties
{
  public DocumentFormat.OpenXml.Math.ParagraphProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.ParagraphProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ParagraphPropertiesImpl(): base() {}
  
  public ParagraphPropertiesImpl(DocumentFormat.OpenXml.Math.ParagraphProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Justification.
  /// </summary>
  public JustificationKind? Justification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Justification>();
        return (JustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Justification>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.Justification{ Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
