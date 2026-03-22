namespace DocumentModel.Drawings;
/// <summary>
///   Represents a directed acyclic graph (DAG) structure for organizing and applying visual effects in DrawingML.
/// </summary>
/// <remarks>
///   <para>
///   The <b>EffectDag</b> models a complex effect composition system where multiple effects and effect containers
///   are connected in a directed acyclic graph. This allows for advanced layering, dependency management, and non-linear
///   effect application to shapes, images, and other graphical elements.
///   </para>
///   <para>
///   Unlike simple sequential effect lists, an effect DAG enables effects to be reused, shared, and composed in flexible
///   topologies, supporting scenarios such as:
///   <list type="bullet">
///     <item><description>Layering effects with dependencies</description></item>
///     <item><description>Branching effect chains</description></item>
///     <item><description>Combining multiple effect containers and primitives</description></item>
///     <item><description>Efficient effect reuse and inheritance</description></item>
///   </list>
///   </para>
///   <para>
///   The DAG structure is especially useful for rendering engines that optimize effect processing and for documents
///   requiring sophisticated visual treatments.
///   </para>
/// </remarks>
[OpenXmlType(typeof(DXD.EffectDag))]
public partial class EffectDag : ModelElement<DXD.EffectDag>
{
 /// <summary>
 ///   Gets or sets a nested effect container node within the DAG.
 /// </summary>
 public EffectContainer? EffectContainer { get => _EffectContainer; set => UpdateField(ref _EffectContainer, value, nameof(EffectContainer)); }
 private EffectContainer? _EffectContainer;
 /// <summary>
 ///   Gets or sets a reference to a single effect node within the DAG.
 /// </summary>
 public Effect? Effect { get => _Effect; set => UpdateField(ref _Effect, value, nameof(Effect)); }
 private Effect? _Effect;
 /// <summary>
 ///   Gets or sets an effect node that applies a bi-level alpha threshold.
 /// </summary>
 public AlphaBiLevel? AlphaBiLevel { get => _AlphaBiLevel; set => UpdateField(ref _AlphaBiLevel, value, nameof(AlphaBiLevel)); }
 private AlphaBiLevel? _AlphaBiLevel;
 /// <summary>
 ///   Gets or sets a flag indicating whether alpha ceiling (maximum alpha) is applied.
 /// </summary>
 public bool? AlphaCeiling { get => _AlphaCeiling; set => UpdateField(ref _AlphaCeiling, value, nameof(AlphaCeiling)); }
 private bool? _AlphaCeiling;
 /// <summary>
 ///   Gets or sets a flag indicating whether alpha floor (minimum alpha) is applied.
 /// </summary>
 public bool? AlphaFloor { get => _AlphaFloor; set => UpdateField(ref _AlphaFloor, value, nameof(AlphaFloor)); }
 private bool? _AlphaFloor;
 /// <summary>
 ///   Gets or sets an effect node that inverts the alpha channel.
 /// </summary>
 public AlphaInverse? AlphaInverse { get => _AlphaInverse; set => UpdateField(ref _AlphaInverse, value, nameof(AlphaInverse)); }
 private AlphaInverse? _AlphaInverse;
 /// <summary>
 ///   Gets or sets an effect node that modulates alpha based on another effect.
 /// </summary>
 public AlphaModulationEffect? AlphaModulationEffect { get => _AlphaModulationEffect; set => UpdateField(ref _AlphaModulationEffect, value, nameof(AlphaModulationEffect)); }
 private AlphaModulationEffect? _AlphaModulationEffect;
 /// <summary>
 ///   Gets or sets an effect node that applies a fixed alpha modulation.
 /// </summary>
 public AlphaModulationFixed? AlphaModulationFixed { get => _AlphaModulationFixed; set => UpdateField(ref _AlphaModulationFixed, value, nameof(AlphaModulationFixed)); }
 private AlphaModulationFixed? _AlphaModulationFixed;
 /// <summary>
 ///   Gets or sets an effect node that expands the alpha channel outward.
 /// </summary>
 public AlphaOutset? AlphaOutset { get => _AlphaOutset; set => UpdateField(ref _AlphaOutset, value, nameof(AlphaOutset)); }
 private AlphaOutset? _AlphaOutset;
 /// <summary>
 ///   Gets or sets an effect node that replaces the alpha channel.
 /// </summary>
 public AlphaReplace? AlphaReplace { get => _AlphaReplace; set => UpdateField(ref _AlphaReplace, value, nameof(AlphaReplace)); }
 private AlphaReplace? _AlphaReplace;
 /// <summary>
 ///   Gets or sets an effect node that applies a bi-level threshold to color channels.
 /// </summary>
 public BiLevel? BiLevel { get => _BiLevel; set => UpdateField(ref _BiLevel, value, nameof(BiLevel)); }
 private BiLevel? _BiLevel;
 /// <summary>
 ///   Gets or sets a blend effect node that combines multiple visual elements.
 /// </summary>
 public Blend? Blend { get => _Blend; set => UpdateField(ref _Blend, value, nameof(Blend)); }
 private Blend? _Blend;
 /// <summary>
 ///   Gets or sets a blur effect node that softens the appearance of the object.
 /// </summary>
 public Blur? Blur { get => _Blur; set => UpdateField(ref _Blur, value, nameof(Blur)); }
 private Blur? _Blur;
 /// <summary>
 ///   Gets or sets an effect node that changes colors based on specified rules.
 /// </summary>
 public ColorChange? ColorChange { get => _ColorChange; set => UpdateField(ref _ColorChange, value, nameof(ColorChange)); }
 private ColorChange? _ColorChange;
 /// <summary>
 ///   Gets or sets an effect node that replaces one color with another.
 /// </summary>
 public ColorReplacement? ColorReplacement { get => _ColorReplacement; set => UpdateField(ref _ColorReplacement, value, nameof(ColorReplacement)); }
 private ColorReplacement? _ColorReplacement;
 /// <summary>
 ///   Gets or sets a duotone effect node that maps colors to two tones.
 /// </summary>
 public Duotone? Duotone { get => _Duotone; set => UpdateField(ref _Duotone, value, nameof(Duotone)); }
 private Duotone? _Duotone;
 /// <summary>
 ///   Gets or sets a fill effect node that applies a solid or gradient fill.
 /// </summary>
 public Fill? Fill { get => _Fill; set => UpdateField(ref _Fill, value, nameof(Fill)); }
 private Fill? _Fill;
 /// <summary>
 ///   Gets or sets a fill overlay effect node that layers a fill over the object.
 /// </summary>
 public FillOverlay? FillOverlay { get => _FillOverlay; set => UpdateField(ref _FillOverlay, value, nameof(FillOverlay)); }
 private FillOverlay? _FillOverlay;
 /// <summary>
 ///   Gets or sets a glow effect node that adds a colored halo around the object.
 /// </summary>
 public Glow? Glow { get => _Glow; set => UpdateField(ref _Glow, value, nameof(Glow)); }
 private Glow? _Glow;
 /// <summary>
 ///   Gets or sets a flag indicating whether the object is rendered in grayscale.
 /// </summary>
 public Boolean Grayscale { get => _Grayscale; set => UpdateField(ref _Grayscale, value, nameof(Grayscale)); }
 private Boolean _Grayscale;
 /// <summary>
 ///   Gets or sets an HSL (Hue, Saturation, Luminance) color effect node.
 /// </summary>
 public Hsl? Hsl { get => _Hsl; set => UpdateField(ref _Hsl, value, nameof(Hsl)); }
 private Hsl? _Hsl;
 /// <summary>
 ///   Gets or sets an inner shadow effect node applied inside the object's edges.
 /// </summary>
 public InnerShadow? InnerShadow { get => _InnerShadow; set => UpdateField(ref _InnerShadow, value, nameof(InnerShadow)); }
 private InnerShadow? _InnerShadow;
 /// <summary>
 ///   Gets or sets a luminance effect node that adjusts brightness and contrast.
 /// </summary>
 public LuminanceEffect? LuminanceEffect { get => _LuminanceEffect; set => UpdateField(ref _LuminanceEffect, value, nameof(LuminanceEffect)); }
 private LuminanceEffect? _LuminanceEffect;
 /// <summary>
 ///   Gets or sets an outer shadow effect node applied outside the object's edges.
 /// </summary>
 public OuterShadow? OuterShadow { get => _OuterShadow; set => UpdateField(ref _OuterShadow, value, nameof(OuterShadow)); }
 private OuterShadow? _OuterShadow;
 /// <summary>
 ///   Gets or sets a preset shadow effect node using predefined shadow styles.
 /// </summary>
 public PresetShadow? PresetShadow { get => _PresetShadow; set => UpdateField(ref _PresetShadow, value, nameof(PresetShadow)); }
 private PresetShadow? _PresetShadow;
 /// <summary>
 ///   Gets or sets a reflection effect node that creates a mirrored image below the object.
 /// </summary>
 public Reflection? Reflection { get => _Reflection; set => UpdateField(ref _Reflection, value, nameof(Reflection)); }
 private Reflection? _Reflection;
 /// <summary>
 ///   Gets or sets a relative offset effect node that shifts the object or its effect.
 /// </summary>
 public RelativeOffset? RelativeOffset { get => _RelativeOffset; set => UpdateField(ref _RelativeOffset, value, nameof(RelativeOffset)); }
 private RelativeOffset? _RelativeOffset;
 /// <summary>
 ///   Gets or sets a soft edge effect node that feathers the object's edges.
 /// </summary>
 public SoftEdge? SoftEdge { get => _SoftEdge; set => UpdateField(ref _SoftEdge, value, nameof(SoftEdge)); }
 private SoftEdge? _SoftEdge;
 /// <summary>
 ///   Gets or sets a tint effect node that applies a color tint to the object.
 /// </summary>
 public TintEffect? TintEffect { get => _TintEffect; set => UpdateField(ref _TintEffect, value, nameof(TintEffect)); }
 private TintEffect? _TintEffect;
 /// <summary>
 ///   Gets or sets a transform effect node that applies geometric transformations.
 /// </summary>
 public TransformEffect? TransformEffect { get => _TransformEffect; set => UpdateField(ref _TransformEffect, value, nameof(TransformEffect)); }
 private TransformEffect? _TransformEffect;
}