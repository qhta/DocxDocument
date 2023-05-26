namespace DocumentModel.OpenXml.Wordprocessing;

/// <summary>
/// Defines the Camera Class.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// prst, this property is only available in Office 2010 and later.
  /// </summary>
  private static DMW.PresetCameraKind? GetPresetCameraType(DXO10W.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value);
  }
  
  private static bool CmpPresetCameraType(DXO10W.Camera openXmlElement, DMW.PresetCameraKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(openXmlElement?.PresetCameraType?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPresetCameraType(DXO10W.Camera openXmlElement, DMW.PresetCameraKind? value)
  {
    openXmlElement.PresetCameraType = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Office2010.Word.PresetCameraTypeValues, DMW.PresetCameraKind>(value);
  }
  
  public static DMW.Camera? CreateModelElement(DXO10W.Camera? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMW.Camera();
      value.PresetCameraType = GetPresetCameraType(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXO10W.Camera? openXmlElement, DMW.Camera? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPresetCameraType(openXmlElement, value.PresetCameraType, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMW.Camera value)
    where OpenXmlElementType: DXO10W.Camera, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXO10W.Camera openXmlElement, DMW.Camera value)
  {
    SetPresetCameraType(openXmlElement, value?.PresetCameraType);
  }
}
