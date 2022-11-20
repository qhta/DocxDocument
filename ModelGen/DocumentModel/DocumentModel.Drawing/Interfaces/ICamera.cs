namespace DocumentModel.Drawing;

/// <summary>
/// Camera.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IRotation))]
public interface ICamera // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public PresetCameraValues? Preset { get ; set; }
  
  /// <summary>
  /// Field of View
  /// </summary>
  public int? FieldOfView { get ; set; }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public int? Zoom { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public IRotation? Rotation { get ; set; }
  
}
