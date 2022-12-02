namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
public interface ITransition // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// spd
  /// </summary>
  public TransitionSpeedKind? Speed { get ; set; }
  
  /// <summary>
  /// dur, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Duration { get ; set; }
  
  /// <summary>
  /// Specifies whether a mouse click will advance the slide.
  /// </summary>
  public Boolean? AdvanceOnClick { get ; set; }
  
  /// <summary>
  /// advTm
  /// </summary>
  public String? AdvanceAfterTime { get ; set; }
  
  public IOrientationTransitionType? BlindsTransition { get ; set; }
  
  public IOrientationTransitionType? CheckerTransition { get ; set; }
  
  public Boolean? CircleTransition { get ; set; }
  
  public Boolean? DissolveTransition { get ; set; }
  
  public IOrientationTransitionType? CombTransition { get ; set; }
  
  public IEightDirectionTransitionType? CoverTransition { get ; set; }
  
  public IOptionalBlackTransitionType? CutTransition { get ; set; }
  
  public Boolean? DiamondTransition { get ; set; }
  
  public IOptionalBlackTransitionType? FadeTransition { get ; set; }
  
  public Boolean? NewsflashTransition { get ; set; }
  
  public Boolean? PlusTransition { get ; set; }
  
  public IEightDirectionTransitionType? PullTransition { get ; set; }
  
  public ISideDirectionTransitionType? PushTransition { get ; set; }
  
  public Boolean? RandomTransition { get ; set; }
  
  public IOrientationTransitionType? RandomBarTransition { get ; set; }
  
  public ISplitTransition? SplitTransition { get ; set; }
  
  public IStripsTransition? StripsTransition { get ; set; }
  
  public Boolean? WedgeTransition { get ; set; }
  
  public IWheelTransition? WheelTransition { get ; set; }
  
  public ISideDirectionTransitionType? WipeTransition { get ; set; }
  
  public IZoomTransition? ZoomTransition { get ; set; }
  
  public Boolean? FlashTransition { get ; set; }
  
  public ISideDirectionTransitionType? VortexTransition { get ; set; }
  
  public ILeftRightDirectionTransitionType? SwitchTransition { get ; set; }
  
  public ILeftRightDirectionTransitionType? FlipTransition { get ; set; }
  
  public IRippleTransition? RippleTransition { get ; set; }
  
  public IGlitterTransition? GlitterTransition { get ; set; }
  
  public Boolean? HoneycombTransition { get ; set; }
  
  public IPrismTransition? PrismTransition { get ; set; }
  
  public IOrientationTransitionType? DoorsTransition { get ; set; }
  
  public IOrientationTransitionType? WindowTransition { get ; set; }
  
  public IShredTransition? ShredTransition { get ; set; }
  
  public ILeftRightDirectionTransitionType? FerrisTransition { get ; set; }
  
  public IFlythroughTransition? FlythroughTransition { get ; set; }
  
  public IWarpTransition? WarpTransition { get ; set; }
  
  public ILeftRightDirectionTransitionType? GalleryTransition { get ; set; }
  
  public ILeftRightDirectionTransitionType? ConveyorTransition { get ; set; }
  
  public ISideDirectionTransitionType? PanTransition { get ; set; }
  
  public IRevealTransition? RevealTransition { get ; set; }
  
  public IWheelReverseTransition? WheelReverseTransition { get ; set; }
  
  public IPresetTransition? PresetTransition { get ; set; }
  
  public ISoundAction? SoundAction { get ; set; }
  
  public IExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
