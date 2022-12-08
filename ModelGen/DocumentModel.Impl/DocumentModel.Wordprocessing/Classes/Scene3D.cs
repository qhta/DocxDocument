namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Scene3D Class.
/// </summary>
public class Scene3DImpl: ModelElementImpl, Scene3D
{
  public DocumentFormat.OpenXml.Office2010.Word.Scene3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Word.Scene3D?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
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
