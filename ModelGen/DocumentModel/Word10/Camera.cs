namespace DocumentModel.Word10;


/// <summary>
///   This element specifies the placement of the camera in the 3D scene.
/// </summary>
public partial class Camera: ModelElement<DXO10W.Camera>
{
  public Camera(): base(){ }
  
  public Camera(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Camera(DXO10W.Camera openXmlElement): base(openXmlElement) { }
  
}
