namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class Bookmark
{
  public bool ShouldSerializeStart() => Start is not null && ShouldSerialize(Start);
  public bool ShouldSerializeEnd() => End is not null && ShouldSerialize(End);
}
