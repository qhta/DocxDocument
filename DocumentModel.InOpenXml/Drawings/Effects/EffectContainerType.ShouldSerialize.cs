namespace DocumentModel.Drawings;

public partial class EffectContainerType
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeName() => Name is not null;
}
