namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ChartStringValue Class.
/// </summary>
public static class ChartStringValueConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIndex(DXO16DCD.ChartStringValue openXmlElement)
  {
    return openXmlElement?.Index?.Value;
  }
  
  private static bool CmpIndex(DXO16DCD.ChartStringValue openXmlElement, UInt32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Index?.Value == value) return true;
    diffs?.Add(objName, "Index", openXmlElement?.Index?.Value, value);
    return false;
  }
  
  private static void SetIndex(DXO16DCD.ChartStringValue openXmlElement, UInt32? value)
  {
    openXmlElement.Index = value;
  }
  
  public static DMDCDs.ChartStringValue? CreateModelElement(DXO16DCD.ChartStringValue? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDCDs.ChartStringValue();
      value.Index = GetIndex(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ChartStringValue? openXmlElement, DMDCDs.ChartStringValue? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIndex(openXmlElement, value.Index, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ChartStringValue value)
    where OpenXmlElementType: DXO16DCD.ChartStringValue, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ChartStringValue openXmlElement, DMDCDs.ChartStringValue value)
  {
    SetIndex(openXmlElement, value?.Index);
  }
}
