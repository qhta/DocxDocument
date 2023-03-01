namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Camera.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  private static DMDraws.PresetCameraKind? GetPreset(DXDraw.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMDraws.PresetCameraKind>(openXmlElement?.Preset?.Value);
  }
  
  private static bool CmpPreset(DXDraw.Camera openXmlElement, DMDraws.PresetCameraKind? value, DiffList? diffs, string? objName)
  {
    return EnumValueConverter.CmpValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMDraws.PresetCameraKind>(openXmlElement?.Preset?.Value, value, diffs, objName);
  }
  
  private static void SetPreset(DXDraw.Camera openXmlElement, DMDraws.PresetCameraKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMDraws.PresetCameraKind>(value);
  }
  
  /// <summary>
  /// Field of View
  /// </summary>
  private static Int32? GetFieldOfView(DXDraw.Camera openXmlElement)
  {
    return openXmlElement?.FieldOfView?.Value;
  }
  
  private static bool CmpFieldOfView(DXDraw.Camera openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.FieldOfView?.Value == value) return true;
    diffs?.Add(objName, "FieldOfView", openXmlElement?.FieldOfView?.Value, value);
    return false;
  }
  
  private static void SetFieldOfView(DXDraw.Camera openXmlElement, Int32? value)
  {
    openXmlElement.FieldOfView = value;
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  private static Int32? GetZoom(DXDraw.Camera openXmlElement)
  {
    return openXmlElement?.Zoom?.Value;
  }
  
  private static bool CmpZoom(DXDraw.Camera openXmlElement, Int32? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement?.Zoom?.Value == value) return true;
    diffs?.Add(objName, "Zoom", openXmlElement?.Zoom?.Value, value);
    return false;
  }
  
  private static void SetZoom(DXDraw.Camera openXmlElement, Int32? value)
  {
    openXmlElement.Zoom = value;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  private static DMDraws.Rotation? GetRotation(DXDraw.Camera openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXDraw.Rotation>();
    if (element != null)
      return DMXDraws.RotationConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpRotation(DXDraw.Camera openXmlElement, DMDraws.Rotation? value, DiffList? diffs, string? objName)
  {
    return DMXDraws.RotationConverter.CompareModelElement(openXmlElement.GetFirstChild<DXDraw.Rotation>(), value, diffs, objName);
  }
  
  private static void SetRotation(DXDraw.Camera openXmlElement, DMDraws.Rotation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXDraw.Rotation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXDraws.RotationConverter.CreateOpenXmlElement<DXDraw.Rotation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Camera? CreateModelElement(DXDraw.Camera? openXmlElement)
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
  
  public static bool CompareModelElement(DXDraw.Camera? openXmlElement, DMDraws.Camera? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpPreset(openXmlElement, value.Preset, diffs, objName))
        ok = false;
      if (!CmpFieldOfView(openXmlElement, value.FieldOfView, diffs, objName))
        ok = false;
      if (!CmpZoom(openXmlElement, value.Zoom, diffs, objName))
        ok = false;
      if (!CmpRotation(openXmlElement, value.Rotation, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Camera value)
    where OpenXmlElementType: DXDraw.Camera, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXDraw.Camera openXmlElement, DMDraws.Camera value)
  {
    SetPreset(openXmlElement, value?.Preset);
    SetFieldOfView(openXmlElement, value?.FieldOfView);
    SetZoom(openXmlElement, value?.Zoom);
    SetRotation(openXmlElement, value?.Rotation);
  }
}
