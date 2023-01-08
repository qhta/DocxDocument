namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  public static DocumentModel.Wordprocessing.PresetCameraKind? GetPresetCameraType(DocumentFormat.OpenXml.Office2010.Word.Camera? openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DocumentModel.Wordprocessing.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value);
  }
  
  public static void SetPresetCameraType(DocumentFormat.OpenXml.Office2010.Word.Camera? openXmlElement, DocumentModel.Wordprocessing.PresetCameraKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetCameraType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DocumentModel.Wordprocessing.PresetCameraKind>(value);
  }
  
}
