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
  
  private static void SetPreset(DXDraw.Camera openXmlElement, DMDraws.PresetCameraKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DMDraws.PresetCameraKind>(value);
  }
  
  /// <summary>
  /// Field of View
  /// </summary>
  private static Int32? GetFieldOfView(DXDraw.Camera openXmlElement)
  {
    return openXmlElement.FieldOfView?.Value;
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
    return openXmlElement.Zoom?.Value;
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
    var itemElement = openXmlElement?.GetFirstChild<DXDraw.Rotation>();
    if (itemElement != null)
      return DMXDraws.RotationConverter.CreateModelElement(itemElement);
    return null;
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
  
  public static DMDraws.Camera? CreateModelElement(DXDraw.Camera? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DMDraws.Camera();
      value.Preset = GetPreset(openXmlElement);
      value.FieldOfView = GetFieldOfView(openXmlElement);
      value.Zoom = GetZoom(openXmlElement);
      value.Rotation = GetRotation(openXmlElement);
      return value;
    }
    return null;
  }
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DMDraws.Camera? value)
    where OpenXmlElementType: DXDraw.Camera, new()
  {
    if (value != null)
    {
      var openXmlElement = new OpenXmlElementType();
      SetPreset(openXmlElement, value?.Preset);
      SetFieldOfView(openXmlElement, value?.FieldOfView);
      SetZoom(openXmlElement, value?.Zoom);
      SetRotation(openXmlElement, value?.Rotation);
      return openXmlElement;
    }
    return default;
  }
}
