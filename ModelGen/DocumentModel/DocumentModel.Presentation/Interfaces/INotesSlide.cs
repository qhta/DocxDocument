namespace DocumentModel.Presentation;

/// <summary>
/// Notes Slide.
/// </summary>
public interface INotesSlide // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// Show Master Shapes
  /// </summary>
  public System.Boolean? ShowMasterShapes { get ; set; }
  
  /// <summary>
  /// Show Master Placeholder Animations
  /// </summary>
  public System.Boolean? ShowMasterPlaceholderAnimations { get ; set; }
  
  /// <summary>
  /// Common slide data for notes slides.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
