namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface ISlide // : DocumentModel.ITypedOpenXmlPartRootElement
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
  /// Show Slide in Slide Show
  /// </summary>
  public System.Boolean? Show { get ; set; }
  
  /// <summary>
  /// Common slide data for slides.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Slide Transition.
  /// </summary>
  public DocumentModel.Presentation.ITransition? Transition { get ; set; }
  
  /// <summary>
  /// Slide Timing Information for a Slide.
  /// </summary>
  public DocumentModel.Presentation.ITiming? Timing { get ; set; }
  
  /// <summary>
  /// SlideExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SlideExtensionList { get ; set; }
  
}
