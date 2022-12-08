namespace DocumentModel.Drawings;

/// <summary>
/// Defines the HiddenScene3D Class.
/// </summary>
public class HiddenScene3DImpl: ModelElementImpl, HiddenScene3D
{
  public DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D?)_OpenXmlElement;
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
