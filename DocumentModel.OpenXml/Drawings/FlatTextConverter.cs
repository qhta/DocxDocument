namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// No text in 3D scene.
/// </summary>
public static class FlatTextConverter
{
  /// <summary>
  /// Z Coordinate
  /// </summary>
  private static Int64? GetZ(DXDraw.FlatText openXmlElement)
  {
    return openXmlElement.Z?.Value;
  }
  
  private static bool CmpZ(DXDraw.FlatText openXmlElement, Int64? value, DiffList? diffs, string? objName)
  {
    return openXmlElement.Z?.Value == value;
  }
  
  private static void SetZ(DXDraw.FlatText openXmlElement, Int64? value)
  {
    openXmlElement.Z = value;
  }
  
  public static DMDraws.FlatText? CreateModelElement(DXDraw.FlatText? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.FlatText();
      value.Z = GetZ(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.FlatText? openXmlElement, DMDraws.FlatText? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpZ(openXmlElement, value.Z, diffs, objName))
        ok = false;
      return ok;
    }
    return openXmlElement == null && value == null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.FlatText? value)
    where OpenXmlElementType: DXDraw.FlatText, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetZ(openXmlElement, value?.Z);
      return openXmlElement;
    }
    return default;
  }
}
