namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  public static Double? GetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetNumberColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.NumberColorPosition{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  public static Double? GetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
    if (itemElement != null)
      return itemElement.Val?.Value;
    return null;
  }
  
  public static void SetPercentageColorPosition(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement, Double? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = new DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.PercentageColorPosition{ Val = value };
        openXmlElement.AddChild(itemElement);
      }
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? CreateModelElement(DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition();
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing.ValueColorMiddlePosition, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
      SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
      return openXmlElement;
    }
    return default;
  }
}
