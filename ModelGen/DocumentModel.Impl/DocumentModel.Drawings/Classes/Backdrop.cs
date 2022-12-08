namespace DocumentModel.Drawings;

/// <summary>
/// Backdrop Plane.
/// </summary>
public class BackdropImpl: ModelElementImpl, Backdrop
{
  public DocumentFormat.OpenXml.Drawing.Backdrop? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Backdrop?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public Anchor? Anchor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public Vector3DType? Normal
  {
    get;
    set;
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public Vector3DType? UpVector
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
