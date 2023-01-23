namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  private static Int64? GetX(DXDrawW.Point2DType openXmlElement)
  {
    return openXmlElement.X?.Value;
  }
  
  private static bool CmpX(DXDrawW.Point2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.X?.Value == value;
  }
  
  private static void SetX(DXDrawW.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  private static Int64? GetY(DXDrawW.Point2DType openXmlElement)
  {
    return openXmlElement.Y?.Value;
  }
  
  private static bool CmpY(DXDrawW.Point2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Y?.Value == value;
  }
  
  private static void SetY(DXDrawW.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  public static DMDrawsW.Point2DType? CreateModelElement(DXDrawW.Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDrawsW.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDrawW.Point2DType? openXmlElement, DMDrawsW.Point2DType? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpX(openXmlElement, value.X, diffs, objName))
        ok = false;
      if (!CmpY(openXmlElement, value.Y, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDrawsW.Point2DType? value)
    where OpenXmlElementType: DXDrawW.Point2DType, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      return openXmlElement;
    }
    return default;
  }
}
