namespace DocumentModel.Wordprocessing;

public partial class ContentPart
{
  public bool ShouldSerializeId() => Id is not null;
}
