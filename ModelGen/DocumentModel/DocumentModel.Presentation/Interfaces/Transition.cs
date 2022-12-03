namespace DocumentModel.Presentation;

/// <summary>
/// Slide Transition.
/// </summary>
public interface Transition // : DocumentModel.BaseTypes.ModelElement
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
  
  public OrientationTransitionType? BlindsTransition { get ; set; }
  
  public OrientationTransitionType? CheckerTransition { get ; set; }
  
  public Boolean? CircleTransition { get ; set; }
  
  public Boolean? DissolveTransition { get ; set; }
  
  public OrientationTransitionType? CombTransition { get ; set; }
  
  public EightDirectionTransitionType? CoverTransition { get ; set; }
  
  public OptionalBlackTransitionType? CutTransition { get ; set; }
  
  public Boolean? DiamondTransition { get ; set; }
  
  public OptionalBlackTransitionType? FadeTransition { get ; set; }
  
  public Boolean? NewsflashTransition { get ; set; }
  
  public Boolean? PlusTransition { get ; set; }
  
  public EightDirectionTransitionType? PullTransition { get ; set; }
  
  public SideDirectionTransitionType? PushTransition { get ; set; }
  
  public Boolean? RandomTransition { get ; set; }
  
  public OrientationTransitionType? RandomBarTransition { get ; set; }
  
  public SplitTransition? SplitTransition { get ; set; }
  
  public StripsTransition? StripsTransition { get ; set; }
  
  public Boolean? WedgeTransition { get ; set; }
  
  public WheelTransition? WheelTransition { get ; set; }
  
  public SideDirectionTransitionType? WipeTransition { get ; set; }
  
  public ZoomTransition? ZoomTransition { get ; set; }
  
  public Boolean? FlashTransition { get ; set; }
  
  public SideDirectionTransitionType? VortexTransition { get ; set; }
  
  public LeftRightDirectionTransitionType? SwitchTransition { get ; set; }
  
  public LeftRightDirectionTransitionType? FlipTransition { get ; set; }
  
  public RippleTransition? RippleTransition { get ; set; }
  
  public GlitterTransition? GlitterTransition { get ; set; }
  
  public Boolean? HoneycombTransition { get ; set; }
  
  public PrismTransition? PrismTransition { get ; set; }
  
  public OrientationTransitionType? DoorsTransition { get ; set; }
  
  public OrientationTransitionType? WindowTransition { get ; set; }
  
  public ShredTransition? ShredTransition { get ; set; }
  
  public LeftRightDirectionTransitionType? FerrisTransition { get ; set; }
  
  public FlythroughTransition? FlythroughTransition { get ; set; }
  
  public WarpTransition? WarpTransition { get ; set; }
  
  public LeftRightDirectionTransitionType? GalleryTransition { get ; set; }
  
  public LeftRightDirectionTransitionType? ConveyorTransition { get ; set; }
  
  public SideDirectionTransitionType? PanTransition { get ; set; }
  
  public RevealTransition? RevealTransition { get ; set; }
  
  public WheelReverseTransition? WheelReverseTransition { get ; set; }
  
  public PresetTransition? PresetTransition { get ; set; }
  
  public SoundAction? SoundAction { get ; set; }
  
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
