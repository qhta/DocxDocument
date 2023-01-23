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
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>()?.Text;
  }
  
  private static bool CmpXPosition(DXDrawChartDraw.MarkerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.XPosition>()?.Text == value;
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
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>()?.Text;
  }
  
  private static bool CmpYPosition(DXDrawChartDraw.MarkerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDrawChartDraw.YPosition>()?.Text == value;
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
  
  public static bool CompareModelElement(DXDrawChartDraw.MarkerType? openXmlElement, DMDrawsChartDraw.MarkerType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpXPosition(openXmlElement, value.XPosition, diffs, objName))
        ok = false;
      if (!CmpYPosition(openXmlElement, value.YPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
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
