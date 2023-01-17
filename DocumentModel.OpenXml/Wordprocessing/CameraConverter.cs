namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DocumentModel.Wordprocessing.PresetCameraKind? GetPresetCameraType(DocumentFormat.OpenXml.Office2010.Word.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DocumentModel.Wordprocessing.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value);
  }
  
  private static void SetPresetCameraType(DocumentFormat.OpenXml.Office2010.Word.Camera openXmlElement, DocumentModel.Wordprocessing.PresetCameraKind? value)
  {
    openXmlElement.PresetCameraType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DocumentModel.Wordprocessing.PresetCameraKind>(value);
  }
  
  public static DocumentModel.Wordprocessing.Camera? CreateModelElement(DocumentFormat.OpenXml.Office2010.Word.Camera? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Wordprocessing.Camera();
      value.PresetCameraType = GetPresetCameraType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Wordprocessing.Camera? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Office2010.Word.Camera, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPresetCameraType(openXmlElement, value?.PresetCameraType);
      return openXmlElement;
    }
    return default;
  }
}
