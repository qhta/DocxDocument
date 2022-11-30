namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master.
/// </summary>
public interface ISlideMaster // : DocumentModel.ITypedOpenXmlPartRootElement
{
  /// <summary>
  /// preserve
  /// </summary>
  public System.Boolean? Preserve { get ; set; }
  
  /// <summary>
  /// CommonSlideData.
  /// </summary>
  public DocumentModel.Presentation.ICommonSlideData? CommonSlideData { get ; set; }
  
  /// <summary>
  /// Color Scheme Map.
  /// </summary>
  public DocumentModel.Presentation.IColorMap? ColorMap { get ; set; }
  
  /// <summary>
  /// SlideLayoutIdList.
  /// </summary>
  public DocumentModel.Presentation.ISlideLayoutIdList? SlideLayoutIdList { get ; set; }
  
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
  /// TextStyles.
  /// </summary>
  public DocumentModel.Presentation.ITextStyles? TextStyles { get ; set; }
  
  /// <summary>
  /// SlideMasterExtensionList.
  /// </summary>
  public DocumentModel.Presentation.ISlideMasterExtensionList? SlideMasterExtensionList { get ; set; }
  
}
