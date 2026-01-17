namespace DocumentModel.Drawings;

/// <summary>
///   Represents metadata describing a container for visual effects in DrawingML.
/// </summary>
/// <remarks>
///   <para>
///   The <b>EffectContainerType</b> interface defines the type and name of an effect container, which organizes
///   and groups multiple visual effects (such as shadows, glows, blurs, and color transformations) for shapes,
///   images, and other graphical elements in DrawingML.
///   </para>
///   <para>
///   Effect containers enable hierarchical and sequential composition of effects, allowing complex visual treatments
///   to be built from simpler effect primitives. The container type determines how effects are grouped and applied,
///   while the name provides a human-readable identifier for referencing or documentation.
///   </para>
///   <para>
///   Typical use cases include:
///   <list type="bullet">
///     <item><description>Distinguishing between effect groups (e.g., "outerEffects", "innerEffects")</description></item>
///     <item><description>Identifying effect containers for reuse or inheritance</description></item>
///     <item><description>Providing semantic meaning for effect collections</description></item>
///   </list>
///   </para>
/// </remarks>
public class EffectContainerType: ModelElement<DXD.EffectContainerType>
{
  /// <summary>
  ///   Type of the effect container, indicating how effects are grouped or applied.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The <b>Type</b> property specifies the container's organizational role, such as grouping effects sequentially,
  ///   nesting them hierarchically, or defining special effect regions (e.g., outer, inner, background).
  ///   </para>
  ///   <para>
  ///   The value is typically an enumeration (EffectContainerKind) that may include options like:
  ///   <list type="bullet">
  ///     <item><description>Outer - effects applied outside the object</description></item>
  ///     <item><description>Inner - effects applied inside the object</description></item>
  ///     <item><description>Background - effects applied to the background</description></item>
  ///     <item><description>Group - a generic grouping of effects</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public EffectContainerKind? Type { get; set; }

  /// <summary>
  ///   Name of the effect container for identification or documentation purposes.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   The <b>Name</b> property provides a human-readable identifier for the effect container, which can be used
  ///   for referencing, documentation, or semantic grouping of effects. Names help distinguish between different
  ///   effect containers within a document or drawing context.
  ///   </para>
  ///   <para>
  ///   Example names include:
  ///   <list type="bullet">
  ///     <item><description>"OuterShadowEffects"</description></item>
  ///     <item><description>"GlowAndReflection"</description></item>
  ///     <item><description>"BackgroundEffects"</description></item>
  ///   </list>
  ///   </para>
  /// </remarks>
  public string? Name { get; set; }
}