namespace DocumentModel.Drawings;
/// <summary>
///   Represents metadata describing a container for visual effects in DrawingML.
/// </summary>
[OpenXmlType(typeof(DXD.EffectContainerType))]
public partial class EffectContainerType : ModelElement<DXD.EffectContainerType>
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
 ///   The value is typically an enumeration (EffectContainment) that may include options like:
 ///   <list type="bullet">
 ///     <item><description>Outer - effects applied outside the object</description></item>
 ///     <item><description>Inner - effects applied inside the object</description></item>
 ///     <item><description>Background - effects applied to the background</description></item>
 ///     <item><description>Group - a generic grouping of effects</description></item>
 ///   </list>
 ///   </para>
 /// </remarks>
 [OpenXmlProperty(nameof(DXD.EffectContainerType.Type))]
 public EffectContainment? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
 private EffectContainment? _Type;
 /// <summary>
 ///   FontName of the effect container for identification or documentation purposes.
 /// </summary>
 /// <remarks>
 ///   <para>
 ///   The <b>FontName</b> property provides a human-readable identifier for the effect container, which can be used
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
 [OpenXmlProperty(nameof(DXD.EffectContainerType.Name))]
 public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
 private string? _Name;
}