namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Replace Effect converter from/to OpenXml.
///</summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  /// Alpha
  /// </summary>
  private static Int32? GetAlpha(DXDraw.AlphaReplace openXmlElement)
  {
    return openXmlElement?.Alpha?.Value;
  }
  
  private static bool CmpAlpha(DXDraw.AlphaReplace openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Alpha?.Value == value) return true;
    diffs?.Add(objName, "Alpha", openXmlElement?.Alpha?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXDraw.AlphaReplace openXmlElement, Int32? value)
  {
    openXmlElement.Alpha = value;
  }
  
  public static DocumentModel.Drawings.AlphaReplace? CreateModelElement(DXDraw.AlphaReplace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaReplace();
      value.Alpha = GetAlpha(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AlphaReplace? openXmlElement, DMDraws.AlphaReplace? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaReplace value)
    where OpenXmlElementType: DXDraw.AlphaReplace, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AlphaReplace openXmlElement, DMDraws.AlphaReplace value)
  {
    SetAlpha(openXmlElement, value?.Alpha);
  }
}
