namespace DocumentModel.Wordprocessing;

public partial class LatentStyleExceptionInfo
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeLocked() => Locked is not null;
  public bool ShouldSerializeUiPriority() => UiPriority is not null;
  public bool ShouldSerializeSemiHidden() => SemiHidden is not null;
  public bool ShouldSerializeUnhideWhenUsed() => UnhideWhenUsed is not null;
  public bool ShouldSerializePrimaryStyle() => PrimaryStyle is not null;
}
