namespace DocumentModel.Word10;


/// <summary>
///   This element specifies 3-D scene properties of text, including camera and lighting. By default, text does not have 3-D scene properties
/// </summary>
public partial class Scene3D
{
  
  /// <summary>
  ///   Camera.
  /// </summary>
  public DMW10.Camera? Camera { get; set; }
  
  
  /// <summary>
  ///   LightRig.
  /// </summary>
  public DMW10.LightRig? LightRig { get; set; }
  
}
