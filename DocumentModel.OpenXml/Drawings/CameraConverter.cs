namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Camera.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  private static DMD.PresetCameraKind? GetPreset(DXD.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMD.PresetCameraKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXD.Camera openXmlElement, DMD.PresetCameraKind? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMD.PresetCameraKind>(openXmlElement?.Preset?.Value, value, diffs, objName, propName);
  }
  
  private static void SetPreset(DXD.Camera openXmlElement, DMD.PresetCameraKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMD.PresetCameraKind>(value);
  }
  
  /// <summary>
  /// Field of View
  /// </summary>
  private static Int32? GetFieldOfView(DXD.Camera openXmlElement)
  {
    return openXmlElement?.FieldOfView?.Value;
  }
  
  private static bool CmpFieldOfView(DXD.Camera openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.FieldOfView?.Value == value) return true;
    diffs?.Add(objName, "FieldOfView", openXmlElement?.FieldOfView?.Value, value);
    return false;
  }
  
  private static void SetFieldOfView(DXD.Camera openXmlElement, Int32? value)
  {
    openXmlElement.FieldOfView = value;
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  private static Int32? GetZoom(DXD.Camera openXmlElement)
  {
    return openXmlElement?.Zoom?.Value;
  }
  
  private static bool CmpZoom(DXD.Camera openXmlElement, Int32? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement?.Zoom?.Value == value) return true;
    diffs?.Add(objName, "Zoom", openXmlElement?.Zoom?.Value, value);
    return false;
  }
  
  private static void SetZoom(DXD.Camera openXmlElement, Int32? value)
  {
    openXmlElement.Zoom = value;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  private static DMD.Rotation? GetRotation(DXD.Camera openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXD.Rotation>();
    if (element != null)
      return DMXD.RotationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRotation(DXD.Camera openXmlElement, DMD.Rotation? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    return DMXD.RotationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXD.Rotation>(), value, diffs, objName, propName);
  }
  
  private static void SetRotation(DXD.Camera openXmlElement, DMD.Rotation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXD.Rotation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXD.RotationConverter.CreateOpenXmlElement<DXD.Rotation>(value);
      if (itemElement != null)
        openXmlElement.AppendChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Camera? CreateModelElement(DXD.Camera? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Drawings.Camera();
      value.Preset = GetPreset(openXmlElement);
      value.FieldOfView = GetFieldOfView(openXmlElement);
      value.Zoom = GetZoom(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXD.Camera? openXmlElement, DMD.Camera? value, DiffList? diffs = null, string? objName = null, string? propName = null)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName, propName))
        ok = false;
      if (!CmpFieldOfView(openXmlElement, value.FieldOfView, diffs, objName, propName))
        ok = false;
      if (!CmpZoom(openXmlElement, value.Zoom, diffs, objName, propName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName, propName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, propName ?? openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMD.Camera value)
    where OpenXmlElementType: DXD.Camera, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXD.Camera openXmlElement, DMD.Camera value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetFieldOfView(openXmlElement, value?.FieldOfView);
    SetZoom(openXmlElement, value?.Zoom);
    SetRotation(openXmlElement, value?.Rotation);
  }
}
