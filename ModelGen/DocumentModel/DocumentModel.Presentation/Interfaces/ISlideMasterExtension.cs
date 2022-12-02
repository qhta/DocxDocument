namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideMasterExtension Class.
/// </summary>
public interface ISlideMasterExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Presentation.ISlideGuideList? SlideGuideList { get ; set; }
  
}
