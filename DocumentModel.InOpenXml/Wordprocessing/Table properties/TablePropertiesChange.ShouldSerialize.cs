namespace DocumentModel.Wordprocessing;

public partial class TablePropertiesChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTableProperties() => PreviousTableProperties is not null;
}
