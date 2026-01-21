namespace DocumentModel.Drawings;
/// <summary>
///   Represents a directed acyclic graph (DAG) structure for organizing and applying visual effects in DrawingML.
/// </summary>
/// <remarks>
///   <para>
///   The <b>EffectDag</b> interface models a complex effect composition system where multiple effects and effect containers
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
public partial class EffectDag : ModelElement<DXD.EffectDag>
{
  /// <summary>
  ///   Gets or sets a nested effect container node within the DAG.
  /// </summary>
  public EffectContainer? EffectContainer { get; set; }
  /// <summary>
  ///   Gets or sets a reference to a single effect node within the DAG.
  /// </summary>
  public Effect? Effect { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that applies a bi-level alpha threshold.
  /// </summary>
  public AlphaBiLevel? AlphaBiLevel { get; set; }
  /// <summary>
  ///   Gets or sets a flag indicating whether alpha ceiling (maximum alpha) is applied.
  /// </summary>
  public bool? AlphaCeiling { get; set; }
  /// <summary>
  ///   Gets or sets a flag indicating whether alpha floor (minimum alpha) is applied.
  /// </summary>
  public bool? AlphaFloor { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that inverts the alpha channel.
  /// </summary>
  public AlphaInverse? AlphaInverse { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that modulates alpha based on another effect.
  /// </summary>
  public AlphaModulationEffect? AlphaModulationEffect { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that applies a fixed alpha modulation.
  /// </summary>
  public AlphaModulationFixed? AlphaModulationFixed { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that expands the alpha channel outward.
  /// </summary>
  public AlphaOutset? AlphaOutset { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that replaces the alpha channel.
  /// </summary>
  public AlphaReplace? AlphaReplace { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that applies a bi-level threshold to color channels.
  /// </summary>
  public BiLevel? BiLevel { get; set; }
  /// <summary>
  ///   Gets or sets a blend effect node that combines multiple visual elements.
  /// </summary>
  public Blend? Blend { get; set; }
  /// <summary>
  ///   Gets or sets a blur effect node that softens the appearance of the object.
  /// </summary>
  public Blur? Blur { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that changes colors based on specified rules.
  /// </summary>
  public ColorChange? ColorChange { get; set; }
  /// <summary>
  ///   Gets or sets an effect node that replaces one color with another.
  /// </summary>
  public ColorReplacement? ColorReplacement { get; set; }
  /// <summary>
  ///   Gets or sets a duotone effect node that maps colors to two tones.
  /// </summary>
  public Duotone? Duotone { get; set; }
  /// <summary>
  ///   Gets or sets a fill effect node that applies a solid or gradient fill.
  /// </summary>
  public Fill? Fill { get; set; }
  /// <summary>
  ///   Gets or sets a fill overlay effect node that layers a fill over the object.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }
  /// <summary>
  ///   Gets or sets a glow effect node that adds a colored halo around the object.
  /// </summary>
  public Glow? Glow { get; set; }
  /// <summary>
  ///   Gets or sets a flag indicating whether the object is rendered in grayscale.
  /// </summary>
  public Boolean Grayscale { get; set; }
  /// <summary>
  ///   Gets or sets an HSL (Hue, Saturation, Luminance) color effect node.
  /// </summary>
  public Hsl? Hsl { get; set; }
  /// <summary>
  ///   Gets or sets an inner shadow effect node applied inside the object's edges.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }
  /// <summary>
  ///   Gets or sets a luminance effect node that adjusts brightness and contrast.
  /// </summary>
  public LuminanceEffect? LuminanceEffect { get; set; }
  /// <summary>
  ///   Gets or sets an outer shadow effect node applied outside the object's edges.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }
  /// <summary>
  ///   Gets or sets a preset shadow effect node using predefined shadow styles.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }
  /// <summary>
  ///   Gets or sets a reflection effect node that creates a mirrored image below the object.
  /// </summary>
  public Reflection? Reflection { get; set; }
  /// <summary>
  ///   Gets or sets a relative offset effect node that shifts the object or its effect.
  /// </summary>
  public RelativeOffset? RelativeOffset { get; set; }
  /// <summary>
  ///   Gets or sets a soft edge effect node that feathers the object's edges.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }
  /// <summary>
  ///   Gets or sets a tint effect node that applies a color tint to the object.
  /// </summary>
  public TintEffect? TintEffect { get; set; }
  /// <summary>
  ///   Gets or sets a transform effect node that applies geometric transformations.
  /// </summary>
  public TransformEffect? TransformEffect { get; set; }
}