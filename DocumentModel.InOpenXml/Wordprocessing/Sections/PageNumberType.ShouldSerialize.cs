namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PageNumberType
{
  public bool ShouldSerializeFormat() => Format is not null && ShouldSerialize(Format);
  public bool ShouldSerializeStart() => Start is not null && ShouldSerialize(Start);
  public bool ShouldSerializeChapterStyle() => ChapterStyle is not null && ShouldSerialize(ChapterStyle);
  public bool ShouldSerializeChapterSeparator() => ChapterSeparator is not null && ShouldSerialize(ChapterSeparator);
}
