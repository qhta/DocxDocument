namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591
public partial class CaptionDefinition
{
  public bool ShouldSerializeName() => Name is not null;
  public bool ShouldSerializePosition() => Position is not null;
  public bool ShouldSerializeChapterNumber() => ChapterNumber is not null;
  public bool ShouldSerializeHeading() => Heading is not null;
  public bool ShouldSerializeNoLabel() => NoLabel is not null;
  public bool ShouldSerializeNumberFormat() => NumberFormat is not null;
  public bool ShouldSerializeSeparator() => Separator is not null;
}
