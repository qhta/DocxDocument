namespace DocumentModel.Wordprocessing;

public partial class ParagraphPropertiesChange
{
  public bool ShouldSerializePreviousParagraphProperties() => PreviousParagraphProperties is not null;
}
