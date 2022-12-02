namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtension Class.
/// </summary>
public interface ISlideMasterExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public ISlideGuideList? SlideGuideList { get ; set; }
  
}
