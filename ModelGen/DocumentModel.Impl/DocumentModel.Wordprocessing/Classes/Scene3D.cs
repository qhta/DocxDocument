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
  
  public Scene3DImpl(): base() {}
  
  public Scene3DImpl(DocumentFormat.OpenXml.Office2010.Word.Scene3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Camera.
  /// </summary>
  public DocumentModel.Wordprocessing.Camera? Camera
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// LightRig.
  /// </summary>
  public DocumentModel.Wordprocessing.LightRig? LightRig
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
