namespace ModelGen;

/// <summary>
/// <see cref="SchemaParticle"/> which declares the item element of the owner type info.
/// </summary>
public class ItemElementParticle: SchemaParticle
{
  public TypeInfo ItemType { get; set; } = null!;
  public PropInfo? AccessProperty { get; set; }
}