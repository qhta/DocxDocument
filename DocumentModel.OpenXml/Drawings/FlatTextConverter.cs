namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  private static Int64? GetZ(DXD.FlatText openXmlElement)
  {
    return openXmlElement?.Z?.Value;
  }
  
  private static bool CmpZ(DXD.FlatText openXmlElement, Int64? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Z?.Value == value) return true;
    diffs?.Add(objName, "Z", openXmlElement?.Z?.Value, value);
    return false;
  }
  
  private static void SetZ(DXD.FlatText openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DMD.FlatText? CreateModelElement(DXD.FlatText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.FlatText();
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.FlatText? openXmlElement, DMD.FlatText? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.FlatText value)
    where OpenXmlElementType: DXD.FlatText, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.FlatText openXmlElement, DMD.FlatText value)
  {
    SetZ(openXmlElement, value?.Z);
  }
}
