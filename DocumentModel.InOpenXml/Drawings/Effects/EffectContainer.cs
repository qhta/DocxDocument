namespace DocumentModel.Drawings;
/// <summary>
///   Represents a container for visual effects applied to DrawingML objects.
/// </summary>
public partial class EffectContainer : ModelElement<DXD.EffectContainer>
{
    /// <summary>
    ///   Gets or sets a nested child effect container for hierarchical effect composition.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public EffectContainer? ChildEffectContainer { get => _ChildEffectContainer; set => UpdateField(ref _ChildEffectContainer, value, nameof(ChildEffectContainer)); }

    private EffectContainer? _ChildEffectContainer;
    /// <summary>
    ///   Gets or sets a reference to a single effect applied within this container.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Effect? Effect { get => _Effect; set => UpdateField(ref _Effect, value, nameof(Effect)); }

    private Effect? _Effect;
    /// <summary>
    ///   Gets or sets an effect that applies a bi-level alpha threshold.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaBiLevel? AlphaBiLevel { get => _AlphaBiLevel; set => UpdateField(ref _AlphaBiLevel, value, nameof(AlphaBiLevel)); }

    private AlphaBiLevel? _AlphaBiLevel;
    /// <summary>
    ///   Gets or sets a flag indicating whether alpha ceiling (maximum alpha) is applied.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public bool? AlphaCeiling { get => _AlphaCeiling; set => UpdateField(ref _AlphaCeiling, value, nameof(AlphaCeiling)); }

    private bool? _AlphaCeiling;
    /// <summary>
    ///   Gets or sets a flag indicating whether alpha floor (minimum alpha) is applied.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public bool? AlphaFloor { get => _AlphaFloor; set => UpdateField(ref _AlphaFloor, value, nameof(AlphaFloor)); }

    private bool? _AlphaFloor;
    /// <summary>
    ///   Gets or sets an effect that inverts the alpha channel.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaInverse? AlphaInverse { get => _AlphaInverse; set => UpdateField(ref _AlphaInverse, value, nameof(AlphaInverse)); }

    private AlphaInverse? _AlphaInverse;
    /// <summary>
    ///   Gets or sets an effect that modulates alpha based on another effect.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaModulationEffect? AlphaModulationEffect { get => _AlphaModulationEffect; set => UpdateField(ref _AlphaModulationEffect, value, nameof(AlphaModulationEffect)); }

    private AlphaModulationEffect? _AlphaModulationEffect;
    /// <summary>
    ///   Gets or sets an effect that applies a fixed alpha modulation.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaModulationFixed? AlphaModulationFixed { get => _AlphaModulationFixed; set => UpdateField(ref _AlphaModulationFixed, value, nameof(AlphaModulationFixed)); }

    private AlphaModulationFixed? _AlphaModulationFixed;
    /// <summary>
    ///   Gets or sets an effect that expands the alpha channel outward.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaOutset? AlphaOutset { get => _AlphaOutset; set => UpdateField(ref _AlphaOutset, value, nameof(AlphaOutset)); }

    private AlphaOutset? _AlphaOutset;
    /// <summary>
    ///   Gets or sets an effect that replaces the alpha channel.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public AlphaReplace? AlphaReplace { get => _AlphaReplace; set => UpdateField(ref _AlphaReplace, value, nameof(AlphaReplace)); }

    private AlphaReplace? _AlphaReplace;
    /// <summary>
    ///   Gets or sets an effect that applies a bi-level threshold to color channels.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public BiLevel? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }

    private BiLevel? _BiLevel;
    /// <summary>
    ///   Gets or sets a blend effect that combines multiple visual elements.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Blend? Blend { get => _Blend; set => UpdateField(ref _Blend, value, nameof(Blend)); }

    private Blend? _Blend;
    /// <summary>
    ///   Gets or sets a blur effect that softens the appearance of the object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Blur? Blur { get => _Blur; set => UpdateField(ref _Blur, value, nameof(Blur)); }

    private Blur? _Blur;
    /// <summary>
    ///   Gets or sets an effect that changes colors based on specified rules.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public ColorChange? ColorChange { get => _ColorChange; set => UpdateField(ref _ColorChange, value, nameof(ColorChange)); }

    private ColorChange? _ColorChange;
    /// <summary>
    ///   Gets or sets an effect that replaces one color with another.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public ColorReplacement? ColorReplacement { get => _ColorReplacement; set => UpdateField(ref _ColorReplacement, value, nameof(ColorReplacement)); }

    private ColorReplacement? _ColorReplacement;
    /// <summary>
    ///   Gets or sets a duotone effect that maps colors to two tones.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Duotone? Duotone { get => _Duotone; set => UpdateField(ref _Duotone, value, nameof(Duotone)); }

    private Duotone? _Duotone;
    /// <summary>
    ///   Gets or sets a fill effect that applies a solid or gradient fill.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }

    private Fill? _Fill;
    /// <summary>
    ///   Gets or sets a fill overlay effect that layers a fill over the object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public FillOverlay? FillOverlay { get => _FillOverlay; set => UpdateField(ref _FillOverlay, value, nameof(FillOverlay)); }

    private FillOverlay? _FillOverlay;
    /// <summary>
    ///   Gets or sets a glow effect that adds a colored halo around the object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Glow? Glow { get => _Glow; set => UpdateField(ref _Glow, value, nameof(Glow)); }

    private Glow? _Glow;
    /// <summary>
    ///   Gets or sets a flag indicating whether the object is rendered in grayscale.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Boolean Grayscale { get => _Grayscale; set => UpdateField(ref _Grayscale, value, nameof(Grayscale)); }

    private Boolean _Grayscale;
    /// <summary>
    ///   Gets or sets an HSL (Hue, Saturation, Luminance) color effect.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Hsl? Hsl { get => _Hsl; set => UpdateField(ref _Hsl, value, nameof(Hsl)); }

    private Hsl? _Hsl;
    /// <summary>
    ///   Gets or sets an inner shadow effect applied inside the object's edges.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public InnerShadow? InnerShadow { get => _InnerShadow; set => UpdateField(ref _InnerShadow, value, nameof(InnerShadow)); }

    private InnerShadow? _InnerShadow;
    /// <summary>
    ///   Gets or sets a luminance effect that adjusts brightness and contrast.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public LuminanceEffect? LuminanceEffect { get => _LuminanceEffect; set => UpdateField(ref _LuminanceEffect, value, nameof(LuminanceEffect)); }

    private LuminanceEffect? _LuminanceEffect;
    /// <summary>
    ///   Gets or sets an outer shadow effect applied outside the object's edges.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public OuterShadow? OuterShadow { get => _OuterShadow; set => UpdateField(ref _OuterShadow, value, nameof(OuterShadow)); }

    private OuterShadow? _OuterShadow;
    /// <summary>
    ///   Gets or sets a preset shadow effect using predefined shadow styles.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public PresetShadow? PresetShadow { get => _PresetShadow; set => UpdateField(ref _PresetShadow, value, nameof(PresetShadow)); }

    private PresetShadow? _PresetShadow;
    /// <summary>
    ///   Gets or sets a reflection effect that creates a mirrored image below the object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public Reflection? Reflection { get => _Reflection; set => UpdateField(ref _Reflection, value, nameof(Reflection)); }

    private Reflection? _Reflection;
    /// <summary>
    ///   Gets or sets a relative offset effect that shifts the object or its effect.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public RelativeOffset? RelativeOffset { get => _RelativeOffset; set => UpdateField(ref _RelativeOffset, value, nameof(RelativeOffset)); }

    private RelativeOffset? _RelativeOffset;
    /// <summary>
    ///   Gets or sets a soft edge effect that feathers the object's edges.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public SoftEdge? SoftEdge { get => _SoftEdge; set => UpdateField(ref _SoftEdge, value, nameof(SoftEdge)); }

    private SoftEdge? _SoftEdge;
    /// <summary>
    ///   Gets or sets a tint effect that applies a color tint to the object.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public TintEffect? TintEffect { get => _TintEffect; set => UpdateField(ref _TintEffect, value, nameof(TintEffect)); }

    private TintEffect? _TintEffect;
    /// <summary>
    ///   Gets or sets a transform effect that applies geometric transformations.
    /// </summary>
    [OpenXmlElement(typeof(DXD.EffectContainer))]
    public TransformEffect? TransformEffect { get => _TransformEffect; set => UpdateField(ref _TransformEffect, value, nameof(TransformEffect)); }

    private TransformEffect? _TransformEffect;
}