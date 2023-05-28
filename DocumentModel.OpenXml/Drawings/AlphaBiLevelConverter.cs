namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the AlphaBiLevel Class.
/// </summary>
public static class AlphaBiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXD.AlphaBiLevel openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  private static bool CmpThreshold(DXD.AlphaBiLevel openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Threshold?.Value == value) return true;
    diffs?.Add(objName, "Threshold", openXmlElement?.Threshold?.Value, value);
    return false;
  }
  
  private static void SetThreshold(DXD.AlphaBiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DMD.AlphaBiLevel? CreateModelElement(DXD.AlphaBiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.AlphaBiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.AlphaBiLevel? openXmlElement, DMD.AlphaBiLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpThreshold(openXmlElement, value.Threshold, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.AlphaBiLevel value)
    where OpenXmlElementType: DXD.AlphaBiLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.AlphaBiLevel openXmlElement, DMD.AlphaBiLevel value)
  {
    SetThreshold(openXmlElement, value?.Threshold);
  }
}
