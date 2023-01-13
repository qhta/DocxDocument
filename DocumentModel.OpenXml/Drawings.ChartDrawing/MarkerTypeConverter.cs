namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public static class MarkerTypeConverter
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  public static String? GetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetXPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.XPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  public static String? GetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  public static void SetYPosition(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement, String? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Drawing.ChartDrawing.YPosition { Text = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.MarkerType? CreateModelElement(DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawing.MarkerType();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawing.MarkerType? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.ChartDrawing.MarkerType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetXPosition(openXmlElement, value?.XPosition);
      SetYPosition(openXmlElement, value?.YPosition);
      return openXmlElement;
    }
    return default;
  }
}
