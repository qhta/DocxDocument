namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class LatentStyles
{
  public bool ShouldSerializeDefaultLockedState() => DefaultLockedState is not null;
  public bool ShouldSerializeDefaultUiPriority() => DefaultUiPriority is not null;
  public bool ShouldSerializeDefaultSemiHidden() => DefaultSemiHidden is not null;
  public bool ShouldSerializeDefaultUnhideWhenUsed() => DefaultUnhideWhenUsed is not null;
  public bool ShouldSerializeDefaultPrimaryStyle() => DefaultPrimaryStyle is not null;
}
