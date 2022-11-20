namespace DocumentModel.Presentation;

/// <summary>
/// Slide Master.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IColorMap))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICommonSlideData))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IHeaderFooter))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideLayoutIdList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISlideMasterExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITextStyles))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITiming))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ITransition))]
public class SlideMaster: ISlideMaster
{
  /// <summary>
  /// preserve
  /// </summary>
  public bool? Preserve
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
  /// Color Scheme Map.
  /// </summary>
  public DocumentModel.Presentation.IColorMap? ColorMap
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideLayoutIdList.
  /// </summary>
  public ISlideLayoutIdList? SlideLayoutIdList
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
  /// TextStyles.
  /// </summary>
  public ITextStyles? TextStyles
  {
    get;
    set;
  }
  
  /// <summary>
  /// SlideMasterExtensionList.
  /// </summary>
  public ISlideMasterExtensionList? SlideMasterExtensionList
  {
    get;
    set;
  }
  
}
