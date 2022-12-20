namespace DocumentModel.Drawings.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public partial class MarkerTypeImpl: ModelElementImpl, MarkerType
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MarkerTypeImpl(): base() {}
  
  public MarkerTypeImpl(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public virtual String? XPosition
  {
    get => (System.String?)OpenXmlElement?.XPosition?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.XPosition != null)
        {
          if (value is not null)
            OpenXmlElement.XPosition.Text = value;
          else
            OpenXmlElement.XPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.XPosition = new DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition{ Text = value };
        }
      }
    }
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public virtual String? YPosition
  {
    get => (System.String?)OpenXmlElement?.YPosition?.Text;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.YPosition != null)
        {
          if (value is not null)
            OpenXmlElement.YPosition.Text = value;
          else
            OpenXmlElement.YPosition = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.YPosition = new DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition{ Text = value };
        }
      }
    }
  }
  
}
