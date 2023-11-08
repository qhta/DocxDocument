namespace ModelGen;

/// <summary>
/// <see cref="SchemaParticle"/> which declares the item element of the owner type info.
/// </summary>
public class ItemElementParticle: SchemaParticle
{
  public TypeInfo ItemType { [DebuggerStepThrough] get; set; } = null!;
  public PropInfo? AccessProperty { [DebuggerStepThrough] get; set; }
}