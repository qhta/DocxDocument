namespace DocumentModel.Presentation;

/// <summary>
/// Slide Layout.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMapOverride))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideLayoutExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITiming))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITransition))]
public class SlideLayout: ISlideLayout
{
  /// <summary>
  /// Show Master Shapes
  /// </summary>
  public bool? ShowMasterShapes
  {
    get;
    set;
  }
  
  /// <summary>
  /// Show Master Placeholder Animations
  /// </summary>
  public bool? ShowMasterPlaceholderAnimations
  {
    get;
    set;
  }
  
  /// <summary>
  /// matchingName
  /// </summary>
  public string? MatchingName
  {
    get;
    set;
  }
  
  /// <summary>
  /// type
  /// </summary>
  public SlideLayoutValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// preserve
  /// </summary>
  public bool? Preserve
  {
    get;
    set;
  }
  
  /// <summary>
  /// userDrawn
  /// </summary>
  public bool? UserDrawn
  {
    get;
    set;
  }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData
  {
    get;
    set;
  }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transition.
  /// </summary>
  public ITransition? Transition
  {
    get;
    set;
  }
  
  /// <summary>
  /// Timing.
  /// </summary>
  public ITiming? Timing
  {
    get;
    set;
  }
  
  /// <summary>
  /// HeaderFooter.
  /// </summary>
  public DocumentModel.Presentation.IHeaderFooter? HeaderFooter
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideLayoutExtensionList.
  /// </summary>
  public ISlideLayoutExtensionList? SlideLayoutExtensionList
  {
    get;
    set;
  }
  
}
