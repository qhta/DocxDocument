namespace DocumentModel.Drawings;


/// <summary>
///   This element defines the placement and properties of the camera in the 3D scene.  The camera position and properties modify the view of the scene.
/// </summary>
public partial class Camera
{
  
  /// <summary>
  ///   Provides an override for the default field of view for the camera.  Different perspectives can be obtained by modifying this attribute.
  /// </summary>
  public Int32? FieldOfView { get; set; }
  
  
  /// <summary>
  ///   Defines the zoom factor of a given camera element.  The zoom modifies the scene as a whole and zooms in or out accordingly.
  /// </summary>
  public Int32? Zoom { get; set; }
  
  
  /// <summary>
  ///   Rotation.
  /// </summary>
  public DocumentModel.Drawings.Rotation? Rotation { get; set; }
  
}
