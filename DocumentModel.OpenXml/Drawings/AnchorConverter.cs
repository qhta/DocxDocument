namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  private static Int64? GetX(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static bool CmpX(DXDraw.Anchor openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.X?.Value == value) return true;
    diffs?.Add(objName, "X", openXmlElement?.X?.Value, value);
    return false;
  }
  
  private static void SetX(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  private static Int64? GetY(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static bool CmpY(DXDraw.Anchor openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Y?.Value == value) return true;
    diffs?.Add(objName, "Y", openXmlElement?.Y?.Value, value);
    return false;
  }
  
  private static void SetY(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  private static Int64? GetZ(DXDraw.Anchor openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXDraw.Anchor openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXDraw.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DMDraws.Anchor? CreateModelElement(DXDraw.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Anchor();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Anchor? openXmlElement, DMDraws.Anchor? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpX(openXmlElement, value.X, diffs, objName))
        ok = false;
      if (!CmpY(openXmlElement, value.Y, diffs, objName))
        ok = false;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Anchor? value)
    where OpenXmlElementType: DXDraw.Anchor, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetX(openXmlElement, value?.X);
      SetY(openXmlElement, value?.Y);
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
