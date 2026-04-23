namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class CaptionDefinition
{
  public bool ShouldSerializeName() => !String.IsNullOrEmpty(Name);
  public bool ShouldSerializePosition() => Position is not null && ShouldSerialize(Position);
  public bool ShouldSerializeChapterNumber() => ChapterNumber is not null;
  public bool ShouldSerializeHeading() => Heading is not null;
  public bool ShouldSerializeNoLabel() => NoLabel is not null;
  public bool ShouldSerializeNumberFormat() => NumberFormat is not null && ShouldSerialize(NumberFormat);
  public bool ShouldSerializeSeparator() => Separator is not null && ShouldSerialize(Separator);
}
