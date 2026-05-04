namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class LatentStyle
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeLocked() => Locked is not null;
  public bool ShouldSerializeUiPriority() => UiPriority is not null && ShouldSerialize(UiPriority);
  public bool ShouldSerializeSemiHidden() => SemiHidden is not null;
  public bool ShouldSerializeUnhideWhenUsed() => UnhideWhenUsed is not null;
  public bool ShouldSerializePrimaryStyle() => PrimaryStyle is not null;
}
