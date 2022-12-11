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
  
  public HiddenScene3DImpl(): base() {}
  
  public HiddenScene3DImpl(DocumentFormat.OpenXml.Office2010.Drawing.HiddenScene3D openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Camera.
  /// </summary>
  public Camera? Camera
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Light Rig.
  /// </summary>
  public LightRig? LightRig
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Backdrop Plane.
  /// </summary>
  public Backdrop? Backdrop
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
