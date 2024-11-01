namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AdjustPoint2DType Class.
/// </summary>
public static class AdjustPoint2DTypeConverter
{
  /// <summary>
  /// X-Coordinate
  /// </summary>
  private static String? GetX(DXD.AdjustPoint2DType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.X);
  }
  
  private static bool CmpX(DXD.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.X, value, diffs, objName, "Cx");
  }
  
  private static void SetX(DXD.AdjustPoint2DType openXmlElement, String? value)
  {
    openXmlElement.X = StringValueConverter.CreateStringValue(value);
  }
  
  /// <summary>
  /// Y-Coordinate
  /// </summary>
  private static String? GetY(DXD.AdjustPoint2DType openXmlElement)
  {
    return StringValueConverter.GetValue(openXmlElement?.Y);
  }
  
  private static bool CmpY(DXD.AdjustPoint2DType openXmlElement, String? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return StringValueConverter.CmpValue(openXmlElement?.Y, value, diffs, objName, "Cy");
  }
  
  private static void SetY(DXD.AdjustPoint2DType openXmlElement, String? value)
  {
    openXmlElement.Y = StringValueConverter.CreateStringValue(value);
  }
  
  public static DMD.AdjustPoint2DType? CreateModelElement(DXD.AdjustPoint2DType? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AdjustPoint2DType();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AdjustPoint2DType? openXmlElement, DMD.AdjustPoint2DType? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AdjustPoint2DType value)
    where OpenXmlElementType: DXD.AdjustPoint2DType, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AdjustPoint2DType openXmlElement, DMD.AdjustPoint2DType value)
  {
    SetX(openXmlElement, value?.X);
    SetY(openXmlElement, value?.Y);
  }
}
