namespace DocumentModel.Drawings;

/// <summary>
/// 3-D Scene.
/// </summary>
public class Scene3DImpl: ModelElementImpl, Scene3D
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D?)_OpenXmlElement;
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
  /// Light Rig.
  /// </summary>
  public LightRig? LightRig
  {
    get;
    set;
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public Backdrop? Backdrop
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
