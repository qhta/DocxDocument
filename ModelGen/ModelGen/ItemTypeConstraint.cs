namespace ModelGen;

public class ItemTypeConstraint: ItemsConstraint
{
  public TypeInfo ItemType { get; set; } = null!;
  public PropInfo? AccessProperty { get; set; }
}