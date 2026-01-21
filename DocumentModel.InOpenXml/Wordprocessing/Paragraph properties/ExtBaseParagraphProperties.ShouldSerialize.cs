namespace DocumentModel.Wordprocessing;

public partial class ExtBaseParagraphProperties
{
  public bool ShouldSerializeParagraphStyleId() => ParagraphStyleId is not null;
  public bool ShouldSerializeDivId() => DivId is not null;
  public bool ShouldSerializeConditionalFormatStyle() => ConditionalFormatStyle is not null;
}
