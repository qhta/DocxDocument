namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class LatentStyleExceptionInfo
{
  public bool ShouldSerializeStyleName() => !String.IsNullOrEmpty(StyleName);
  public bool ShouldSerializeAliases() => Aliases is not null && ShouldSerialize(Aliases);
}
