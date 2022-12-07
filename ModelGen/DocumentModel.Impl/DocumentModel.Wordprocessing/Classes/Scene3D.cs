namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public class Scene3DImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.Scene3D>, Scene3D
{
  /// <summary>
  /// Camera.
  /// </summary>
  public Camera? Camera
  {
    get;
    set;
  }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public LightRig? LightRig
  {
    get;
    set;
  }
  
}
