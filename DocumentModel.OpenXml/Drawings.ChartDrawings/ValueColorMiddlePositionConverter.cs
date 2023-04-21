namespace DocumentModel.OpenXml.Drawings.ChartDrawings;

/// <summary>
/// Defines the ValueColorMiddlePosition Class.
/// </summary>
public static class ValueColorMiddlePositionConverter
{
  /// <summary>
  /// NumberColorPosition.
  /// </summary>
  private static Double? GetNumberColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val);
  }
  
  private static bool CmpNumberColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO16DCD.NumberColorPosition>()?.Val, value, diffs, objName, "NumberColorPosition");
  }
  
  private static void SetNumberColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO16DCD.NumberColorPosition,System.Double>(openXmlElement, value);
  }
  
  /// <summary>
  /// PercentageColorPosition.
  /// </summary>
  private static Double? GetPercentageColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement)
  {
    return SimpleValueConverter.GetValue(openXmlElement?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val);
  }
  
  private static bool CmpPercentageColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement, Double? value, DiffList? diffs, string? objName)
  {
    return SimpleValueConverter.CmpValue(openXmlElement?.GetFirstChild<DXO16DCD.PercentageColorPosition>()?.Val, value, diffs, objName, "PercentageColorPosition");
  }
  
  private static void SetPercentageColorPosition(DXO16DCD.ValueColorMiddlePosition openXmlElement, Double? value)
  {
    SimpleValueConverter.SetValue<DXO16DCD.PercentageColorPosition,System.Double>(openXmlElement, value);
  }
  
  public static DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition? CreateModelElement(DXO16DCD.ValueColorMiddlePosition? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.ChartDrawings.ValueColorMiddlePosition();
      value.NumberColorPosition = GetNumberColorPosition(openXmlElement);
      value.PercentageColorPosition = GetPercentageColorPosition(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO16DCD.ValueColorMiddlePosition? openXmlElement, DMDCDs.ValueColorMiddlePosition? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpNumberColorPosition(openXmlElement, value.NumberColorPosition, diffs, objName))
        ok = false;
      if (!CmpPercentageColorPosition(openXmlElement, value.PercentageColorPosition, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDCDs.ValueColorMiddlePosition value)
    where OpenXmlElementType: DXO16DCD.ValueColorMiddlePosition, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO16DCD.ValueColorMiddlePosition openXmlElement, DMDCDs.ValueColorMiddlePosition value)
  {
    SetNumberColorPosition(openXmlElement, value?.NumberColorPosition);
    SetPercentageColorPosition(openXmlElement, value?.PercentageColorPosition);
  }
}
