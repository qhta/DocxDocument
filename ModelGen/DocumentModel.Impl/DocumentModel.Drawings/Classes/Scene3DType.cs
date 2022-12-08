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
