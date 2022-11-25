namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout.
/// </summary>
public interface ISlideLayout // : DocumentModel.ITypedOpenXmlPartRootElement
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
  /// matchingName
  /// </summary>
  public System.String? MatchingName { get ; set; }
  
  /// <summary>
  /// type
  /// </summary>
  public DocumentModel.Presentation.SlideLayoutKind? Type { get ; set; }
  
  /// <summary>
  /// preserve
  /// </summary>
  public System.Boolean? Preserve { get ; set; }
  
  /// <summary>
  /// userDrawn
  /// </summary>
  public System.Boolean? UserDrawn { get ; set; }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// Transition.
  /// </summary>
  public DocumentModel.Presentation.ITransition? Transition { get ; set; }
  
  /// <summary>
  /// Timing.
  /// </summary>
  public DocumentModel.Presentation.ITiming? Timing { get ; set; }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Presentation.IHeaderFooter? HeaderFooter { get ; set; }
  
  /// <summary>
  /// SlideLayoutExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SlideLayoutExtensionList { get ; set; }
  
}
