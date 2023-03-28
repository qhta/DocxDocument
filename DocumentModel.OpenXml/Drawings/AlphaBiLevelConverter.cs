namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public static class AlphaBiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXDraw.AlphaBiLevel openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  private static bool CmpThreshold(DXDraw.AlphaBiLevel openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Threshold?.Value == value) return true;
    diffs?.Add(objName, "Threshold", openXmlElement?.Threshold?.Value, value);
    return false;
  }
  
  private static void SetThreshold(DXDraw.AlphaBiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DocumentModel.Drawings.AlphaBiLevel? CreateModelElement(DXDraw.AlphaBiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.AlphaBiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.AlphaBiLevel? openXmlElement, DMDraws.AlphaBiLevel? value, DiffList? diffs, string? objName)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.AlphaBiLevel value)
    where OpenXmlElementType: DXDraw.AlphaBiLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.AlphaBiLevel openXmlElement, DMDraws.AlphaBiLevel value)
  {
    SetThreshold(openXmlElement, value?.Threshold);
  }
}
