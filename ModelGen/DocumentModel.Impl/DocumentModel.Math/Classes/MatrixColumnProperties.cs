namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public class MatrixColumnPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Math.MatrixColumnProperties>, MatrixColumnProperties
{
  /// <summary>
  /// Matrix Column Justification.
  /// </summary>
  public HorizontalAlignmentKind? MatrixColumnJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
        return (HorizontalAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.MatrixColumnJustification{ Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
