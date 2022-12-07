namespace DocumentModel.Math;

/// <summary>
/// Matrix Properties.
/// </summary>
public class MatrixPropertiesImpl: ModelElement<DocumentFormat.OpenXml.Math.MatrixProperties>, MatrixProperties
{
  /// <summary>
  /// Matrix Base Justification.
  /// </summary>
  public VerticalAlignmentKind? BaseJustification
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
        return (VerticalAlignmentKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.BaseJustification>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.BaseJustification{ Val = (DocumentFormat.OpenXml.Math.VerticalAlignmentValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Hide Placeholders (Matrix).
  /// </summary>
  public BooleanKind? HidePlaceholder
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
        return (BooleanKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.HidePlaceholder>();
        if (openXmlElement != null)
        {
          if (value != null)
            openXmlElement.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value != null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Math.HidePlaceholder{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Matrix Columns.
  /// </summary>
  public MatrixColumns? MatrixColumns
  {
    get;
    set;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
