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
  
  public Scene3DImpl(): base() {}
  
  public Scene3DImpl(DocumentFormat.OpenXml.Drawing.Diagrams.Scene3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Drawings.Camera? Camera
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public DocumentModel.Drawings.LightRig? LightRig
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public DocumentModel.Drawings.Backdrop? Backdrop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
