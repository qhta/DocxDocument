namespace ModelGen;

public class ItemElementParticle: SchemaParticle
{
  public TypeInfo ItemType { get; set; } = null!;
  public PropInfo? AccessProperty { get; set; }
}