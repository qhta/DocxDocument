namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Pattern Fill converter from/to OpenXml.
///</summary>
public static class PatternFillConverter
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  private static DMDraws.PresetPatternKind? GetPreset(DXDraw.PatternFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMDraws.PresetPatternKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXDraw.PatternFill openXmlElement, DMDraws.PresetPatternKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMDraws.PresetPatternKind>(openXmlElement?.Preset?.Value, value, diffs, objName);
  }
  
  private static void SetPreset(DXDraw.PatternFill openXmlElement, DMDraws.PresetPatternKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMDraws.PresetPatternKind>(value);
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  private static DMDraws.ForegroundColor? GetForegroundColor(DXDraw.PatternFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.ForegroundColor>();
    if (element != null)
      return DMXDraws.ForegroundColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpForegroundColor(DXDraw.PatternFill openXmlElement, DMDraws.ForegroundColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.ForegroundColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.ForegroundColor>(), value, diffs, objName);
  }
  
  private static void SetForegroundColor(DXDraw.PatternFill openXmlElement, DMDraws.ForegroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.ForegroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.ForegroundColorConverter.CreateOpenXmlElement<DXDraw.ForegroundColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  private static DMDraws.BackgroundColor? GetBackgroundColor(DXDraw.PatternFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.BackgroundColor>();
    if (element != null)
      return DMXDraws.BackgroundColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundColor(DXDraw.PatternFill openXmlElement, DMDraws.BackgroundColor? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.BackgroundColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.BackgroundColor>(), value, diffs, objName);
  }
  
  private static void SetBackgroundColor(DXDraw.PatternFill openXmlElement, DMDraws.BackgroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.BackgroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.BackgroundColorConverter.CreateOpenXmlElement<DXDraw.BackgroundColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PatternFill? CreateModelElement(DXDraw.PatternFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.PatternFill();
      value.Preset = GetPreset(openXmlElement);
      value.ForegroundColor = GetForegroundColor(openXmlElement);
      value.BackgroundColor = GetBackgroundColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXDraw.PatternFill? openXmlElement, DMDraws.PatternFill? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName))
        ok = false;
      if (!CmpForegroundColor(openXmlElement, value.ForegroundColor, diffs, objName))
        ok = false;
      if (!CmpBackgroundColor(openXmlElement, value.BackgroundColor, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PatternFill value)
    where OpenXmlElementType: DXDraw.PatternFill, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.PatternFill openXmlElement, DMDraws.PatternFill value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetForegroundColor(openXmlElement, value?.ForegroundColor);
    SetBackgroundColor(openXmlElement, value?.BackgroundColor);
  }
}
