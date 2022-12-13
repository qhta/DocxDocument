namespace DocumentModel.Drawings;

/// <summary>
/// 3D Scene Properties.
/// </summary>
public class Scene3DTypeImpl: ModelElementImpl, Scene3DType
{
  public DocumentFormat.OpenXml.Drawing.Scene3DType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Scene3DType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public Scene3DTypeImpl(): base() {}
  
  public Scene3DTypeImpl(DocumentFormat.OpenXml.Drawing.Scene3DType openXmlElement): base(openXmlElement)
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
