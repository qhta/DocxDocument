namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface Slide // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Show Master Shapes
  /// </summary>
  public Boolean? ShowMasterShapes { get ; set; }
  
  /// <summary>
  /// Show Master Placeholder Animations
  /// </summary>
  public Boolean? ShowMasterPlaceholderAnimations { get ; set; }
  
  /// <summary>
  /// Show Slide in Slide Show
  /// </summary>
  public Boolean? Show { get ; set; }
  
  /// <summary>
  /// Common slide data for slides.
  /// </summary>
  public CommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public ColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Slide Transition.
  /// </summary>
  public Transition? Transition { get ; set; }
  
  /// <summary>
  /// Slide Timing Information for a Slide.
  /// </summary>
  public Timing? Timing { get ; set; }
  
  /// <summary>
  /// SlideExtensionList.
  /// </summary>
  public SlideExtensionList? SlideExtensionList { get ; set; }
  
}
