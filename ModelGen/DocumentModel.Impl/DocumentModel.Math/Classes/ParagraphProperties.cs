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
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Justification>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.Justification{ Val = (DocumentFormat.OpenXml.Math.JustificationValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
