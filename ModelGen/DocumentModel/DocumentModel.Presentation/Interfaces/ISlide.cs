namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
public interface ISlide // : DocumentModel.ITypedOpenXmlPartRootElement
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
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Slide Transition.
  /// </summary>
  public ITransition? Transition { get ; set; }
  
  /// <summary>
  /// Slide Timing Information for a Slide.
  /// </summary>
  public ITiming? Timing { get ; set; }
  
  /// <summary>
  /// SlideExtensionList.
  /// </summary>
  public ISlideExtensionList? SlideExtensionList { get ; set; }
  
}
