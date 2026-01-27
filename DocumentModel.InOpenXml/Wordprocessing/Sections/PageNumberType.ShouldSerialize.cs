namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageNumberType
{
  public bool ShouldSerializeFormat() => Format is not null;
  public bool ShouldSerializeStart() => Start is not null;
  public bool ShouldSerializeChapterStyle() => ChapterStyle is not null;
  public bool ShouldSerializeChapterSeparator() => ChapterSeparator is not null;
}
