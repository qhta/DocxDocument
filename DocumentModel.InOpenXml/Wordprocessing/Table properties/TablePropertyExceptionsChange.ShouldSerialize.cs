namespace DocumentModel.Wordprocessing;

public partial class TablePropertyExceptionsChange
{
  public bool ShouldSerializeAuthor() => Author is not null;
  public bool ShouldSerializeDate() => Date is not null;
  public bool ShouldSerializeAnnotationId() => AnnotationId is not null;
  public bool ShouldSerializePreviousTablePropertyExceptions() => PreviousTablePropertyExceptions is not null;
}
