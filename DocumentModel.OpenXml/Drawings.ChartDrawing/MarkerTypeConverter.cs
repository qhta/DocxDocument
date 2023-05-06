namespace DocumentModel.OpenXml.Drawings.ChartDrawing;

/// <summary>
/// Defines the MarkerType Class.
/// </summary>
public static class MarkerTypeConverter
{
  /// <summary>
  /// Relative X Coordinate.
  /// </summary>
  private static String? GetXPosition(DXDCD.MarkerType openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text;
  }
  
  private static bool CmpXPosition(DXDCD.MarkerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDCD.XPosition>()?.Text == value;
  }
  
  private static void SetXPosition(DXDCD.MarkerType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.XPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.XPosition { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Relative Y Coordinate.
  /// </summary>
  private static String? GetYPosition(DXDCD.MarkerType openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text;
  }
  
  private static bool CmpYPosition(DXDCD.MarkerType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXDCD.YPosition>()?.Text == value;
  }
  
  private static void SetYPosition(DXDCD.MarkerType openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDCD.YPosition>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXDCD.YPosition { Text = value };
      openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.ChartDrawing.MarkerType? CreateModelElement(DXDCD.MarkerType? openXmlElement)
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
  
  public static bool CompareModelElement(DXDCD.MarkerType? openXmlElement, DMDCD.MarkerType? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCD.MarkerType value)
    where OpenXmlElementType: DXDCD.MarkerType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDCD.MarkerType openXmlElement, DMDCD.MarkerType value)
  {
    SetXPosition(openXmlElement, value?.XPosition);
    SetYPosition(openXmlElement, value?.YPosition);
  }
}
