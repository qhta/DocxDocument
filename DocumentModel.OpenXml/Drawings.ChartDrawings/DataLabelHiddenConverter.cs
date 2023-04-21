namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the DataLabelHidden Class.
/// </summary>
public static class DataLabelHiddenConverter
{
  /// <summary>
  /// idx, this property is only available in Office 2016 and later.
  /// </summary>
  private static UInt32? GetIdx(DXO16DCD.DataLabelHidden openXmlElement)
  {
    return openXmlElement?.Idx?.Value;
  }
  
  private static bool CmpIdx(DXO16DCD.DataLabelHidden openXmlElement, UInt32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Idx?.Value == value) return true;
    diffs?.Add(objName, "Idx", openXmlElement?.Idx?.Value, value);
    return false;
  }
  
  private static void SetIdx(DXO16DCD.DataLabelHidden openXmlElement, UInt32? value)
  {
    openXmlElement.Idx = value;
  }
  
  public static DocumentModel.Drawings.ChartDrawings.DataLabelHidden? CreateModelElement(DXO16DCD.DataLabelHidden? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.DataLabelHidden();
      value.Idx = GetIdx(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.DataLabelHidden? openXmlElement, DMDCDs.DataLabelHidden? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpIdx(openXmlElement, value.Idx, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.DataLabelHidden value)
    where OpenXmlElementType: DXO16DCD.DataLabelHidden, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.DataLabelHidden openXmlElement, DMDCDs.DataLabelHidden value)
  {
    SetIdx(openXmlElement, value?.Idx);
  }
}
