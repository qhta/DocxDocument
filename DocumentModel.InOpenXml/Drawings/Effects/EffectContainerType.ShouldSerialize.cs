namespace DocumentModel.Drawings;

#pragma warning disable CS1591

public partial class EffectContainerType
{
  public bool ShouldSerializeType() => Type is not null;
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
}
