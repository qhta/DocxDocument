namespace DocumentModel.OpenXml.Drawings.Wordprocessing;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  private static Int64? GetX(DXDW.Point2DType openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static bool CmpX(DXDW.Point2DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.X?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.X?.Value, value);
    return false;
  }
  
  private static void SetX(DXDW.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  private static Int64? GetY(DXDW.Point2DType openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static bool CmpY(DXDW.Point2DType openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Y?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Y?.Value, value);
    return false;
  }
  
  private static void SetY(DXDW.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  public static DMD.Wordprocessing.Point2DType? CreateModelElement(DXDW.Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Wordprocessing.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDW.Point2DType? openXmlElement, DMDW.Point2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpX(openXmlElement, value.X, diffs, objName, propName))
        ok = false;
      if (!CmpY(openXmlElement, value.Y, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDW.Point2DType value)
    where OpenXmlElementType: DXDW.Point2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDW.Point2DType openXmlElement, DMDW.Point2DType value)
  {
    SetX(openXmlElement, value?.X);
    SetY(openXmlElement, value?.Y);
  }
}
