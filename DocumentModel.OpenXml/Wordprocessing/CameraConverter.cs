using DocumentFormat.OpenXml.Office2010.Word;
using DocumentModel.Wordprocessing;
using Camera = DocumentFormat.OpenXml.Office2010.Word.Camera;

namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
///   Defines the Camera Class.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  public static PresetCameraKind? GetPresetCameraType(Camera? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetCameraTypeValues, PresetCameraKind>(openXmlElement?.PresetCameraType?.Value);
  }

  public static void SetPresetCameraType(Camera? openXmlElement, PresetCameraKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.PresetCameraType = EnumValueConverter.CreateEnumValue<PresetCameraTypeValues, PresetCameraKind>(value);
  }

  public static DocumentModel.Wordprocessing.Camera? CreateModelElement(Camera? openXmlElement)
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
    where OpenXmlElementType : Camera, new()
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