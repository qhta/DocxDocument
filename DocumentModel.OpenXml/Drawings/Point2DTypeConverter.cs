namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the Point2DType Class.
/// </summary>
public static class Point2DTypeConverter
{
  /// <summary>
  /// X-Axis Coordinate
  /// </summary>
  private static Int64? GetX(DXD.Point2DType openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static bool CmpX(DXD.Point2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.X?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.X?.Value, value);
    return false;
  }
  
  private static void SetX(DXD.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Axis Coordinate
  /// </summary>
  private static Int64? GetY(DXD.Point2DType openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static bool CmpY(DXD.Point2DType openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Y?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Y?.Value, value);
    return false;
  }
  
  private static void SetY(DXD.Point2DType openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  public static DocumentModel.Drawings.Point2DType? CreateModelElement(DXD.Point2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Point2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Point2DType? openXmlElement, DMD.Point2DType? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Point2DType value)
    where OpenXmlElementType: DXD.Point2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Point2DType openXmlElement, DMD.Point2DType value)
  {
    SetX(openXmlElement, value?.X);
    SetY(openXmlElement, value?.Y);
  }
}
