namespace DocumentModel.Drawings;

/// <summary>
///   Represents a reference to a visual effect that can be applied to drawing objects.
/// </summary>
/// <remarks>
///   <para>
///   The Effect interface serves as a reference mechanism for applying visual effects to DrawingML objects
///   such as shapes, pictures, and other graphical elements. Effects enhance the visual appearance of objects
///   by adding shadows, reflections, glows, blurs, and other visual treatments.
///   </para>
///   <para>
///   In DrawingML, effects are typically defined in effect containers (such as EffectList or EffectDag)
///   and then referenced by drawing objects. The Effect interface provides the linkage mechanism through
///   the Reference property, which points to a specific effect definition.
///   </para>
///   <para>
///   Common effect types that can be referenced include:
///   <list type="bullet">
///     <item><description><strong>Shadow effects</strong> - Outer shadow, inner shadow, perspective shadow</description></item>
///     <item><description><strong>Reflection effects</strong> - Mirror reflections below objects</description></item>
///     <item><description><strong>Glow effects</strong> - Soft edges with colored halos</description></item>
///     <item><description><strong>Soft edge effects</strong> - Feathered, blurred edges</description></item>
///     <item><description><strong>Blur effects</strong> - Gaussian blur, motion blur</description></item>
///     <item><description><strong>Fill overlay effects</strong> - Color or pattern overlays</description></item>
///     <item><description><strong>3D effects</strong> - Bevel, extrusion, contour</description></item>
///   </list>
///   </para>
///   <para>
///   The Effect interface is part of the DrawingML effect system architecture that allows for:
///   <list type="bullet">
///     <item><description>Reusable effect definitions across multiple objects</description></item>
///     <item><description>Effect composition and layering (effect stacks)</description></item>
///     <item><description>Efficient rendering by referencing shared effect definitions</description></item>
///     <item><description>Dynamic effect application and modification</description></item>
///   </list>
///   </para>
///   <para>
///   Effects can be organized in two main structures:
///   <list type="bullet">
///     <item><description><strong>EffectList</strong> - Sequential list of effects applied in order</description></item>
///     <item><description><strong>EffectDag</strong> (Directed Acyclic Graph) - Complex effect relationships with dependencies</description></item>
///   </list>
///   </para>
/// </remarks>
public interface Effect
{
  /// <summary>
  ///   Gets or sets the reference identifier that links to a specific effect definition.
  /// </summary>
  /// <remarks>
  ///   <para>
  ///   Specifies a unique identifier string that references a particular effect definition within
  ///   the document's effect system. This identifier establishes a link between the Effect reference
  ///   and the actual effect implementation or definition.
  ///   </para>
  ///   <para>
  ///   The reference string typically contains:
  ///   <list type="bullet">
  ///     <item><description>A unique identifier (GUID, numeric ID, or named reference)</description></item>
  ///     <item><description>A pointer to an effect definition in an effect container</description></item>
  ///     <item><description>A key that maps to a predefined effect in the document's effect library</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Usage patterns:
  ///   <list type="bullet">
  ///     <item>
  ///       <description>
  ///         <strong>Direct reference:</strong> Points to a specific effect by ID 
  ///         (e.g., "effect1", "shadow-outer-1", "{guid}")
  ///       </description>
  ///     </item>
  ///     <item>
  ///       <description>
  ///         <strong>Named reference:</strong> Uses a human-readable name 
  ///         (e.g., "DropShadow", "GlowEffect", "Reflection")
  ///       </description>
  ///     </item>
  ///     <item>
  ///       <description>
  ///         <strong>Indexed reference:</strong> References effects by position in an effect collection
  ///       </description>
  ///     </item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   The reference mechanism enables several important capabilities:
  ///   <list type="bullet">
  ///     <item><description><strong>Effect reuse:</strong> Multiple objects can reference the same effect definition</description></item>
  ///     <item><description><strong>Effect inheritance:</strong> Objects can inherit effects from parent containers</description></item>
  ///     <item><description><strong>Effect composition:</strong> Complex effects built from simpler referenced effects</description></item>
  ///     <item><description><strong>Memory efficiency:</strong> Avoids duplicating effect definitions</description></item>
  ///     <item><description><strong>Dynamic updates:</strong> Changing the referenced effect updates all objects using it</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   When the Reference is null or empty, it typically indicates:
  ///   <list type="bullet">
  ///     <item><description>No effect is applied</description></item>
  ///     <item><description>The effect is defined inline rather than referenced</description></item>
  ///     <item><description>A default or inherited effect should be used</description></item>
  ///   </list>
  ///   </para>
  ///   <para>
  ///   Example reference formats:
  ///   <code>
  ///   // GUID-based reference:
  ///   Reference = "{A1B2C3D4-E5F6-7890-ABCD-EF1234567890}";
  ///   
  ///   // Named reference:
  ///   Reference = "OuterShadowEffect";
  ///   
  ///   // Indexed reference:
  ///   Reference = "effect[0]";
  ///   
  ///   // Hierarchical reference:
  ///   Reference = "effects/shadows/outer";
  ///   </code>
  ///   </para>
  /// </remarks>
  public string? Reference { get; set; }
}