namespace DocumentModel.Wordprocessing;

public partial class ParagraphMarkRunPropertiesChange
{
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousParagraphMarkRunProperties() => PreviousParagraphMarkRunProperties is not null;
}
