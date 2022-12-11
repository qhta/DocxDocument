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
  
  public MatrixColumnPropertiesImpl(): base() {}
  
  public MatrixColumnPropertiesImpl(DocumentFormat.OpenXml.Math.MatrixColumnProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnCount>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Int32?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.MatrixColumnCount{ Val = (System.Int32?)value };
            OpenXmlElement.AddChild(item);
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
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.MatrixColumnJustification>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.MatrixColumnJustification{ Val = (DocumentFormat.OpenXml.Math.HorizontalAlignmentValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
