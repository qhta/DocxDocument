namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout.
/// </summary>
public interface ISlideLayout // : DocumentModel.ITypedOpenXmlPartRootElement
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
  public SlideLayoutValues? Type { get ; set; }
  
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
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Transition.
  /// </summary>
  public ITransition? Transition { get ; set; }
  
  /// <summary>
  /// Timing.
  /// </summary>
  public ITiming? Timing { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// SlideLayoutExtensionList.
  /// </summary>
  public ISlideLayoutExtensionList? SlideLayoutExtensionList { get ; set; }
  
  /// <summary>
  /// Gets the SlideLayoutPart associated with this element.
  /// </summary>
  public SlideLayoutPart? SlideLayoutPart { get ; set; }
  
}
