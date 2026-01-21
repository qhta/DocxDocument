namespace DocumentModel.Wordprocessing;

public partial class ParagraphMarkRunPropertiesChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousParagraphMarkRunProperties() => PreviousParagraphMarkRunProperties is not null;
}
