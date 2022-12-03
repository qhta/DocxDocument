namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout.
/// </summary>
public interface SlideLayout // : DocumentModel.BaseTypes.ModelElement
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
  /// matchingName
  /// </summary>
  public String? MatchingName { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public SlideLayoutKind? Type { get ; set; }
  
  /// <summary>
  /// preserve
  /// </summary>
  public Boolean? Preserve { get ; set; }
  
  /// <summary>
  /// userDrawn
  /// </summary>
  public Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public CommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public ColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Transition.
  /// </summary>
  public Transition? Transition { get ; set; }
  
  /// <summary>
  /// Timing.
  /// </summary>
  public Timing? Timing { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public HeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// SlideLayoutExtensionList.
  /// </summary>
  public SlideLayoutExtensionList? SlideLayoutExtensionList { get ; set; }
  
}
