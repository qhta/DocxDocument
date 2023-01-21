namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public static class PatternFillConverter
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  private static DMDraws.PresetPatternKind? GetPreset(DXDraw.PatternFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DMDraws.PresetPatternKind>(openXmlElement?.Preset?.Value);
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.ForegroundColor>();
    if (itemElement != null)
      return DMXDraws.ForegroundColorConverter.CreateModelElement(itemElement);
    return null;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.BackgroundColor>();
    if (itemElement != null)
      return DMXDraws.BackgroundColorConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.PatternFill? CreateModelElement(DXDraw.PatternFill? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.PatternFill();
      value.Preset = GetPreset(openXmlElement);
      value.ForegroundColor = GetForegroundColor(openXmlElement);
      value.BackgroundColor = GetBackgroundColor(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.PatternFill? value)
    where OpenXmlElementType: DXDraw.PatternFill, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetForegroundColor(openXmlElement, value?.ForegroundColor);
      SetBackgroundColor(openXmlElement, value?.BackgroundColor);
      return openXmlElement;
    }
    return default;
  }
}
