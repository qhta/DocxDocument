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
    return StringValueConverter.GetValue(openXmlElement?.X);
  }
  
  private static bool CmpX(DXDraw.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.X, value, diffs, objName, "X");
  }
  
  private static void SetX(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    openXmlElement.X = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  private static String? GetY(DXDraw.AdjustPoint2DType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Y);
  }
  
  private static bool CmpY(DXDraw.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs, string? objName)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Y, value, diffs, objName, "Y");
  }
  
  private static void SetY(DXDraw.AdjustPoint2DType openXmlElement, String? value)
  {
    openXmlElement.Y = StringValueConverter.CreateStringValue(value);
  }
  
  public static DocumentModel.Drawings.AdjustPoint2DType? CreateModelElement(DXDraw.AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AdjustPoint2DType();
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AdjustPoint2DType value)
    where OpenXmlElementType: DXDraw.AdjustPoint2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AdjustPoint2DType openXmlElement, DMDraws.AdjustPoint2DType value)
  {
    SetX(openXmlElement, value?.X);
    SetY(openXmlElement, value?.Y);
  }
}
