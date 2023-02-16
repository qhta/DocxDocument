namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Miter Line Join.
/// </summary>
public static class MiterConverter
{
  /// <summary>
  /// Miter Join Limit
  /// </summary>
  private static Int32? GetLimit(DXDraw.Miter openXmlElement)
  {
    return openXmlElement?.Limit?.Value;
  }
  
  private static bool CmpLimit(DXDraw.Miter openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Limit?.Value == value) return true;
    diffs?.Add(objName, "Limit", openXmlElement?.Limit?.Value, value);
    return false;
  }
  
  private static void SetLimit(DXDraw.Miter openXmlElement, Int32? value)
  {
    openXmlElement.Limit = value;
  }
  
  public static DocumentModel.Drawings.Miter? CreateModelElement(DXDraw.Miter? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Miter();
      value.Limit = GetLimit(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.Miter? openXmlElement, DMDraws.Miter? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpLimit(openXmlElement, value.Limit, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Miter? value)
    where OpenXmlElementType: DXDraw.Miter, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetLimit(openXmlElement, value?.Limit);
      return openXmlElement;
    }
    return default;
  }
}
