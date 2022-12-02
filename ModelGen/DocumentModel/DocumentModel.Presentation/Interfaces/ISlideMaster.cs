namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master.
/// </summary>
public interface ISlideMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// preserve
  /// </summary>
  public Boolean? Preserve { get ; set; }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// SlideLayoutIdList.
  /// </summary>
  public ISlideLayoutIdList? SlideLayoutIdList { get ; set; }
  
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
  /// TextStyles.
  /// </summary>
  public ITextStyles? TextStyles { get ; set; }
  
  /// <summary>
  /// SlideMasterExtensionList.
  /// </summary>
  public ISlideMasterExtensionList? SlideMasterExtensionList { get ; set; }
  
}
