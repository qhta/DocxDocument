namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Camera.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public static DocumentModel.Drawings.PresetCameraKind? GetPreset(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DocumentModel.Drawings.PresetCameraKind>(openXmlElement?.Preset?.Value);
  }
  
  public static void SetPreset(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, DocumentModel.Drawings.PresetCameraKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DocumentModel.Drawings.PresetCameraKind>(value);
  }
  
  /// <summary>
  /// Field of View
  /// </summary>
  public static Int32? GetFieldOfView(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetFieldOfView(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public static Int32? GetZoom(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetZoom(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, Int32? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public static DocumentModel.Drawings.Rotation? GetRotation(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertyGetter");
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, DocumentModel.Drawings.Rotation? value)
  {
    throw new NotImplementedException("Not implemented 1 in GeneratePropertySetter");
  }
  
}
