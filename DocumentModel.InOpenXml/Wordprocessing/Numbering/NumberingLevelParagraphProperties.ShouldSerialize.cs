namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class NumberingLevelParagraphProperties
{
  public bool ShouldSerializeParagraphStyleId() => !String.IsNullOrEmpty(ParagraphStyleId);
}
