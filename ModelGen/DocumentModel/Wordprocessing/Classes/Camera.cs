namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the placement of the camera in the 3D scene.
/// </summary>
public partial class Camera
{
  
  /// <summary>
  ///   prst, this property is only available in Office 2010 and later.
  /// </summary>
  public PresetCameraTypeKind? PresetCameraType { get; set; }
  
}
