namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Defines the BiLevel Class.
/// </summary>
public static class BiLevelConverter
{
  /// <summary>
  /// Threshold
  /// </summary>
  private static Int32? GetThreshold(DXD.BiLevel openXmlElement)
  {
    return openXmlElement?.Threshold?.Value;
  }
  
  private static bool CmpThreshold(DXD.BiLevel openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Threshold?.Value == value) return true;
    diffs?.Add(objName, "Threshold", openXmlElement?.Threshold?.Value, value);
    return false;
  }
  
  private static void SetThreshold(DXD.BiLevel openXmlElement, Int32? value)
  {
    openXmlElement.Threshold = value;
  }
  
  public static DMD.BiLevel? CreateModelElement(DXD.BiLevel? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMD.BiLevel();
      value.Threshold = GetThreshold(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.BiLevel? openXmlElement, DMD.BiLevel? value, DiffList? diffs = null, string? objName = null, string? propName = null)
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
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.BiLevel value)
    where OpenXmlElementType: DXD.BiLevel, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.BiLevel openXmlElement, DMD.BiLevel value)
  {
    SetThreshold(openXmlElement, value?.Threshold);
  }
}
