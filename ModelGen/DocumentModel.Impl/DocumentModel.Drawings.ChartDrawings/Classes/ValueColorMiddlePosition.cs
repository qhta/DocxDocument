namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public partial class ValueColorMiddlePositionImpl: ModelElementImpl, ValueColorMiddlePosition
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
    get => (System.Double?)OpenXmlElement?.NumberColorPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.NumberColorPosition != null)
        {
          if (value is not null)
            OpenXmlElement.NumberColorPosition.Val = (System.Double?)value;
          else
            OpenXmlElement.NumberColorPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.NumberColorPosition = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = (System.Double?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public Double? PercentageColorPosition
  {
    get => (System.Double?)OpenXmlElement?.PercentageColorPosition?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.PercentageColorPosition != null)
        {
          if (value is not null)
            OpenXmlElement.PercentageColorPosition.Val = (System.Double?)value;
          else
            OpenXmlElement.PercentageColorPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.PercentageColorPosition = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = (System.Double?)value };
        }
      }
    }
  }
  
}
