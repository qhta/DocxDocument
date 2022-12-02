namespace DocumentModel.Presentation;

/// <summary>
/// Notes Slide.
/// </summary>
public interface INotesSlide // : DocumentModel.ITypedOpenXmlPartRootElement
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
  /// Common slide data for notes slides.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map Override.
  /// </summary>
  public IColorMapOverride? ColorMapOverride { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
