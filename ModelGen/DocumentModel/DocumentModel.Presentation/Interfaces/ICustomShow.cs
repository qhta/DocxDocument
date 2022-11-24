namespace DocumentModel.Presentation;

/// <summary>
/// Custom Show.
/// </summary>
public interface ICustomShow // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Custom Show Name
  /// </summary>
  public String? Name { get ; set; }
  
  /// <summary>
  /// Custom Show ID
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// List of Presentation Slides.
  /// </summary>
  public ISlideList? SlideList { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
