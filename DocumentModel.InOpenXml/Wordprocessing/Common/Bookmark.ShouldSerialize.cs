namespace DocumentModel.Wordprocessing;

public partial class Bookmark
{
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeEnd() => End is not null;
}
