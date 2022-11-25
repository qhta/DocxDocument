namespace DocumentModel.Drawing;

/// <summary>
/// Camera.
/// </summary>
public interface ICamera // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Preset Camera Type
  /// </summary>
  public DocumentModel.Drawing.PresetCameraKind? Preset { get ; set; }
  
  /// <summary>
  /// Field of View
  /// </summary>
  public System.Int32? FieldOfView { get ; set; }
  
  /// <summary>
  /// Zoom
  /// </summary>
  public System.Int32? Zoom { get ; set; }
  
  /// <summary>
  /// Rotation.
  /// </summary>
  public DocumentModel.Drawing.IRotation? Rotation { get ; set; }
  
}
