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
  
  public BackdropImpl(): base() {}
  
  public BackdropImpl(DocumentFormat.OpenXml.Drawing.Backdrop openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Anchor Point.
  /// </summary>
  public Anchor? Anchor
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Normal.
  /// </summary>
  public Vector3DType? Normal
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Up Vector.
  /// </summary>
  public Vector3DType? UpVector
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
