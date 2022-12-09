namespace DocumentModel.Math;

/// <summary>
/// Matrix Column Properties.
/// </summary>
public class MatrixColumnPropertiesImpl: ModelElementImpl, MatrixColumnProperties
{
  public DocumentFormat.OpenXml.Math.MatrixColumnProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.MatrixColumnProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Matrix Column Count.
  /// </summary>
  public Int32? MatrixColumnCount
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
        return (Int32?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Val = (System.Int32?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.MatrixColumnCount{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
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
          if (value is not null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.MatrixColumnJustification{ Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
