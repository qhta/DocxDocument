namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class StyleDef
{
  public bool ShouldSerializeIsDefined() => IsDefined is not null;
  public bool ShouldSerializeIsVl() => IsVl is not null;
  public bool ShouldSerializeAliases() => Aliases is not null && ShouldSerialize(Aliases);
}
