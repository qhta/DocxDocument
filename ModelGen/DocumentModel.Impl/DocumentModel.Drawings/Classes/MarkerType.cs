namespace DocumentModel.Drawings;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public class MarkerTypeImpl: ModelElementImpl, MarkerType
{
  public DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public virtual String? XPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public virtual String? YPosition
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
        return openXmlElement?.Text;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
        if (openXmlElement != null)
        {
          if (value is not null)
            openXmlElement.Text = value;
          else
            openXmlElement.Remove();
        }
        else
        {
          if (value is not null)
          {
            openXmlElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition{ Text = value };
            OpenXmlElement.AddChild(openXmlElement);
          }
        }
      }
    }
  }
  
}
