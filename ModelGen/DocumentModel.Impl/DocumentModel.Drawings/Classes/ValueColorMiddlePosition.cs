namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public class ValueColorMiddlePositionImpl: ModelElementImpl, ValueColorMiddlePosition
{
  public DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValueColorMiddlePositionImpl(): base() {}
  
  public ValueColorMiddlePositionImpl(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public Double? NumberColorPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
        return (Double?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
        return (Double?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (System.Double?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = (System.Double?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
}
