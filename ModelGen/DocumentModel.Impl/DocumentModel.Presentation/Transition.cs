namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IStripsTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICoverTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPullTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICircleTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IDissolveTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IDiamondTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.INewsflashTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPlusTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRandomTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IWedgeTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IFlashTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IHoneycombTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IExtensionListWithModification))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IZoomTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IWarpTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICutTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IFadeTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IBlindsTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICheckerTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ICombTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IRandomBarTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IDoorsTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IWindowTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IPushTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IWipeTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IVortexTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IPanTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISplitTransition))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISoundAction))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IWheelTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IWheelReverseTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IFlythroughTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IGlitterTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.ISwitchTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IFlipTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IFerrisTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IGalleryTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IConveyorTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IPrismTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IRevealTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IRippleTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2010.PowerPoint.IShredTransition))]
[ChildElementInfo(typeof(DocumentModel.Office2013.PowerPoint.IPresetTransition))]
public class Transition: ITransition
{
  /// <summary>
  /// spd
  /// </summary>
  public TransitionSpeedValues? Speed
  {
    get;
    set;
  }
  
  /// <summary>
  /// dur, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Duration
  {
    get;
    set;
  }
  
  /// <summary>
  /// Specifies whether a mouse click will advance the slide.
  /// </summary>
  public bool? AdvanceOnClick
  {
    get;
    set;
  }
  
  /// <summary>
  /// advTm
  /// </summary>
  public string? AdvanceAfterTime
  {
    get;
    set;
  }
  
}
