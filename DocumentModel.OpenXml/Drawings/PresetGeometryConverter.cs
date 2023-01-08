namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Preset geometry.
/// </summary>
public static class PresetGeometryConverter
{
  /// <summary>
  /// Preset Shape
  /// </summary>
  public static DocumentModel.Drawings.ShapeKind? GetPreset(DocumentFormat.OpenXml.Drawing.PresetGeometry? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DocumentModel.Drawings.ShapeKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.PresetGeometry? openXmlElement, DocumentModel.Drawings.ShapeKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.ShapeTypeValues, DocumentModel.Drawings.ShapeKind>(value);
  }
  
  /// <summary>
  /// List of Shape Adjust Values.
  /// </summary>
  public static DocumentModel.Drawings.AdjustValueList? GetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetGeometry? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetAdjustValueList(DocumentFormat.OpenXml.Drawing.PresetGeometry? openXmlElement, DocumentModel.Drawings.AdjustValueList? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
