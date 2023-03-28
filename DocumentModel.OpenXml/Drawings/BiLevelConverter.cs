namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BiLevel Class converter from/to OpenXml.
///</summary>
public static class BiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXDraw.BiLevel openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  private static bool CmpThreshold(DXDraw.BiLevel openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Threshold?.Value == value) return true;
    diffs?.Add(objName, "Threshold", openXmlElement?.Threshold?.Value, value);
    return false;
  }
  
  private static void SetThreshold(DXDraw.BiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DocumentModel.Drawings.BiLevel? CreateModelElement(DXDraw.BiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.BiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.BiLevel? openXmlElement, DMDraws.BiLevel? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpThreshold(openXmlElement, value.Threshold, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.BiLevel value)
    where OpenXmlElementType: DXDraw.BiLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.BiLevel openXmlElement, DMDraws.BiLevel value)
  {
    SetThreshold(openXmlElement, value?.Threshold);
  }
}
