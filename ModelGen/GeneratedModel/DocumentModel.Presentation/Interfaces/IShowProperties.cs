namespace DocumentModel.Presentation;

/// <summary>
/// Defines the ShowProperties Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IPenColor))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICustomShowReference))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPresenterSlideMode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideAll))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideRange))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBrowseSlideMode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IKioskSlideMode))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IShowPropertiesExtensionList))]
public interface IShowProperties // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// Loop Slide Show
  /// </summary>
  public bool? Loop { get ; set; }
  
  /// <summary>
  /// Show Narration in Slide Show
  /// </summary>
  public bool? ShowNarration { get ; set; }
  
  /// <summary>
  /// Show Animation in Slide Show
  /// </summary>
  public bool? ShowAnimation { get ; set; }
  
  /// <summary>
  /// Use Timings in Slide Show
  /// </summary>
  public bool? UseTimings { get ; set; }
  
}
