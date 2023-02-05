namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public static class AdjustPoint2DTypeConverter
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  private static String? GetX(DXDraw.AdjustPoint2DType openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static bool CmpX(DXDraw.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.X?.Value == value) return true;
    diffs?.Add(objName, "X", openXmlElement?.X?.Value, value);
    return false;
  }
  
  private static void SetX(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.X = new StringValue { Value = value };
    else
      openXmlElement.X = null;
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  private static String? GetY(DXDraw.AdjustPoint2DType openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static bool CmpY(DXDraw.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Y?.Value == value) return true;
    diffs?.Add(objName, "Y", openXmlElement?.Y?.Value, value);
    return false;
  }
  
  private static void SetY(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    if (value != null)
      openXmlElement.Y = new StringValue { Value = value };
    else
      openXmlElement.Y = null;
  }
  
  public static DMDraws.AdjustPoint2DType? CreateModelElement(DXDraw.AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.AdjustPoint2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AdjustPoint2DType? openXmlElement, DMDraws.AdjustPoint2DType? value, DiffList? diffs, string? objName)
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
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustPoint2DType? value)
    where OpenXmlElementType: DXDraw.AdjustPoint2DType, new()
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
