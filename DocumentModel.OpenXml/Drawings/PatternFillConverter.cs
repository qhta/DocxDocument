namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public static class PatternFillConverter
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  public static DocumentModel.Drawings.PresetPatternKind? GetPreset(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DocumentModel.Drawings.PresetPatternKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement, DocumentModel.Drawings.PresetPatternKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DocumentModel.Drawings.PresetPatternKind>(value);
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  public static DocumentModel.Drawings.ForegroundColor? GetForegroundColor(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetForegroundColor(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement, DocumentModel.Drawings.ForegroundColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  public static DocumentModel.Drawings.BackgroundColor? GetBackgroundColor(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetBackgroundColor(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement, DocumentModel.Drawings.BackgroundColor? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
