namespace DocumentModel.Presentation;

/// <summary>
/// Presentation Slide.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMapOverride))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITiming))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITransition))]
public interface ISlide // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
{
  /// <summary>
  /// Show Master Shapes
  /// </summary>
  public bool? ShowMasterShapes { get ; set; }
  
  /// <summary>
  /// Show Master Placeholder Animations
  /// </summary>
  public bool? ShowMasterPlaceholderAnimations { get ; set; }
  
  /// <summary>
  /// Show Slide in Slide Show
  /// </summary>
  public bool? Show { get ; set; }
  
  /// <summary>
  /// Common slide data for slides.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride { get ; set; }
  
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
