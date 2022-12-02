namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
public interface ITransition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spd
  /// </summary>
  public DocumentModel.Presentation.TransitionSpeedKind? Speed { get ; set; }
  
  /// <summary>
  /// dur, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Duration { get ; set; }
  
  /// <summary>
  /// Specifies whether a mouse click will advance the slide.
  /// </summary>
  public System.Boolean? AdvanceOnClick { get ; set; }
  
  /// <summary>
  /// advTm
  /// </summary>
  public System.String? AdvanceAfterTime { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? BlindsTransition { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? CheckerTransition { get ; set; }
  
  public System.Boolean? CircleTransition { get ; set; }
  
  public System.Boolean? DissolveTransition { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? CombTransition { get ; set; }
  
  public DocumentModel.Presentation.IEightDirectionTransitionType? CoverTransition { get ; set; }
  
  public DocumentModel.Presentation.IOptionalBlackTransitionType? CutTransition { get ; set; }
  
  public System.Boolean? DiamondTransition { get ; set; }
  
  public DocumentModel.Presentation.IOptionalBlackTransitionType? FadeTransition { get ; set; }
  
  public System.Boolean? NewsflashTransition { get ; set; }
  
  public System.Boolean? PlusTransition { get ; set; }
  
  public DocumentModel.Presentation.IEightDirectionTransitionType? PullTransition { get ; set; }
  
  public DocumentModel.Presentation.ISideDirectionTransitionType? PushTransition { get ; set; }
  
  public System.Boolean? RandomTransition { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? RandomBarTransition { get ; set; }
  
  public DocumentModel.Presentation.ISplitTransition? SplitTransition { get ; set; }
  
  public DocumentModel.Presentation.IStripsTransition? StripsTransition { get ; set; }
  
  public System.Boolean? WedgeTransition { get ; set; }
  
  public DocumentModel.Presentation.IWheelTransition? WheelTransition { get ; set; }
  
  public DocumentModel.Presentation.ISideDirectionTransitionType? WipeTransition { get ; set; }
  
  public DocumentModel.Presentation.IZoomTransition? ZoomTransition { get ; set; }
  
  public System.Boolean? FlashTransition { get ; set; }
  
  public DocumentModel.Presentation.ISideDirectionTransitionType? VortexTransition { get ; set; }
  
  public DocumentModel.Presentation.ILeftRightDirectionTransitionType? SwitchTransition { get ; set; }
  
  public DocumentModel.Presentation.ILeftRightDirectionTransitionType? FlipTransition { get ; set; }
  
  public DocumentModel.Presentation.IRippleTransition? RippleTransition { get ; set; }
  
  public DocumentModel.Presentation.IGlitterTransition? GlitterTransition { get ; set; }
  
  public System.Boolean? HoneycombTransition { get ; set; }
  
  public DocumentModel.Presentation.IPrismTransition? PrismTransition { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? DoorsTransition { get ; set; }
  
  public DocumentModel.Presentation.IOrientationTransitionType? WindowTransition { get ; set; }
  
  public DocumentModel.Presentation.IShredTransition? ShredTransition { get ; set; }
  
  public DocumentModel.Presentation.ILeftRightDirectionTransitionType? FerrisTransition { get ; set; }
  
  public DocumentModel.Presentation.IFlythroughTransition? FlythroughTransition { get ; set; }
  
  public DocumentModel.Presentation.IWarpTransition? WarpTransition { get ; set; }
  
  public DocumentModel.Presentation.ILeftRightDirectionTransitionType? GalleryTransition { get ; set; }
  
  public DocumentModel.Presentation.ILeftRightDirectionTransitionType? ConveyorTransition { get ; set; }
  
  public DocumentModel.Presentation.ISideDirectionTransitionType? PanTransition { get ; set; }
  
  public DocumentModel.Presentation.IRevealTransition? RevealTransition { get ; set; }
  
  public DocumentModel.Presentation.IWheelReverseTransition? WheelReverseTransition { get ; set; }
  
  public DocumentModel.Presentation.IPresetTransition? PresetTransition { get ; set; }
  
  public DocumentModel.Presentation.ISoundAction? SoundAction { get ; set; }
  
  public DocumentModel.Presentation.IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
