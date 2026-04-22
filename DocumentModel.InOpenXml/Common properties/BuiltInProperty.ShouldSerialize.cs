namespace DocumentModel;

#pragma warning disable CS1591

public partial class BuiltInProperty
{
  public bool ShouldSerializeValue() => Value is not null;
  public bool ShouldSerializeType() => Type is not null;
}
