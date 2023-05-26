namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Anchor Point.
/// </summary>
public static class AnchorConverter
{
  /// <summary>
  /// X-Coordinate in 3D
  /// </summary>
  private static Int64? GetX(DXD.Anchor openXmlElement)
  {
    return openXmlElement?.X?.Value;
  }
  
  private static bool CmpX(DXD.Anchor openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.X?.Value == value) return true;
    diffs?.Add(objName, "Cx", openXmlElement?.X?.Value, value);
    return false;
  }
  
  private static void SetX(DXD.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.X = value;
  }
  
  /// <summary>
  /// Y-Coordinate in 3D
  /// </summary>
  private static Int64? GetY(DXD.Anchor openXmlElement)
  {
    return openXmlElement?.Y?.Value;
  }
  
  private static bool CmpY(DXD.Anchor openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Y?.Value == value) return true;
    diffs?.Add(objName, "Cy", openXmlElement?.Y?.Value, value);
    return false;
  }
  
  private static void SetY(DXD.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Y = value;
  }
  
  /// <summary>
  /// Z-Coordinate in 3D
  /// </summary>
  private static Int64? GetZ(DXD.Anchor openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXD.Anchor openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXD.Anchor openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DocumentModel.Drawings.Anchor? CreateModelElement(DXD.Anchor? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Anchor();
      value.X = GetX(openXmlElement);
      value.Y = GetY(openXmlElement);
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Anchor? openXmlElement, DMD.Anchor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpX(openXmlElement, value.X, diffs, objName, propName))
        ok = false;
      if (!CmpY(openXmlElement, value.Y, diffs, objName, propName))
        ok = false;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Anchor value)
    where OpenXmlElementType: DXD.Anchor, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Anchor openXmlElement, DMD.Anchor value)
  {
    SetX(openXmlElement, value?.X);
    SetY(openXmlElement, value?.Y);
    SetZ(openXmlElement, value?.Z);
  }
}
