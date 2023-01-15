using DocumentFormat.OpenXml.Drawing;
using DocumentModel.Drawings;
using Camera = DocumentFormat.OpenXml.Drawing.Camera;
using Rotation = DocumentModel.Drawings.Rotation;

namespace DocumentModel.OpenXml.Drawings;

/// <summary>
///   Camera.
/// </summary>
public static class CameraConverter
{
  /// <summary>
  ///   Preset Camera Type
  /// </summary>
  public static PresetCameraKind? GetPreset(Camera? openXmlElement)
  {
    return EnumValueConverter.GetValue<PresetCameraValues, PresetCameraKind>(openXmlElement?.Preset?.Value);
  }

  public static void SetPreset(Camera? openXmlElement, PresetCameraKind? value)
  {
    if (openXmlElement != null)
      openXmlElement.Preset = EnumValueConverter.CreateEnumValue<PresetCameraValues, PresetCameraKind>(value);
  }

  /// <summary>
  ///   Field of View
  /// </summary>
  public static Int32? GetFieldOfView(Camera? openXmlElement)
  {
    return openXmlElement?.FieldOfView?.Value;
  }

  public static void SetFieldOfView(Camera? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.FieldOfView = value;
  }

  /// <summary>
  ///   Zoom
  /// </summary>
  public static Int32? GetZoom(Camera? openXmlElement)
  {
    return openXmlElement?.Zoom?.Value;
  }

  public static void SetZoom(Camera? openXmlElement, Int32? value)
  {
    if (openXmlElement != null)
      openXmlElement.Zoom = value;
  }

  /// <summary>
  ///   Rotation.
  /// </summary>
  public static Rotation? GetRotation(Camera? openXmlElement)
  {
    var itemElement = openXmlElement?.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
    if (itemElement != null)
      return RotationConverter.CreateModelElement(itemElement);
    return null;
  }

  public static void SetRotation(Camera? openXmlElement, Rotation? value)
  {
    if (openXmlElement != null)
    {
      var itemElement = openXmlElement.GetFirstChild<DocumentFormat.OpenXml.Drawing.Rotation>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RotationConverter.CreateOpenXmlElement<DocumentFormat.OpenXml.Drawing.Rotation>(value);
        if (itemElement != null)
          openXmlElement.AddChild(itemElement);
      }
    }
  }

  public static DocumentModel.Drawings.Camera? CreateModelElement(Camera? openXmlElement)
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
    where OpenXmlElementType : Camera, new()
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