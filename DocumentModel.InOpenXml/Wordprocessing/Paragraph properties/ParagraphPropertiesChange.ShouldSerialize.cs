namespace DocumentModel.Wordprocessing;

#pragma warning disable CS1591

public partial class ParagraphPropertiesChange
{
  public bool ShouldSerializePreviousParagraphProperties() => PreviousParagraphProperties is not null && ShouldSerialize(PreviousParagraphProperties);
}
