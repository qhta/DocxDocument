namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ContentPart
{
  public bool ShouldSerializeId() => !String.IsNullOrEmpty(Id);
}
