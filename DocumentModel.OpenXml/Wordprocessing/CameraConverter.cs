namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PresetCameraKind? GetPresetCameraType(DXO2010W.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value);
  }
  
  private static bool CmpPresetCameraType(DXO2010W.Camera openXmlElement, DMW.PresetCameraKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value, value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetPresetCameraType(DXO2010W.Camera openXmlElement, DMW.PresetCameraKind? value)
  {
    openXmlElement.PresetCameraType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(value);
  }
  
  public static DMW.Camera? CreateModelElement(DXO2010W.Camera? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Camera();
      value.PresetCameraType = GetPresetCameraType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO2010W.Camera? openXmlElement, DMW.Camera? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPresetCameraType(openXmlElement, value.PresetCameraType, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().ToString(), openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMW.Camera? value)
    where OpenXmlElementType: DXO2010W.Camera, new()
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
