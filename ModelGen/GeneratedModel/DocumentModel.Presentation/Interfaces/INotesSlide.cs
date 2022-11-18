namespace DocumentModel.Presentation;

/// <summary>
/// Notes Slide.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMapOverride))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
public interface INotesSlide // : DocumentFormat.OpenXml.TypedOpenXmlPartRootElement
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
  /// Common slide data for notes slides.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public DocumentModel.Presentation.IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
