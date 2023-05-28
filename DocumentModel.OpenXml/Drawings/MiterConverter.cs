namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public static class MiterConverter
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  private static Int32? GetLimit(DXD.Miter openXmlElement)
  {
    return openXmlElement?.Limit?.Value;
  }
  
  private static bool CmpLimit(DXD.Miter openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Limit?.Value == value) return true;
    diffs?.Add(objName, "Limit", openXmlElement?.Limit?.Value, value);
    return false;
  }
  
  private static void SetLimit(DXD.Miter openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DMD.Miter? CreateModelElement(DXD.Miter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.Miter();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Miter? openXmlElement, DMD.Miter? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Miter value)
    where OpenXmlElementType: DXD.Miter, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Miter openXmlElement, DMD.Miter value)
  {
    SetLimit(openXmlElement, value?.Limit);
  }
}
