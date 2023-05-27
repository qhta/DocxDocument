namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public static class PatternFillConverter
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  private static DMD.PresetPatternKind? GetPreset(DXD.PatternFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMD.PresetPatternKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXD.PatternFill openXmlElement, DMD.PresetPatternKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMD.PresetPatternKind>(openXmlElement?.Preset?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPreset(DXD.PatternFill openXmlElement, DMD.PresetPatternKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMD.PresetPatternKind>(value);
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  private static DMD.ForegroundColor? GetForegroundColor(DXD.PatternFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.ForegroundColor>();
    if (element != null)
      return DMXD.ForegroundColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpForegroundColor(DXD.PatternFill openXmlElement, DMD.ForegroundColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.ForegroundColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.ForegroundColor>(), value, diffs, objName, propName);
  }
  
  private static void SetForegroundColor(DXD.PatternFill openXmlElement, DMD.ForegroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.ForegroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.ForegroundColorConverter.CreateOpenXmlElement<DXD.ForegroundColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  private static DMD.BackgroundColor? GetBackgroundColor(DXD.PatternFill openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.BackgroundColor>();
    if (element != null)
      return DMXD.BackgroundColorConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpBackgroundColor(DXD.PatternFill openXmlElement, DMD.BackgroundColor? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.BackgroundColorConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.BackgroundColor>(), value, diffs, objName, propName);
  }
  
  private static void SetBackgroundColor(DXD.PatternFill openXmlElement, DMD.BackgroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.BackgroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.BackgroundColorConverter.CreateOpenXmlElement<DXD.BackgroundColor>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PatternFill? CreateModelElement(DXD.PatternFill? openXmlElement)
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
  
  public static bool CompareModelElement(DXD.PatternFill? openXmlElement, DMD.PatternFill? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName, propName))
        ok = false;
      if (!CmpForegroundColor(openXmlElement, value.ForegroundColor, diffs, objName, propName))
        ok = false;
      if (!CmpBackgroundColor(openXmlElement, value.BackgroundColor, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static DXD.PatternFill CreateOpenXmlElement(DMD.PatternFill value)
  {
    var openXmlElement = new DXD.PatternFill();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static bool UpdateOpenXmlElement(DXD.PatternFill openXmlElement, DMD.PatternFill value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetForegroundColor(openXmlElement, value?.ForegroundColor);
    SetBackgroundColor(openXmlElement, value?.BackgroundColor);
    return true;
  }
}
