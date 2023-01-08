namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset Text Warp.
/// </summary>
public static class PresetTextWrapConverter
{
  /// <summary>
  /// Preset Warp Shape
  /// </summary>
  public static DocumentModel.Drawings.TextShapeKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DocumentModel.Drawings.TextShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement, DocumentModel.Drawings.TextShapeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.TextShapeValues, DocumentModel.Drawings.TextShapeKind>(value);
  }
  
  /// <summary>
  /// Adjust Value List.
  /// </summary>
  public static DocumentModel.Drawings.AdjustValueList? GetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetTextWrap? openXmlElement, DocumentModel.Drawings.AdjustValueList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
