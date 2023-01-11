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
    return openXmlElement?.FieldOfView?.Value;
  }
  
  public static void SetFieldOfView(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FieldOfView = value;
  }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public static Int32? GetZoom(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    return openXmlElement?.Zoom?.Value;
  }
  
  public static void SetZoom(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Zoom = value;
  }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public static DocumentModel.Drawings.Rotation? GetRotation(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      return DocumentModel.OpenXml.Drawings.RotationConverter.CreateModelElement(itemElement);
    return null;
  }
  
  public static void SetRotation(DocumentFormat.OpenXml.Drawing.Camera? openXmlElement, DocumentModel.Drawings.Rotation? value)
  {
    if (openXmlElement != null)
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
  throw new NotImplementedException("Not implemented in GenerateCreateOpenXmlElementMethod: 1");
  }
}
