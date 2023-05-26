namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Alpha Replace Effect.
/// </summary>
public static class AlphaReplaceConverter
{
  /// <summary>
  /// Alpha
  /// </summary>
  private static Int32? GetAlpha(DXD.AlphaReplace openXmlElement)
  {
    return openXmlElement?.Alpha?.Value;
  }
  
  private static bool CmpAlpha(DXD.AlphaReplace openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Alpha?.Value == value) return true;
    diffs?.Add(objName, "Alpha", openXmlElement?.Alpha?.Value, value);
    return false;
  }
  
  private static void SetAlpha(DXD.AlphaReplace openXmlElement, Int32? value)
  {
    openXmlElement.Alpha = value;
  }
  
  public static DocumentModel.Drawings.AlphaReplace? CreateModelElement(DXD.AlphaReplace? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaReplace();
      value.Alpha = GetAlpha(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AlphaReplace? openXmlElement, DMD.AlphaReplace? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpAlpha(openXmlElement, value.Alpha, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AlphaReplace value)
    where OpenXmlElementType: DXD.AlphaReplace, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AlphaReplace openXmlElement, DMD.AlphaReplace value)
  {
    SetAlpha(openXmlElement, value?.Alpha);
  }
}
