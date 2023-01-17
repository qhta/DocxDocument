namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Pattern Fill.
/// </summary>
public static class PatternFillConverter
{
  /// <summary>
  /// Preset Pattern
  /// </summary>
  private static DocumentModel.Drawings.PresetPatternKind? GetPreset(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DocumentModel.Drawings.PresetPatternKind>(openXmlElement?.Preset?.Value);
  }
  
  private static void SetPreset(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement, DocumentModel.Drawings.PresetPatternKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetPatternValues, DocumentModel.Drawings.PresetPatternKind>(value);
  }
  
  /// <summary>
  /// Foreground color.
  /// </summary>
  private static DocumentModel.Drawings.ForegroundColor? GetForegroundColor(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.ForegroundColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetForegroundColor(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement, DocumentModel.Drawings.ForegroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.ForegroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.ForegroundColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.ForegroundColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Background color.
  /// </summary>
  private static DocumentModel.Drawings.BackgroundColor? GetBackgroundColor(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.BackgroundColorConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetBackgroundColor(DocumentFormat.OpenXml.Drawing.PatternFill openXmlElement, DocumentModel.Drawings.BackgroundColor? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.BackgroundColor>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.BackgroundColorConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.BackgroundColor>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.PatternFill? CreateModelElement(DocumentFormat.OpenXml.Drawing.PatternFill? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.PatternFill? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.PatternFill, new()
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
