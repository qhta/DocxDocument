namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class AutoCaption
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializeCaption() => Caption is not null;
}
