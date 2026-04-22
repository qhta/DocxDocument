namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class PreviousParagraphProperties
{
  public bool ShouldSerializeParagraphStyleId() => !String.IsNullOrEmpty(ParagraphStyleId);
}
