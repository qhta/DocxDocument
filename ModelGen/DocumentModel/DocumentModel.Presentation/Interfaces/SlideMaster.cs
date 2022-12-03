namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master.
/// </summary>
public interface SlideMaster // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// preserve
  /// </summary>
  public Boolean? Preserve { get ; set; }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public CommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public ColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// SlideLayoutIdList.
  /// </summary>
  public SlideLayoutIdList? SlideLayoutIdList { get ; set; }
  
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
  /// TextStyles.
  /// </summary>
  public TextStyles? TextStyles { get ; set; }
  
  /// <summary>
  /// SlideMasterExtensionList.
  /// </summary>
  public SlideMasterExtensionList? SlideMasterExtensionList { get ; set; }
  
}
