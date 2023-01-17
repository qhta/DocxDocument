namespace DocumentModel.OpenXml.Drawings;

/// <summary>
/// Camera.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  private static DocumentModel.Drawings.PresetCameraKind? GetPreset(DocumentFormat.OpenXml.Drawing.Camera openXmlElement)
  {
    return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DocumentModel.Drawings.PresetCameraKind>(openXmlElement?.Preset?.Value);
  }
  
  private static void SetPreset(DocumentFormat.OpenXml.Drawing.Camera openXmlElement, DocumentModel.Drawings.PresetCameraKind? value)
  {
    openXmlElement.Preset = EnumValueConverter.CreateEnumValue<DocumentFormat.OpenXml.Drawing.PresetCameraValues, DocumentModel.Drawings.PresetCameraKind>(value);
  }
  
  /// <summary>
  /// Field of View
  /// </summary>
  private static Int32? GetFieldOfView(DocumentFormat.OpenXml.Drawing.Camera openXmlElement)
  {
    return openXmlElement.FieldOfView?.Value;
  }
  
  private static void SetFieldOfView(DocumentFormat.OpenXml.Drawing.Camera openXmlElement, Int32? value)
  {
    openXmlElement.FieldOfView = value;
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  private static Int32? GetZoom(DocumentFormat.OpenXml.Drawing.Camera openXmlElement)
  {
    return openXmlElement.Zoom?.Value;
  }
  
  private static void SetZoom(DocumentFormat.OpenXml.Drawing.Camera openXmlElement, Int32? value)
  {
    openXmlElement.Zoom = value;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  private static DocumentModel.Drawings.Rotation? GetRotation(DocumentFormat.OpenXml.Drawing.Camera openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RotationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  private static void SetRotation(DocumentFormat.OpenXml.Drawing.Camera openXmlElement, DocumentModel.Drawings.Rotation? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DocumentModel.OpenXml.Drawings.RotationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rotation>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Drawings.Camera? CreateModelElement(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
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
  
  public static OpenXmlElementType? CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Drawings.Camera? value)
    where OpenXmlElementType: DocumentFormat.OpenXml.Drawing.Camera, new()
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
