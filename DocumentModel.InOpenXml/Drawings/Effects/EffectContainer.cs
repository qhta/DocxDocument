namespace DocumentModel.Drawings;

/// <summary>
///   Represents a container for visual effects applied to DrawingML objects.
/// </summary>
/// <remarks>
///   <para>
///   The <b>EffectContainer</b> interface defines a composite structure for organizing and applying multiple visual effects
///   to shapes, images, and other graphical elements in DrawingML. It enables hierarchical and sequential effect composition,
///   allowing complex visual treatments to be built from simpler effect primitives.
///   </para>
///   <para>
///   An effect container can include child containers, individual effects, and a variety of effect types such as shadows,
///   glows, blurs, color transformations, and more. This structure supports both effect stacking (sequential application)
///   and effect grouping (nested containers).
///   </para>
///   <para>
///   Common use cases include:
///   <list type="bullet">
///     <item><description>Applying multiple effects in a specific order</description></item>
///     <item><description>Grouping related effects for reuse or inheritance</description></item>
///     <item><description>Defining complex effect graphs for advanced rendering</description></item>
///   </list>
///   </para>
///   <para>
///   The container supports both direct effect references and nested containers, enabling flexible effect architectures.
///   </para>
/// </remarks>
public class EffectContainer: ModelElement<DXD.EffectContainer>
{
  /// <summary>
  ///   Gets or sets a nested child effect container for hierarchical effect composition.
  /// </summary>
  public EffectContainer? ChildEffectContainer { get; set; }

  /// <summary>
  ///   Gets or sets a reference to a single effect applied within this container.
  /// </summary>
  public Effect? Effect { get; set; }

  /// <summary>
  ///   Gets or sets an effect that applies a bi-level alpha threshold.
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
  ///   Gets or sets an effect that inverts the alpha channel.
  /// </summary>
  public AlphaInverse? AlphaInverse { get; set; }

  /// <summary>
  ///   Gets or sets an effect that modulates alpha based on another effect.
  /// </summary>
  public AlphaModulationEffect? AlphaModulationEffect { get; set; }

  /// <summary>
  ///   Gets or sets an effect that applies a fixed alpha modulation.
  /// </summary>
  public AlphaModulationFixed? AlphaModulationFixed { get; set; }

  /// <summary>
  ///   Gets or sets an effect that expands the alpha channel outward.
  /// </summary>
  public AlphaOutset? AlphaOutset { get; set; }

  /// <summary>
  ///   Gets or sets an effect that replaces the alpha channel.
  /// </summary>
  public AlphaReplace? AlphaReplace { get; set; }

  /// <summary>
  ///   Gets or sets an effect that applies a bi-level threshold to color channels.
  /// </summary>
  public BiLevel? BiLevel { get; set; }

  /// <summary>
  ///   Gets or sets a blend effect that combines multiple visual elements.
  /// </summary>
  public Blend? Blend { get; set; }

  /// <summary>
  ///   Gets or sets a blur effect that softens the appearance of the object.
  /// </summary>
  public Blur? Blur { get; set; }

  /// <summary>
  ///   Gets or sets an effect that changes colors based on specified rules.
  /// </summary>
  public ColorChange? ColorChange { get; set; }

  /// <summary>
  ///   Gets or sets an effect that replaces one color with another.
  /// </summary>
  public ColorReplacement? ColorReplacement { get; set; }

  /// <summary>
  ///   Gets or sets a duotone effect that maps colors to two tones.
  /// </summary>
  public Duotone? Duotone { get; set; }

  /// <summary>
  ///   Gets or sets a fill effect that applies a solid or gradient fill.
  /// </summary>
  public Fill? Fill { get; set; }

  /// <summary>
  ///   Gets or sets a fill overlay effect that layers a fill over the object.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }

  /// <summary>
  ///   Gets or sets a glow effect that adds a colored halo around the object.
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  ///   Gets or sets a flag indicating whether the object is rendered in grayscale.
  /// </summary>
  public Boolean Grayscale { get; set; }

  /// <summary>
  ///   Gets or sets an HSL (Hue, Saturation, Luminance) color effect.
  /// </summary>
  public Hsl? Hsl { get; set; }

  /// <summary>
  ///   Gets or sets an inner shadow effect applied inside the object's edges.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }

  /// <summary>
  ///   Gets or sets a luminance effect that adjusts brightness and contrast.
  /// </summary>
  public LuminanceEffect? LuminanceEffect { get; set; }

  /// <summary>
  ///   Gets or sets an outer shadow effect applied outside the object's edges.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }

  /// <summary>
  ///   Gets or sets a preset shadow effect using predefined shadow styles.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }

  /// <summary>
  ///   Gets or sets a reflection effect that creates a mirrored image below the object.
  /// </summary>
  public Reflection? Reflection { get; set; }

  /// <summary>
  ///   Gets or sets a relative offset effect that shifts the object or its effect.
  /// </summary>
  public RelativeOffset? RelativeOffset { get; set; }

  /// <summary>
  ///   Gets or sets a soft edge effect that feathers the object's edges.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }

  /// <summary>
  ///   Gets or sets a tint effect that applies a color tint to the object.
  /// </summary>
  public TintEffect? TintEffect { get; set; }

  /// <summary>
  ///   Gets or sets a transform effect that applies geometric transformations.
  /// </summary>
  public TransformEffect? TransformEffect { get; set; }
}