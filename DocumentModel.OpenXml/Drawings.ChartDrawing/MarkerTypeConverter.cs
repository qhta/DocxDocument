namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public static class MarkerTypeConverter
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  private static String? GetXPosition(DXDrawChartDraw.MarkerType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetXPosition(DXDrawChartDraw.MarkerType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.XPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawChartDraw.XPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  private static String? GetYPosition(DXDrawChartDraw.MarkerType openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>();
    if (itemElement != null)
      return itemElement.Text;
    return null;
  }
  
  private static void SetYPosition(DXDrawChartDraw.MarkerType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDrawChartDraw.YPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDrawChartDraw.YPosition { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DMDrawsChartDraw.MarkerType? CreateModelElement(DXDrawChartDraw.MarkerType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsChartDraw.MarkerType();
      value.XPosition = GetXPosition(openXmlElement);
      value.YPosition = GetYPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsChartDraw.MarkerType? value)
    where OpenXmlElementType: DXDrawChartDraw.MarkerType, new()
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
