namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class AutoCaption
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializeCaption() => !String.IsNullOrEmpty(Caption);
}
