namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SlideLayoutExtension Class.
/// </summary>
public interface ISlideLayoutExtension // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// URI
  /// </summary>
  public System.String? Uri { get ; set; }
  
  public DocumentModel.Presentation.ISlideGuideList? SlideGuideList { get ; set; }
  
}
